using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JapBackend.Api.Errors
{
    public class InternalServerError : ApiError
    {
      public InternalServerError()
            : base (500, HttpStatusCode.InternalServerError.ToString())
        {
        }


        public InternalServerError(string message)
            : base(500, HttpStatusCode.InternalServerError.ToString(), message)
        {
        }  
    }
}