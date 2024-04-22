namespace NailCreativeAcademy.Infrastructure.Constants
{
    public static class NailCreativeConstants
	{

		public const string DateOProjectString = "dd/MM/yyyy HH:mm";
        public const int PhoneNumberLength = 15;
        public const int PhoneNumberMinLength = 13;
        //Trainer constants

        public const int TrainerDescriptionMinLength = 20;
		public const int TrainerDescriptionMaxLength = 500;

        public const int TrainerNameMinLength = 5;
        public const int TrainerNameMaxMinLength = 30;
       

        //Course constants
        public const int CourseNameMinLength = 10;
		public const int CourseNameMaxLength = 30;

		public const int CourseDetailsMinLength = 20;
		public const int CourseDetailsMaxLength = 300;

        public const int CourseProgramMinLength = 20;
        public const int CourseProgramMaxLength = 700;

        public const int CourseMinDuration = 5;
		public const int CourseMaxDuration = 15;

        public const string CoursePriceMin = "0";
        public const string CoursePriceMax = "2500";


        //Course type constants

        public const int CourseTypeNameMinLength = 5;
        public const int CourseTypeNameMaxLength = 10;

		//Saloon constants

		public const int SaloonAddressMinLength = 10;
		public const int SaloonAddressMaxLength = 40;

        public const int SaloonNameMinLength = 2;
        public const int SaloonNameMaxLength = 30;

        //FeedBack

        public const int FeedbackCommentMinLength = 5;
        public const int FeedbackCommentMaxLength = 500;

        //ApplicationUser

        public const int UserFirstNameMinLength = 2;
        public const int UserFirstNameMaxLength = 15;

        public const int UserLastNameMinLength = 2;
        public const int UserLastNameMaxLength = 15;

    }
}
