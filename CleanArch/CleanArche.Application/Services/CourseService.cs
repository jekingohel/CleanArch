﻿using CleanArch.Domain.Interfaces;
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

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
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
