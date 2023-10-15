using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Social_Media_API.Models.UserModels;

namespace Social_Media_API.Services.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username); //> checks if unique
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO); //> returns response
        Task<User> Register(RegisterRequestDTO registerRequestDTO); //? returns user FOR NOW
        //? since it's repository , not endpoint
    }
}