using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace RefactorizarCodigo.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CalcularPrecioPizza_ConIngredientesVarios_DebeDevolverPrecioCorrecto()
        {
            // Arrange
            var input = new StringReader("7\n2\n1\n3"); // Simula la entrada del usuario
            Console.SetIn(input);

            // Act
            double precio = Program.CalcularPrecioPizza();

            // Assert
            Assert.AreEqual(10.8, precio, 0.01); // Usamos un margen de error para la comparación de valores decimales
        }

        [TestMethod]
        public void CalcularPrecioPizza_ConOpcionesInvalidas_DebeManejarErrores()
        {
            // Arrange
            var input = new StringReader("8\n4\n1\ninvalid\n2"); // Simula opciones inválidas
            Console.SetIn(input);

            // Act y Assert
            Assert.ThrowsException<Exception>(() => Program.CalcularPrecioPizza());
        }
    }
}
