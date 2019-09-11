using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Entities
{
    public class Course
    {
        public Course(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public long CourseId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private  set; }
    }
}