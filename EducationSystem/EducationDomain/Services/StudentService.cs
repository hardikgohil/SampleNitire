using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EducationInterfaces;
using EducationResources.EducationSystem;

namespace EducationDomain.Services
{
    public class StudentService : IStudentService
    {

        public IList<IStudent> GetStudentCollection()
        {
            var fakeData1 = new Student { DateOfBirth = DateTime.Now, FastName = "Olu", Gender = "F", LastName = "Gbile", Faculty = "science" };
            var fakeData2 = new Student { DateOfBirth = DateTime.Now, FastName = "shola", Gender = "F", LastName = "zombie", Faculty = "science" };
            var fakeData3 = new Student { DateOfBirth = DateTime.Now, FastName = "ade", Gender = "M", LastName = "Gbile", Faculty = "science" };
            var fakeData4 = new Student { DateOfBirth = DateTime.Now, FastName = "seun", Gender = "F", LastName = "adebayo", Faculty = "science" };
            var fakeData5 = new Student { DateOfBirth = DateTime.Now, FastName = "iyabo", Gender = "F", LastName = "oguunyode", Faculty = "science" };
            var fakeData6 = new Student { DateOfBirth = DateTime.Now, FastName = "folake", Gender = "F", LastName = "Gbile", Faculty = "science" };
            var fakeData7 = new Student { DateOfBirth = DateTime.Now, FastName = "semiu", Gender = "M", LastName = "kadiri", Faculty = "science" };
            var fakeData8 = new Student { DateOfBirth = DateTime.Now, FastName = "kayode", Gender = "M", LastName = "odeggami", Faculty = "science" };
            var fakeData9 = new Student { DateOfBirth = DateTime.Now, FastName = "oladapo", Gender = "M", LastName = "gbesko", Faculty = "science" };
            var studentCollection = new List<IStudent> { fakeData1, fakeData2, fakeData3, fakeData4, fakeData5, fakeData6, fakeData7, fakeData8, fakeData9 };
            return studentCollection;
        }
    }
}
