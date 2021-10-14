using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SistemaBuscador.Controllers;
using SistemaBuscador.Models;
using SistemaBuscador.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBuscadorTest.PruebasUnitarias.Controladores
{
    [TestClass]
    public class UsuarioControllerTest
    {
        [TestMethod]
        public async Task NuevoUsuario_modelo_invalido()
        {
            //Preparacion
            var UsuarioService = new Mock <IUsarioRepository>

                //Ejecucion


                //Validacion
            }
    }
}
