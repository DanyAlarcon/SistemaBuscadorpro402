using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Repositories
{
    public class LoginRepositoryEF : ILoginRepository
    {
        public void SetSessionAndCookie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExist(string usuario, string password)
        {
            var resultado = false;

            //logica que ocupa EF

            return Task.FromResult(resultado);
        }

        public Task<bool> UserExixts(string usuario, string password)
        {
            throw new NotImplementedException();
        }
    }
}
