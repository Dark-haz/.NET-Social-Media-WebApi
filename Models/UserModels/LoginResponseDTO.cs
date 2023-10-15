using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Media_API.Models.UserModels
{
    public class LoginResponseDTO
    {
        //ON LOGIN :
        //  1- Generate token
        //  2- Send back User details + Token --> validates user authentic identity

        public User User { get; set; } //web app has details of current logged in user
        public String Token { get; set; } //authenticates logged in user
    }
}