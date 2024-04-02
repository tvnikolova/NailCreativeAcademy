using NailCreativeAcademy.Core.Models.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailCreativeAcademy.Core.Contracts.Course
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
    }
}
