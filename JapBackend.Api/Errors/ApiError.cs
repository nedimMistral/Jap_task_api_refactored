using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace JapBackend.Api.Errors
{
    public class ApiError
    {
         public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }

        public string Message { get; private set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public ApiError(int statusCode, string statusDescription)
        {
            StatusCode = statusCode;
            StatusDescription = statusDescription;
        }

        public ApiError(int statusCode, string statusDescription, string message)
            : this(statusCode, statusDescription)
        {
            Message = message;
        }
    }
}