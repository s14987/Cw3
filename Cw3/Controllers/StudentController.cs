using System;
using Cw3.DAL;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Usuwanie zakończone");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            return Ok("Aktualizacja zakończona");
        }
    }
}