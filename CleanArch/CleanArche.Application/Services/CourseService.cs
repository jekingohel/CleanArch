using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArche.Application.Interfaces;
using CleanArche.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArche.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        private readonly IMediatorHandler _bus;
        public CourseService(ICourseRepository courseRepository, 
            IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Add(CourseViewModel model)
        {
            var creatCourseCommand = new CreateCourseCommand(model.Name,model.Description,model.ImageUrl);
            _bus.SenCommand(creatCourseCommand);
            
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}