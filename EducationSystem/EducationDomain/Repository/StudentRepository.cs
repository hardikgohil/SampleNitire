using System;
using System.Collections.Generic;
using System.Linq;
using EducationInterfaces;
using EducationResources.EducationSystem;
using EducationResources.Model;

namespace EducationDomain.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public EducationlSystemDataContext Db = new EducationlSystemDataContext();


        public List<IStudent> GetAllStudents()
        {
            var list = new List<IStudent>(); 
            var dblist = (Queryable.Select(Db.StudentDBs, p => p)).ToList<StudentDB>();
            foreach (var li in dblist)
            {
                var student = MaptoIStudent(li);
                list.Add(student);
            }


            return  list;
        }

        public IStudent GetStudentById(int id)
        {
            var dbstudent = Db.StudentDBs.SingleOrDefault(s => s.studentId == id);
            var student = MaptoIStudent(dbstudent);
            return student;
        }

        public Boolean AddNewStudent(IStudent student)
        {
            var newstudent = new StudentDB
            {
                MatricNumber = student.MatricNumber,
                DateOfBirth = student.DateOfBirth,
                DepartmentCode = student.DepartmentCode,
                Faculty = student.Faculty,
                FirstName = student.FastName,
                Gender = Convert.ToChar(student.Gender),
                GraduationYear = student.GraduationYear,
                LastName = student.LastName,
                MiddleName = student.MiddleName,
                Nationality = student.Nationality,
                YearAdmitted = student.YearAdmitted
            };

          Db.StudentDBs.InsertOnSubmit(newstudent);
          Db.SubmitChanges();

            return true;
        }

        public Boolean EditStudent(IStudent student)
        {
            var newstudent = Db.StudentDBs.SingleOrDefault(s => s.studentId == student.StudentId); ;  

            newstudent.MatricNumber = student.MatricNumber;
            newstudent.DateOfBirth = student.DateOfBirth;
            newstudent.DepartmentCode = student.DepartmentCode;
            newstudent.Faculty = student.Faculty;
            newstudent.FirstName = student.FastName;
            newstudent.Gender = Convert.ToChar(student.Gender);
            newstudent.GraduationYear = student.GraduationYear;
            newstudent.LastName = student.LastName;
            newstudent.MiddleName = student.MiddleName;
            newstudent.Nationality = student.Nationality;
            newstudent.YearAdmitted = student.YearAdmitted;      
            
            Db.SubmitChanges();

            return true;
        }

        public Boolean DeleteStudent(int id)
        {
            var student = Db.StudentDBs.SingleOrDefault(s => s.studentId == id);
            if (student != null) Db.StudentDBs.DeleteOnSubmit(student);
            Db.SubmitChanges();
            return true;   
        }

        public IStudent MaptoIStudent(StudentDB student)
        {
            var newstudent = new Student
            {
                StudentId = student.studentId,
                MatricNumber = student.MatricNumber,
                DateOfBirth = DateTime.Parse(student.DateOfBirth.ToString()),
                DepartmentCode = student.DepartmentCode,
                Faculty = student.Faculty,
                FastName = student.FirstName,
                Gender = Convert.ToChar(student.Gender).ToString(),
                GraduationYear = student.GraduationYear,
                LastName = student.LastName,
                MiddleName = student.MiddleName,
                Nationality = student.Nationality,
                YearAdmitted = student.YearAdmitted
            };

            return newstudent;
        }

    }
}
