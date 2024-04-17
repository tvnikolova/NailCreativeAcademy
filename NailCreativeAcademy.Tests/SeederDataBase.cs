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
        public static Feedback Feedback1;
        public static Gallery Gallery1;
        public static Saloon Saloon1;
        public static Trainer Trainer1;

        public static void SeedDatabase(NailCreativeDbContext dbContext)
        {
            dbContext.Database.EnsureCreated(); 

            Course1 = new Course()
            {
                Id = 6,
                Name = "КОМБИНИРАН АПАРАТЕН МАНИКЮР",
                Details = "Комбиниран апаратен маникюр-детайли",
                StartDate = DateTime.ParseExact("20/06/2024 03:30", DateOProjectString, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("22/06/2024 17:30", DateOProjectString, CultureInfo.InvariantCulture),
                Duration = "40 часа",
                CourseTypeId = 2,
                Program = "Комбиниран апаратен маникюр-програма",
                TrainerId = 2,
                Price = 420.00m
            };
            Feedback1 = new Feedback()
            {
                Review = "Благодаря от сърце! Вече не се притеснявам, че мога да навредя на ноктите на клиентка! Невероятни сте!",
                CourseId = 6,
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
            Trainer1 = new Trainer()
            {
                Name = "Елена Кушниренко",
                About = "Елена Кушниренко е международен съдия и обучител." +
                " Тя е майстор с над 10 години опит в областта на маникюра. " +
                "Създала е програми за основни и надграждащи курсове. " +
                "Елена е международен съдия и многократен победител " +
                "в международни конкурси за ноктопластика."
            };

            dbContext.Courses.Add(Course1);
            dbContext.Trainers.Add(Trainer1);
            dbContext.Saloons.Add(Saloon1);
            dbContext.Galleries.Add(Gallery1);
            dbContext.Feedbacks.Add(Feedback1);

            dbContext.SaveChanges();
        }
    }
}
