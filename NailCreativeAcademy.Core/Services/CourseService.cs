﻿namespace NailCreativeAcademy.Core.Services
{
    using System.Globalization;
    using Microsoft.EntityFrameworkCore;
    using System.Security.Claims;

    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;    
    using Models.Course;
    using Contracts.Course;
    
    
    using static Infrastructure.Constants.NailCreativeConstants;
    using Microsoft.AspNetCore.Identity;

    public class CourseService : ICourseService
    {
        private readonly IRepository repository;
        public CourseService(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<CourseViewModel>> All()
        {

            var courses = await repository.AllReadOnly<Course>()
                                           .Select(c => new CourseViewModel()
                                           {
                                               Id= c.Id,
                                               Name = c.Name,
                                               StartDate = c.StartDate.ToString(DateOProjectString),
                                               Details = c.Details,
                                               Image = c.Image,
                                               Duration = c.Duration,
                                               Price = c.Price,
                                               TrainerId = c.TrainerId,

                                           })
                                           .ToListAsync();

            return courses;

        }

        public async Task<int> CreateAsync(CourseFormModel model, int trainerId)
        {
            Course newCourse = new Course()
            {
                Name = model.Name,
                Details = model.Details,
                StartDate = DateTime.ParseExact(model.StartDate, DateOProjectString, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact(model.StartDate, DateOProjectString, CultureInfo.InvariantCulture),
                Duration = model.Duration,
                Price = model.Price,
                CourseTypeId = model.CourseTypeId,
                Program = model.Program,
                TrainerId = trainerId,
                Image = model.Image,
            };

            await repository.AddAsync(newCourse);
            await repository.SaveChangesAsync();

            return newCourse.Id;
        }

        public async Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync()
        {
            IEnumerable<CourseTypeViewModel> allTypes = await repository.AllReadOnly<CourseType>()
                                                .Select(c => new CourseTypeViewModel()
                                                {
                                                    Id = c.Id,
                                                    Name = c.Name
                                                })
                                                .ToListAsync();
            return allTypes;
        }

        public async Task<bool> CourseExistAsyncByName(string courseName)
        {
            return await repository.AllReadOnly<Course>()
                .AnyAsync(c => c.Name == courseName);
        }
        public async Task<bool> CourseExistAsyncById(int id)
        {
            return await repository.AllReadOnly<Course>()
                .AnyAsync(c => c.Id == id);
        }

        public async Task<CourseDetailsViewModel> DetailsAsync(int id)
        {
            CourseDetailsViewModel courses = await repository.AllReadOnly<Course>()
                                            .Where(c=>c.Id == id)
                                            .Select(c => new CourseDetailsViewModel()
                                            {
                                                Id=c.Id,
                                                Name = c.Name,
                                                Details = c.Details,
                                                Image = c.Image,

                                            })
                                            .FirstAsync();

            return courses;
        }

        public async Task<IEnumerable<MyCourseModel>> MyCoursesAsync(string userId)
        {
            
            var courses = await repository.AllReadOnly<EnrolledStudent>()
                                            .AsNoTracking()
                                            .Where(s=>s.StudentId == userId)
                                           .Select(es => new MyCourseModel()
                                           {
                                              Id = es.CourseId,
                                              Name = es.Course.Name,
                                              Program = es.Course.Program,
                                              Duration = es.Course.Duration,
                                              Image = es.Course.Image,
                                              Price = es.Course.Price,
                                              StartDate = es.Course.StartDate.ToString(DateOProjectString)                                           
                                           })
                                           .ToListAsync();

            return courses;

        }

        public async Task<bool> MyCourseExists(string userId, int courseId)
        {
            return await repository.AllReadOnly<EnrolledStudent>()
                .AnyAsync(c => c.StudentId== userId && c.CourseId== courseId);
        }

        public async Task<EnrolledStudent> GetMyEnrolledCourseById(string userId, int courseId)
        {
            var foundedCourse = await repository.AllReadOnly<EnrolledStudent>()
                                                 .Where(c => c.CourseId == courseId && c.StudentId == userId)
                                                 .FirstAsync();

            return foundedCourse;

        }
        public async Task<string> JoinedCourse(string userId, int courseId)
        {
            EnrolledStudent newCourseToAdd =  new EnrolledStudent()
            {
                StudentId = userId, 
                CourseId = courseId
            };

            await repository.AddAsync(newCourseToAdd);
            await repository.SaveChangesAsync();

            return newCourseToAdd.StudentId;

        }

        public async Task<MyCourseModel> GetMyCourseByIdAsync(int id)
        {
            var foundedCourse = await repository.AllReadOnly<Course>()
                                                 .Where(c=>c.Id== id)
                                                 .Select(c=> new MyCourseModel()
                                                 {
                                                     Id = c.Id,
                                                     Name = c.Name,
                                                     Duration = c.Duration,
                                                     Program = c.Program,
                                                     StartDate = c.StartDate.ToString(DateOProjectString),
                                                     Price = c.Price,
                                                     Image=c.Image
                                                 })
                                                 .FirstAsync();

            return foundedCourse;
           
        }

        public async Task RemoveMyCourse(int courseId, string userId)
        {
            var foundCourse = await repository.AllReadOnly<EnrolledStudent>()
                                               .Where(c=>c.CourseId==courseId && c.StudentId==userId)
                                               .FirstOrDefaultAsync();

            if (foundCourse != null)
            {
                await repository.RemoveAsync<EnrolledStudent>(courseId,userId);
                await repository.SaveChangesAsync();
            }

            

        }

        public async Task<CourseFormModel> GetCourseToEditByIdAsync(int id)
        {
            var courses = await repository.AllReadOnly<Course>()
                                            .Where(c => c.Id == id)
                                           .Select(c => new CourseFormModel()
                                           {
                                               Name = c.Name,
                                               Program = c.Program,
                                               Duration = c.Duration,
                                               Image = c.Image,
                                               Price = c.Price,
                                               StartDate = c.StartDate.ToString(DateOProjectString),
                                               Trainer = c.Trainer.Name
                                           })
                                           .FirstAsync();

            return courses;
        }

        public async Task EditAsync(CourseFormModel model, int id, int trainerId)
        {
            var courseToEdit = await repository.All<Course>()
                                                .Where(c => c.Id == id)
                                                .FirstOrDefaultAsync();
            var courseTypes = await GetCourseTypesAsync();

            if (courseToEdit != null)
            {
                courseToEdit.Name = model.Name;
                courseToEdit.Program = model.Program;
                courseToEdit.Duration = model.Duration;
                courseToEdit.Image = model.Image;
                courseToEdit.Price = model.Price;
                courseToEdit.StartDate = DateTime.ParseExact(model.StartDate, DateOProjectString, CultureInfo.InvariantCulture);
                courseToEdit.EndDate = DateTime.ParseExact(model.EndDate, DateOProjectString, CultureInfo.InvariantCulture);
                courseToEdit.TrainerId = trainerId;
                
                await repository.SaveChangesAsync();
            }
           
        }

        
        public async Task<DeleteCourseViewModel> GetCourseToDeleteAsync(int courseId)
        {
            var foundedCourse = await repository.AllReadOnly<Course>()
                                               .Where(c => c.Id == courseId)
                                               .FirstOrDefaultAsync();

            DeleteCourseViewModel courseToDelete = new DeleteCourseViewModel();

            if (foundedCourse != null )
            {

                courseToDelete.Id = foundedCourse.Id;
                courseToDelete.Name = foundedCourse.Name;
                courseToDelete.StartDate = foundedCourse.StartDate.ToString(DateOProjectString);
                
                
            }

            return courseToDelete;
        }


        public async Task DeleteAsync(int courseId)
        {
            await repository.DeleteAsync<Course>(courseId);
            await repository.SaveChangesAsync();
           
        }

        public async Task<bool> CourseHasEnrolledStudent(int courseId)
        {
           return await repository.AllReadOnly<EnrolledStudent>()
                                               .Where(c => c.CourseId == courseId)
                                               .AnyAsync();

        }
    }
}