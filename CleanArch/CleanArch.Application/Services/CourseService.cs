using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            //_bus.SendCommand(new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl));
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel { Courses = _courseRepository.GetCourses() };
        }
    }
}
