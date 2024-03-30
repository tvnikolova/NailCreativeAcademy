﻿namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
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
        public Saloon Sallon1 { get; set; }
        public Saloon Sallon2 { get; set; }

        public SeedDb()
        {
            SeedUsers();
            SeedTrainers();
            SeedCourseTypes();
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
                Name = "Екатерина Николова",
                About = "Екатерина Николова е обучител в академията от 3 години. Тя е със 7 години опит в областта на маникюра. " +
                "Има няколко първи места от спечелени международни конкурси за маникюр "
            };

            SecondTrainer = new Trainer
            {
                Id = 2,
                Name = "Елена Кушниренко",
                About = "Елена Кушниренко е международен съдия и обучител. Тя е майстор с над 10 години опит в областта на маникюра. " +
                "Създала е програми за основни и надграждащи курсове. " +
                "Елена е международен съдия и многократен победител в международни конкурси за ноктопластика."

            };

            ThirdTrainer = new Trainer
            {
                Id = 3,
                Name = "Диана Александровна",
                About = "Диана Александровна е обучител по маникюр и педикюр. Тя е с над 11 години опит и е сертифицирана в Украйна. " +
                "Диана провежда курсове по класически маникюр, класически педикюр и ноктопластика с гел."
            };
        }

        private void SeedCourseTypes()
        {
            FirstType = new CourseType()
            {
                Id = 1,
                Name = "Начинаещи"

            };

            SecondType = new CourseType()
            {
                Id = 2,
                Name = "Напреднали"
            };

        }

        private void SeedSaloons()
        {
            Sallon1 = new Saloon()
            {
                Id = 1,
                Address = "Пазарджик, бул. \"България\" 2",
                PhoneNumber = "0888 222 555",
                ClientId = Client1.Id,
            };

            Sallon2 = new Saloon()
            {
                Id = 2,
                Address = "София, пл. \"Света Неделя\" 5",
                PhoneNumber = "0888 222 555",
                ClientId = StudentUser1.Id,
            }; 
        }

    }
}
