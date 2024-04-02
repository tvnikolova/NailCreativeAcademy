namespace NailCreativeAcademy.Core.Models.Course
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
