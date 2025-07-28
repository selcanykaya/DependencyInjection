using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacher _teacher; 

        public TeachersController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        //api/teachers/info
        [HttpGet("info")]
        public string GetTeacherInfo()
        {

            // Öğretmenin bilgilerini döndüren metot
            _teacher.FirstName = "Lisa";
            _teacher.LastName = "Jennie";
            return _teacher.GetInfo();
        }
    }
}
