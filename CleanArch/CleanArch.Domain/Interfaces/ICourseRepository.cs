using CleanArch.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();

        Task<bool> AddAsync(Course course);
    }
}
