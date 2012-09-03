using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationInterfaces
{
    public interface IStudentViewFactory
    {
        IStudentView BuildModel(int pageNumber);
          
           
    }
}
