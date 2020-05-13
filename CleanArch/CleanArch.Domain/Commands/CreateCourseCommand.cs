﻿namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string desc, string imagePath)
        {
            Name = name;
            Description = desc;
            ImageUrl = imagePath;
        }
    }
}
