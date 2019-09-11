using CleanArch.Domain.Entities;
using System.Collections.Generic;

namespace CleanArche.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}