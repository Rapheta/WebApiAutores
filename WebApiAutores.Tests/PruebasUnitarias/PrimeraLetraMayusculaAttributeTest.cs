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
            // Preparación (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecución (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificación (Assert)
            Assert.AreEqual("La primera letra debe ser mayúscula", resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            // Preparación (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecución (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificación (Assert)
            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void PrimeraLetraMayuscula_NoDevuelveError()
        {
            // Preparación (Arrange)
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "Felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecución (Action)
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificación (Assert)
            Assert.IsNull(resultado);
        }
    }
}