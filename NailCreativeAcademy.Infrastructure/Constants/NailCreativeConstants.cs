namespace NailCreativeAcademy.Infrastructure.Constants
{
    public static class NailCreativeConstants
	{

		public const string DateOProjectString = "dd.MM.yyyy";
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 20;

        public const int LastNameMinLength = 5;
        public const int LastNameMaxLength = 20;

		public const int PhoneNumberLength = 15;

        //Lecturer constants

		public const int TrainerDescriptionMinLength = 20;
		public const int TrainerDescriptionMaxLength = 200;

		public const string TrainerDateOfGraduation = "mm/yyyy";
		//Course constants
		public const int CourseNameMinLength = 10;
		public const int CourseNameMaxLength = 30;

		public const int CourseDescriptionMinLength = 20;
		public const int CourseDescriptionMaxLength = 100;

		public const int CourseMinDuration = 15;
		public const int CourseMaxDuration = 90;
		public const int CoursePaymentInformationMinLength = 20;
        public const int CoursePaymentInformationMaxLength = 300;

        //Course type constants

        public const int CourseTypeNameMinLength = 5;
        public const int CourseTypeNameMaxLength = 10;

		//Saloon constants

		public const int SaloonAddressMinLength = 10;
		public const int SaloonAddressMaxLength = 40;

		//Review

		public const int FeedbackCommentMinLength = 5;
        public const int FeedbackCommentMaxLength = 500;

    }
}
