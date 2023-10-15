using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Social_Media_API.Data;
using Social_Media_API.Models.UserModels;
using Social_Media_API.Services.Repository.IRepository;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;



namespace Social_Media_API.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        // private readonly IConfiguration _configuration; //i added , not needed
        private string secretKey;

        public UserRepository(AppDbContext db, IMapper mapper, IConfiguration configuration)
        {
            _db = db;
            _mapper = mapper;
            // _configuration = configuration; //i added not ,needed
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
        }

        public bool IsUniqueUser(string username)
        {
            User user = _db.Users.FirstOrDefault(u => u.Username == username);
            return user == null;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            //check if user exist
            User user = await _db.Users.FirstOrDefaultAsync(u => u.Username == loginRequestDTO.Username && u.Password == loginRequestDTO.Password);

            if (user == null)
            {
                return new LoginResponseDTO
                {
                    Token = "",
                    User = null
                };
            }

            //! JWT TOKEN
            //if user was found general token
            var tokenhandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(secretKey);//convert key to bytes to use with handler

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Name,user.Id.ToString()), //built in claim types can have custom type
                    new Claim(ClaimTypes.Role,user.Role),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };// define properties

            var token = tokenhandler.CreateToken(tokenDescriptor); //creates token

            //return type
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO
            {
                Token = tokenhandler.WriteToken(token), //generates serialized token that we can use
                User = user
            };

            return loginResponseDTO;
        }

        public async Task<User> Register(RegisterRequestDTO registerRequestDTO)
        {
            User addUser = _mapper.Map<User>(registerRequestDTO);


            await _db.Users.AddAsync(addUser);
            await _db.SaveChangesAsync();

            addUser.Password = ""; //remove password before returning 
            return addUser;
        }
    }
}