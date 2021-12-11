using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoIncediosUME_JorgePrieto.Clases;
using System;

namespace PruebasDelProyecto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MetodoDePruebaObtenerProvincia()
        {
            ClaseConsultas consulta = new ClaseConsultas();
           
            string resultado = consulta.buscarNombreProvincia(1);
            Assert.AreEqual("Albacete", resultado);
        }

        [TestMethod]
        public void MetodoDePruebaCompruebaLogin()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            Boolean [] resultado = consulta.consultaUsuarioLogin("jorge@hotmail.com", "1234");
            Assert.AreEqual(true, resultado[0]);
            Assert.AreEqual(true, resultado[1]);
            Assert.AreEqual(true, resultado[2]);
        }

        [TestMethod]
        public void MetodoDePrubaCompruebaNombreUsuario()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            String resultado = consulta.consultarNombreUsuario("jorge@hotmail.com");
            Assert.AreEqual("jorge", resultado);
            
        }

        [TestMethod]
        public void MetodoDePruebaCalculoDeProbabilidad()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            DateTime fecha = DateTime.Parse("1/10/2020");
            string resultado = consulta.consultaProbabilidad(1, fecha);
            Assert.AreEqual("Medio", resultado);
        }


        [TestMethod]
        public void MetodoConsultarIncendios()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            bool resultado = consulta.consultaIncendiosEnLocalidad(1);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void MetodoBuscarIdProvincia()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            int resultado = consulta.buscarIdProvincia("Albacete");
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void MetodoBuscarNombreLocalidadPrivincia()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            String[] resultado = consulta.buscarNombreLocalidadPrivincia(1);
            Assert.AreEqual("Alcalá del Júcar", resultado[0]);
            Assert.AreEqual("Albacete", resultado[1]);
        }

        [TestMethod]
        public void MetodoBuscarDatoConMismaFecha()
        {
            ClaseConsultas consulta = new ClaseConsultas();
            DateTime fechaInicio = DateTime.Parse("1/10/2010");
            DateTime fechaFin = DateTime.Parse("1/10/2022");
            bool resultado = consulta.buscarDatoConMismaFecha(1, fechaInicio, fechaFin);
            Assert.AreEqual(true, resultado);
        }
      

    }
}
