﻿namespace CalculoIMC
{
    public static class Calculos
    {
        public static double CalcularIMC(double peso_kg, double altura_cm)
        {
            return peso_kg / (altura_cm * altura_cm);
        }

        public static string ClassificarIMC(double IMC)
        {
            var Classificacao = "";

            if (IMC < 18.5)
            {
                Classificacao = "Abaixo do peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Classificacao = "Peso Normal";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Classificacao = "Sobrepeso";
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                Classificacao = "Obesidade Grau I";
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                Classificacao = "Obesidade Grau II";
            }
            else
            {
                Classificacao = "Obesidade Grau III";
            }

            return Classificacao;
        }
    }
}