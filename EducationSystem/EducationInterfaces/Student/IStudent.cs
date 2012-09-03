using System;

namespace EducationInterfaces
{
    public interface IStudent
    {
        int StudentId { get; set; }
        DateTime DateOfBirth { get; set; }
        string DepartmentCode { get; set; }
        string Faculty { get; set; }
        string FastName { get; set; }
        string Gender { get; set; }
        DateTime GraduationYear { get; set; }
        string LastName { get; set; }
        string MatricNumber { get; set; }
        string MiddleName { get; set; }
        string Nationality { get; set; }
        DateTime YearAdmitted { get; set; }
    }
}
