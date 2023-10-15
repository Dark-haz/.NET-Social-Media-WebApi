using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Social_Media_API.Models;
using Social_Media_API.Models.UserModels;
using Social_Media_API.Services.Repository.IRepository;

namespace Social_Media_API.Controllers
{
    [ApiController]
    [Route("api/UserAuth")]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        protected APIResponse _response;
        public UserAPIController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _response = new();

        }

        //> POST LOGIN
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {

            var LoginResponse = await _userRepository.Login(loginRequestDTO);

            if (LoginResponse.User == null || string.IsNullOrEmpty(LoginResponse.Token))
            {
                _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _response.IsSucess = false;
                _response.ErrorMessages.Add("Username or Password is incorrect");
                return BadRequest(_response);
            }

            _response.StatusCode = System.Net.HttpStatusCode.OK;
            _response.Result = LoginResponse;
            return Ok(_response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            bool IsUniqueUser = _userRepository.IsUniqueUser(registerRequestDTO.Username);
            if (!IsUniqueUser)
            {
                _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _response.IsSucess = false;
                _response.ErrorMessages.Add("Username already exists");
                return BadRequest(_response);
            }

            var registeredUser = await _userRepository.Register(registerRequestDTO);
            if (registeredUser == null)
            {
                _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _response.IsSucess = false;
                _response.ErrorMessages.Add("Error while registering");
                return BadRequest(_response);
            }

            _response.StatusCode = System.Net.HttpStatusCode.OK; //! registered user NOT RETURNED
            return Ok(_response);
        }
    }
}