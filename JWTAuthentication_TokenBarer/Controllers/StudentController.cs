using JWTAuthentication_TokenBarer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> logger;

        private readonly List<StudentData> std = new List<StudentData>()
        { 
    new StudentData { StudentID = 200468671, Name = "Armaan", LastName = "Kerosenewala",   Marks = 80 },
    new StudentData {StudentID = 200567812, Name = "Taniya", LastName = "Arora", Marks = 75},
    new StudentData {StudentID = 200578913, Name = "Belphy", LastName = "Baby", Marks = 85},
    new StudentData {StudentID = 200678765, Name = "Vinay", LastName = "Kamte", Marks = 70},
    new StudentData {StudentID = 200879876, Name = "Harsh", LastName = "Patel", Marks = 78},
    new StudentData {StudentID = 200987654, Name= "Yash", LastName = "Badwe", Marks = 60},
};
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<StudentData> Get()
        {
            return std;
        }
        [HttpGet("{id:int}")]
        public StudentData GetOne(int id)
        {
            return std.SingleOrDefault(x => x.StudentID == id);
        }
    }
}
