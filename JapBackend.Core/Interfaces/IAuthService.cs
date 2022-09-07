using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Requests.Auth;

namespace JapBackend.Core.Interfaces
{
    public interface IAuthService
    {
        Task<dynamic> Login(LoginRequest req);
    }
}