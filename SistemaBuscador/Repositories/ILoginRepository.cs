using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Repositories
{
    public interface ILoginRepository
    {
        Task<bool> UserExixts(string usuario, string password);
        Task<bool> UserExist(string usuario, string password);

        void SetSessionAndCookie(HttpContext context);
    }
}
