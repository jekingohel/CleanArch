using CleanArche.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArche.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();

        void Add(CourseViewModel model);
    }
}