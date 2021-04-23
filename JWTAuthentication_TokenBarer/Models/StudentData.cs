using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Models
{
    public class StudentData
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Marks { get; set; }
    }
}
