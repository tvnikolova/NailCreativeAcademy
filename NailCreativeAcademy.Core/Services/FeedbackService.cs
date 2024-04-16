namespace NailCreativeAcademy.Core.Services
{
    
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models.Feedback;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using Contracts;


    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository repository;
		
        public FeedbackService(IRepository _repository)
        {
            this.repository = _repository;
			
        }
		public async Task<IEnumerable<FeedbackViewModel>> AllAsync(int courseId)
		{
			
			IEnumerable<FeedbackViewModel> allFeedBacks = await repository.AllReadOnly<Feedback>()
																		.Where(c=>c.CourseId==courseId)
																		   .Select(fb => new FeedbackViewModel()
																		   {
																			   Id = fb.Id,
																			   Review = fb.Review,
																			   ClientName = $"{fb.Client.FirstName} {fb.Client.LastName}",
																			   CourseName = fb.Course.Name,
																			   ClientId=fb.ClientId
																		   })
																		   .ToListAsync();

			return allFeedBacks;
		}

		public async Task<int> AddAsync(FeedbackFormModel feedback, int courseId)
		{
			Feedback newFeedback = new Feedback()
			{
				Review = feedback.Review,
				ClientId = feedback.ClientId,
				CourseId = courseId,
				

			};
				await  repository.AddAsync(newFeedback);
				await repository.SaveChangesAsync();
			
			return newFeedback.Id;
		}

        public async  Task EditAsync(FeedbackFormModel model, int feedbackId)
        {
            var feedbackToEdit = await repository.All<Feedback>()
                                                .Where(f => f.Id== feedbackId)
                                                .FirstOrDefaultAsync();

            if (feedbackToEdit != null)
            {
                feedbackToEdit.Review = model.Review;

                await repository.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int feedbackId)
        {
            await repository.DeleteAsync<Feedback>(feedbackId);
            await repository.SaveChangesAsync();
        }

        public async Task<FeedbackFormModel> GetFeedbackById(int feedbackId)
        {
            var foundFeedback = await repository.AllReadOnly<Feedback>()
                                                               .Where(f => f.Id == feedbackId)
                                                               .Select(f=>new FeedbackFormModel()
                                                               {
                                                                   ClientId=f.ClientId,
                                                                   CourseId=f.CourseId,
                                                                   Review=f.Review,
                                                               })
                                                               .FirstAsync();
           
                
                return  foundFeedback; 
            
        }

        public async Task<FeedbackViewModel> GetFeedbackToDeleteAsync(int feedbackId)
        {
            var foundFeedback = await repository.AllReadOnly<Feedback>()
                                                               .Where(f => f.Id == feedbackId)
                                                               .Select(f => new FeedbackViewModel()
                                                               {
                                                                   ClientId = f.ClientId,
                                                                   Review = f.Review,
                                                                   CourseName=f.Course.Name,
                                                                   ClientName= $"{f.Client.FirstName} {f.Client.LastName}"
                                                               })
                                                               .FirstAsync();


            return foundFeedback;
        }
    }
}
