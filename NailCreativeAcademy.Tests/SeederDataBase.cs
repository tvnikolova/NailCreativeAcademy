namespace NailCreativeAcademy.Tests
{
    using System;
    using System.Globalization;
    using Infrastructure.Data;
    using Infrastructure.Data.Models;
    
    using static Infrastructure.Constants.NailCreativeConstants;
    public static class SeederDataBase
    {
        public static Course Course1;
        public static Course Course2;
        public static Feedback Feedback1;
        public static Gallery Gallery1;
        public static Saloon Saloon1;
        public static Trainer Trainer3;
        public static Trainer Trainer4;
        public static ApplicationUser AdminUser;
        public static ApplicationUser Student1;
        public static EnrolledStudent EnrolledStudent1;
        public static CourseType FirstType;
        public static CourseType SecondType;
        public static void SeedDatabase(NailCreativeDbContext dbContext)
        {
            AdminUser = new ApplicationUser()
            {
                Id = "5854a84fce2047e383c6ab36f99c7a9f",
                UserName = "mp123@abv.bg",
                NormalizedUserName = "MP123@ABV.BG",
                Email = "mp123@abv.bg",
                NormalizedEmail = "MP123@ABV.BG",
                PhoneNumber = "+359887413622",
                FirstName = "Зорница",
                LastName = "Николова"
            };
            Student1 = new ApplicationUser()
            {
                Id = "9e32383c4f944c0da1dd474c70922f13",
                UserName = "mp456@abv.bg",
                NormalizedUserName = "MP456@ABV.BG",
                Email = "mp456@abv.bg",
                NormalizedEmail = "MP456@ABV.BG",
                PhoneNumber = "+359887413623",
                FirstName = "Михаил",
                LastName = "Михайлова"
            };
            Course1 = new Course()
            {
                Id = 6,
                Name = "КОМБИНИРАН АПАРАТЕН МАНИКЮР",
                Details = "Комбиниран апаратен маникюр-детайли",
                StartDate = DateTime.ParseExact("20/06/2024 03:30", DateOProjectString, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("22/06/2024 17:30", DateOProjectString, CultureInfo.InvariantCulture),
                Duration = "40 часа",
                CourseTypeId = 4,
                Program = "Комбиниран апаратен маникюр-програма",
                TrainerId = 2,
                Price = 420.00m
            };
            Course2 = new Course()
            {
                Id = 17,
                Name = "БАЗОВ КУРС ПО МАНИКЮР 2024",
                Details = "БАЗОВ КУРС ПО МАНИКЮР -детайли",
                StartDate = DateTime.ParseExact("01/06/2024 15:30", DateOProjectString, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("05/06/2024 17:30", DateOProjectString, CultureInfo.InvariantCulture),
                Duration = "40 часа",
                CourseTypeId = 3,
                Program = "БАЗОВ КУРС ПО МАНИКЮР-програма",
                TrainerId = 2,
                Price = 420.00m
            };
            EnrolledStudent1 = new EnrolledStudent()
            {
                StudentId = Student1.Id,
                CourseId = Course1.Id
            };
            Feedback1 = new Feedback()
            {
                Review = "Благодаря от сърце! Вече не се притеснявам, че мога да навредя на ноктите на клиентка! Невероятни сте!",
                CourseId = Course1.Id,
                ClientId = "b8b63dd7e8f14a01b3d4ef4bb901b2e4"
            };
            Gallery1 = new Gallery()
            {
                Name = "2811899d-da0d-4e66-a7be-8b256202a25a.png"
            };
            Saloon1 = new Saloon()
            {
                Name = "Nail Creative",
                Address = "Пазарджик, бул.\"България\" 10",
                PhoneNumber = "+359887413622",
                ClientId = "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
            };
            Trainer3 = new Trainer()
            {
                Id = 20,
                Name = "Елена Зойкова",
                About = "Елена Зойкова е международен съдия и обучител." +
                " Тя е майстор с над 10 години опит в областта на маникюра. " +
                "Създала е програми за основни и надграждащи курсове. " +
                "Елена е международен съдия и многократен победител " +
                "в международни конкурси за ноктопластика."
            };
            Trainer4 = new Trainer()
            {
                Id = 30,
                Name = "Елена Макаренко",
                About = "Елена Макаренко е международен съдия и обучител." +
                " Тя е майстор с над 10 години опит в областта на педикюра. "
            };
            FirstType = new CourseType()
            {
                Id = 3,
                Name = "Начинаещи"

            };

            SecondType = new CourseType()
            {
                Id = 4,
                Name = "Напреднали"
            };

            dbContext.Users.Add(AdminUser);
            dbContext.Users.Add(Student1);
            dbContext.Courses.Add(Course1);
            dbContext.Courses.Add(Course2);
            dbContext.Trainers.Add(Trainer3);
            dbContext.Trainers.Add(Trainer4);
            dbContext.Saloons.Add(Saloon1);
            dbContext.Galleries.Add(Gallery1);
            dbContext.Feedbacks.Add(Feedback1);
            dbContext.EnrolledStudents.Add(EnrolledStudent1);
            dbContext.CoursesTypes.Add(FirstType);
            dbContext.CoursesTypes.Add(SecondType);

            dbContext.SaveChanges();
        }
    }
}
