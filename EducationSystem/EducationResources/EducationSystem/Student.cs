using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EducationInterfaces;

namespace EducationResources.EducationSystem
{
    public class Student : IStudent
    {
        public int StudentId { get; set; }
        public string  MatricNumber { get; set; }
        public string LastName { get; set; }
        public string FastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Faculty { get; set; }
        public string DepartmentCode { get; set; }
        public DateTime YearAdmitted { get; set; }
        public DateTime GraduationYear { get; set; }
    }


}
