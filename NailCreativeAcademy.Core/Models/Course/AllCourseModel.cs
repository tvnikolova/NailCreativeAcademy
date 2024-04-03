namespace NailCreativeAcademy.Core.Models.Course
{
    public class AllCourseModel
    {
        public string Name { get; set; } = string.Empty;

        public string StartDate { get; set; } = string.Empty;

        public string Duration {  get; set; } = string.Empty;

        public string Trainer {  get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
