using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationInterfaces
{
    public interface IStudentView
    {
        IList<IStudent> StudentCollection { get; set; }
        int TotalNumberOfFemales();
        int TotalNumberOfMales();

    }
}
