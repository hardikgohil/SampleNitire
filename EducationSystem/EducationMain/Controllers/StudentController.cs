using System.Web.Mvc;
using EducationDomain.Models;
using EducationInterfaces;
using EducationResources.EducationSystem;

namespace EducationMain.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentViewFactory _studentViewFactory;
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentViewFactory studentViewFactory, IStudentRepository studentRepositoryRepository)
        {
            _studentViewFactory = studentViewFactory;
            _studentRepository = studentRepositoryRepository;
        }

        public ActionResult Index(int pageNumber = 1)
        {
            //var model = _studentViewFactory.BuildModel(pageNumber);
            var model = _studentRepository.GetAllStudents();
            var students = new StudentView();
            students.StudentCollection = model;
            return View(students);
        }

        public ActionResult StudentEntry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentEntry(Student model)
        {
            if (ModelState.IsValid)
            {
                var result = _studentRepository.AddNewStudent(model);

                if (result)
                    return RedirectToAction("Index", 1);
            }
            return View(model);
        }


        public ActionResult DeleteStudent(int id)
        {
            var result = _studentRepository.DeleteStudent(id);
            return RedirectToAction("Index");
        }


        public ActionResult EditStudent(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return View((Student)student);
        }

        [HttpPost]
        public ActionResult EditStudent(Student model)
        {

            if (ModelState.IsValid)
            {
                var result = _studentRepository.EditStudent(model);

                if (result)
                    return RedirectToAction("Index", 1);
            }
            return View(model);
        }

    }
}
