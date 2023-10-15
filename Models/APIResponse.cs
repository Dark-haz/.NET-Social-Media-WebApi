using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Social_Media_API.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSucess { get; set; } = true ; //if everything successful , true by default
        public List<String> ErrorMessages { get; set; }//if not sucess , error messages
        public object Result { get; set; } //returned data 

    }
}

