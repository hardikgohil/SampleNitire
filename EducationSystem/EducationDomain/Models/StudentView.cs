using System.Collections.Generic;
using System.Linq;
using EducationInterfaces;


namespace EducationDomain.Models
{
    public class StudentView : IStudentView
    {

        public StudentView() 
        {
            StudentCollection = new List<IStudent>();
        }

        public IList<IStudent> StudentCollection { get; set; }
       
        public int TotalNumberOfFemales()
        {
            return StudentCollection.Count(x => x.Gender== "F");
        }

        public int TotalNumberOfMales()
        {
            return StudentCollection.Count(x => x.Gender == "M");
        }
    }
}
