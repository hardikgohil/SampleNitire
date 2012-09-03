using System;
using System.Collections.Generic;

namespace EducationInterfaces
{
    public interface IStudentRepository
    {
        Boolean AddNewStudent(IStudent student);
        List<IStudent> GetAllStudents();
        IStudent GetStudentById(int id);
        Boolean EditStudent(IStudent student);
        Boolean DeleteStudent(int id);
    }
}
