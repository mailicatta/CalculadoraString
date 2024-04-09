﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraString
{
    public class Calculadora
    {
        public int Sumar(string numeros) 
        {
            if (string.IsNullOrEmpty(numeros)) return 0;

            string[] numerosSeparados = numeros.Split(',');
            int suma = 0;
            foreach (string numero in numerosSeparados)
            {
                suma += int.Parse(numero);
            }
            return suma;
        } 
    }
}
