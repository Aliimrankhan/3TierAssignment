using BAL.Services.Contract;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LayeredArchitecture.Pages
{
    public class StudentsModel : PageModel
    {
        private readonly ILogger<StudentsModel> _logger;
        private readonly IStudentService _studentService;
        public List<Student> listEmployees =new List<Student>();
        public StudentsModel(ILogger<StudentsModel> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        public async void OnGet()
        {
            listEmployees = await _studentService.GetAllStudents();
            
        }
    }
}