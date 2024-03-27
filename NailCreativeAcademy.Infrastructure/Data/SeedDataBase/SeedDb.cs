namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.AspNetCore.Identity;
    using Models;

    public class SeedDb
    {
        public IdentityUser AdminUser { get; set; }
        public IdentityUser StudentUser1 { get; set; }
        public IdentityUser StudentUser2 { get; set; }
        public IdentityUser Client1{ get; set; }
        public Trainer FirstTrainer { get; set; }
        public Trainer SecondTrainer { get; set; }
        public Trainer ThirdTrainer { get; set; }  
        public CourseType FirstType { get; set; }
        public CourseType SecondType { get; set; }
        public Course BasicManicureCourse { get; set; }
        public Saloon Sallon1 { get; set; }
        public Saloon Sallon2 { get; set; }

        public SeedDb()
        {
            SeedUsers();
            SeedTrainers();
            SeedCourseTypes();
            SeedCourses();
            SeedSaloons();
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new IdentityUser()
            {
                Id = "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                UserName = "t_nikolova1985@abv.bg",
                NormalizedUserName = "t_nikolova1985@abv.bg",
                Email = "t_nikolova1985@abv.bg",
                NormalizedEmail = "student1@abv.bg"
            };
                AdminUser.PasswordHash =
                hasher.HashPassword(AdminUser, "tn123456");

            StudentUser1 = new IdentityUser()
            {
                Id = "68a865ce-5b33-4275-a460-dc00683172d2",
                UserName = "student1@abv.bg",
                NormalizedUserName = "student1@abv.bg",
                Email = "student1@abv.bg",
                NormalizedEmail = "student1@abv.bg"
            };
              StudentUser1.PasswordHash =
                    hasher.HashPassword(StudentUser1, "st1123456");

            StudentUser2 = new IdentityUser()
            {
                Id = "714e73f4716d4cf9946d494ed0d72cf7",
                UserName = "student2@abv.bg",
                NormalizedUserName = "student2@abv.bg",
                Email = "student2@abv.bg",
                NormalizedEmail = "student2@abv.bg"
            };
             StudentUser2.PasswordHash =
                  hasher.HashPassword(StudentUser2, "st2654321");

            Client1 = new IdentityUser()
            {
                Id = "cf756f58ca9146f2889a54a32cde2dfc",
                UserName = "client1@abv.bg",
                NormalizedUserName = "client1@abv.bg",
                Email = "client1@abv.bg",
                NormalizedEmail = "client1@abv.bg"
            };
            Client1.PasswordHash =
                 hasher.HashPassword(Client1, "cl123456");
        }

        private void SeedTrainers()
        {
            FirstTrainer = new Trainer
            {
                Id = 1,
                FirstName = "Ekaterina",
                LastName = "Gyurova",
                About = "Ekaterina Gyurova has been a trainer at the academy for 3 years.She is with 7 years of experience in the field of manicure." +
                 "There are several first places from winning international manicure competitions."
            };

            SecondTrainer = new Trainer
            {
                Id = 2,
                FirstName = "Elena",
                LastName = "Kushnirenko",
                About = "Elena Kushnirenko is an international judge and trainer." +
                "She is a master with over 10 years of experience in the field of manicure. She created programs for basic and upgrading courses. " +
                "Elena is an international judge and multiple winner of International Nail Art Competitions."

            };

            ThirdTrainer = new Trainer
            {
                Id = 3,
                FirstName = "Evgeniya",
                LastName = "Makarenko",
                About = "Evgeniya Makarenko is an manicure and pedicure trainer" +
                "is a trainer with over 11 years of experience, certified in Ukraine. Evgeniya conducts courses in classic manicure," +
                " classic pedicure and nail art with gel."
            };

        }

        private void SeedCourseTypes()
        {
            FirstType = new CourseType()
            {
                Id = 1,
                Name = "Begginner"

            };

            SecondType = new CourseType()
            {
                Id = 2,
                Name = "Аdvanced"
            };

        }

        private void SeedCourses()
        {
            BasicManicureCourse = new Course()
            {
                Id = 1,
                Name = "Basic Manicure Course",
                Details = "The course is for:\r\n- for beginners\r\n- for manicurists to enrich their knowledge.\r\nIt consists of a theoretical and a practical part.\r\nIt includes all the basic knowledge that any future manicurist needs.",
                Program = "-Тheory\r\n- How to properly remove gel polish with cleaner and keep your clients nails healthy." +
                "\r\n-Treatment of the cuticle and cuticles with a suitable preparation." +
                "\r\n- How to choose and work with pliers and scissors." +
                "\r\n- How to make reinforcement with a base.\r\n- How to apply gel polish close to the cuticle." +
                "\r\nOur trainers will teach you how to keep a healthy and beautiful manicure.",
                Duration = "40 часа",
                StartDate = DateTime.Parse("2016.05.02"),
                EndDate = DateTime.Parse("07.05.2024"),
                Price = 450.00m,
                TrainerId = ThirdTrainer.Id,
                CourseTypeId = FirstType.Id,
            };
        }

        private void SeedSaloons()
        {
            Sallon1 = new Saloon()
            {
                Id = 1,
                Address = "Pazardzhik, bul. \"Bulgariya\" 2",
                PhoneNumber = "0888 222 555",
                ClientId = Client1.Id,
            };

            Sallon2 = new Saloon()
            {
                Id = 2,
                Address = "Sofia, pl. \"Sveta Nedelya\" 5",
                PhoneNumber = "0888 222 555",
                ClientId = StudentUser1.Id,
            }; 
        }

    }
}
