using EducationInterfaces;
using EducationDomain.Models;

namespace EducationDomain.Factory
{
    public class StudentViewFactory : IStudentViewFactory
    {
        private readonly IStudentService _studentService;

        public StudentViewFactory(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        
        public IStudentView BuildModel(int pageNumber)
        {

            var studentCollection = _studentService.GetStudentCollection();
            var model = new StudentView

            {
                StudentCollection = studentCollection
            };


            return model;
        }
    }
}
