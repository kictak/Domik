﻿namespace EditSample.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}