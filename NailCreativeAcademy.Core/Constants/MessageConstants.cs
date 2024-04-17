namespace NailCreativeAcademy.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "Полето '{0}' е задължително.";
        public const string LengthStringRequired = "Полето '{0}' трябва да е най-малко {2} и не повече от {1} символа.";
        public const string TrainerNotExits = "Посоченият обучител не съществува. Моля първо го добавете!";
        public const string CourseExists = "Курс с име {0} същестува";
        public const string CourseNotExist = "Курсът {0} не съществува!";
        public const string CourseHasEnrolledStudent = "Не може да изтриете курса - има записан/и студент/и!";
        public const string TrinerNameExists = "Обучител с посоченото име вече съществува!";
        public const string SaloonAddresExists = "Салон с такъв адрес съществува!";
		public const string SaloonPhoneNumberExists = "Салон с такъв адрес съществува!";
        public const string HasEnrolledStudentinTrainerCourse = "В курсът {0} има саписан студент. Не можете да премахнете обучителя!";
        public const string UserAddMessageSuccess = "UserAddMessageSuccess";
        public const string UserAddMessageError = "UserAddMessageError";
    }
}
