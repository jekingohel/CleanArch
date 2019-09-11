using CleanArche.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArche.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}