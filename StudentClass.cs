using System;
namespace XMLparser
{
    class StudentClass
    {       
        public string Name;
        public string School;
        public string Department;
        public int Year;
        public string Address;
        public DateTime DateJoined;
        public StudentClass(StudentClass student)
        {
            Name = student.Name;
            School = student.School;
            Department = student.Department;
            Year = student.Year;
            DateJoined = student.DateJoined;
            Address = student.Address;
           }
        public StudentClass() { }
        public StudentClass(string name, int year, string school, string department, string address, DateTime dateJoined)
        {
            School = school;
            Name = name;
            Year = year;
            Department = department;
            Address = address;
            DateJoined = dateJoined;
        }
    }
}
