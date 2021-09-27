using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area
{
    public class Operaciones
    {
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public double r { get; set; }
        public decimal cuadrado()
        {
            return num1 * num1;
        }
        public decimal triangulo()
        {
            return (num1 * num2) / 2;
        }
        public double circulo()
        {
            return (r * r) * 3.1416;

        }
    }
}