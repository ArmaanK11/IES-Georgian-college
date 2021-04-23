﻿using JWTAuthentication_TokenBarer.Models;
using JWTAuthentication_TokenBarer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student model)
        {
            var students = _authenticateService.Authenticate(model.UserName, model.Password);
            if (students == null)
            {
                return BadRequest(new { Message = "invalid username or password" });
            }
            else
                return Ok(students);
        }
    }
}