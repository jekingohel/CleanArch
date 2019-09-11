using CleanArch.Domain.Entities;
using System.Collections.Generic;

namespace CleanArche.Application.ViewModels
{
    public class CourseViewModel
    {
        public long CourseId { get;  set; }
        public string Name { get; set; }
        public string Description { get;  set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}