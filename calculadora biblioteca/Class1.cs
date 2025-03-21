﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  calculadora_biblioteca 
{
    public class Calculadoratec 
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }

        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double restar(double uno, double dos)
        {
            return uno-dos;
        }
        public static double dividir(double uno, double dos)
        {
            return uno/dos;
        }
        public static double raizCuadrada(double numero)
        {
            if (numero < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            return Math.Sqrt(numero);
        }

        public static double potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        public static double porcentaje(double total, double porcentaje)
        {
            return (total * porcentaje) / 100;
        }

        public static double fraccion(double numerador, double denominador)
        {
            if (denominador == 0)
                throw new DivideByZeroException("El denominador no puede ser cero.");
            return numerador / denominador;
        }
        // operacion rafa

    }
}  
