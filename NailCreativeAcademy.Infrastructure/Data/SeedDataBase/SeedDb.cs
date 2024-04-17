namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.AspNetCore.Identity;
    using Models;
    using System.Security.Claims;
    using static Constants.ClaimConstants;

    public class SeedDb
    {
        public ApplicationUser AdminUser { get; set; }
        public IdentityUserClaim<string> AdminUserClaim { get; set; }
        public ApplicationUser StudentUser1 { get; set; }
        public IdentityUserClaim<string> StudentUser1Claim { get; set; }
        public ApplicationUser StudentUser2 { get; set; }
        public IdentityUserClaim<string> StudentUser2Claim { get; set; }
        public ApplicationUser Client1 { get; set; }
        public IdentityUserClaim<string> Client1Claim { get; set; }
        public Trainer FirstTrainer { get; set; }
        public Trainer SecondTrainer { get; set; }
        public Trainer ThirdTrainer { get; set; }  
        public CourseType FirstType { get; set; }
        public CourseType SecondType { get; set; }
        public Saloon Saloon1 { get; set; }
        public Saloon Saloon2 { get; set; }

        public SeedDb()
        {
            SeedUsers();
            SeedTrainers();
            SeedCourseTypes();
            SeedSaloons();
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser()
            {
                Id = "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                UserName = "t_nikolova1985@abv.bg",
                NormalizedUserName = "T_NIKOLOVA1985@ABV.BG",
                Email = "t_nikolova1985@abv.bg",
                NormalizedEmail = "T_NIKOLOVA1985@ABV.BG",
                FirstName = "Таня",
                LastName="Николова"
            };
            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Таня Николова",
                UserId= "b8b63dd7e8f14a01b3d4ef4bb901b2e4"
            };

            AdminUser.PasswordHash =
                hasher.HashPassword(AdminUser, "tn123456");

            StudentUser1 = new ApplicationUser()
            {
                Id = "68a865ce-5b33-4275-a460-dc00683172d2",
                UserName = "student1@abv.bg",
                NormalizedUserName = "STUDENT1@ABV.BG",
                Email = "student1@abv.bg",
                NormalizedEmail = "STUDENT1@ABV.BG",
                FirstName = "Атанас",
                LastName = "Атанасов"
            };
            StudentUser1Claim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Атанас Атанасов",
                UserId = "68a865ce-5b33-4275-a460-dc00683172d2"
            };
              StudentUser1.PasswordHash =
                    hasher.HashPassword(StudentUser1, "st1123456");

            StudentUser2 = new ApplicationUser()
            {
                Id = "714e73f4716d4cf9946d494ed0d72cf7",
                UserName = "student2@abv.bg",
                NormalizedUserName = "STUDENT2@ABV.BG",
                Email = "student2@abv.bg",
                NormalizedEmail = "STUDENT2@ABV.BG",
                FirstName = "Николай",
                LastName = "Николов"
            };

            StudentUser2Claim = new IdentityUserClaim<string>()
            {
                Id = 3,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Николай Николов",
                UserId = "714e73f4716d4cf9946d494ed0d72cf7"
            };

            StudentUser2.PasswordHash =
                  hasher.HashPassword(StudentUser2, "st2654321");

            Client1 = new ApplicationUser()
            {
                Id = "cf756f58ca9146f2889a54a32cde2dfc",
                UserName = "client1@abv.bg",
                NormalizedUserName = "CLIENT1@ABV.BG",
                Email = "client1@abv.bg",
                NormalizedEmail = "CLIENT1@ABV.BG",
                FirstName = "Иван",
                LastName = "Иванов"
            };

            Client1Claim = new IdentityUserClaim<string>()
            {
                Id = 4,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Иван Иванов",
                UserId = "cf756f58ca9146f2889a54a32cde2dfc"
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
            Saloon1 = new Saloon()
            {
                Id = 1,
                Name = "Nail Creative",
                Address = "Пазарджик, бул. \"България\" 2",
                PhoneNumber = "+359888222555",
                ClientId = Client1.Id,
            };

            Saloon2 = new Saloon()
            {
                Id = 2,
                Name ="Nail Creative-S",
                Address = "София, пл. \"Света Неделя\" 5",
                PhoneNumber = "+359888333555",
                ClientId = StudentUser1.Id,
            }; 
        }

    }
}
