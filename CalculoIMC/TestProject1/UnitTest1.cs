using CalculoIMC;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange
            double peso_kg = 79.0;
            double altura_cm = 1.72;
            string total = "26,7";

            //Act 
            var resultado = Calculos.CalcularIMC(peso_kg, altura_cm).ToString("#.#");

            //Assert
            Assert.Equal(total, resultado);
        }

        [Fact]
        public void ClassificarIMC()
        {
            //Arrange
            double IMC = 26.7;
            string result = "Sobrepeso";

            //Act
            var resultado = Calculos.ClassificarIMC(IMC);

            //Assert
            Assert.Equal(result, resultado);
        }
    }
}