using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Tests.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributeTest
    {
        [TestMethod]
        public void PrimeraLetraMinuscula_DevuelveError()
        {
            // Preparaci�n (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n (Assert)
            Assert.AreEqual("La primera letra debe ser may�scula", resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            // Preparaci�n (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n (Assert)
            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void PrimeraLetraMayuscula_NoDevuelveError()
        {
            // Preparaci�n (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "Felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n (Assert)
            Assert.IsNull(resultado);
        }
    }
}