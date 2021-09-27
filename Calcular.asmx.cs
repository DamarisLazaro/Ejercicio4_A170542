using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Area
{
    /// <summary>
    /// Descripción breve de Calcular
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcular : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal cuadrado(decimal num1)
        {
            Operaciones o = new Operaciones();
            o.num1 = num1;
            return o.cuadrado();
        }
        [WebMethod]
        public decimal triangulo(decimal num1, decimal num2)
        {
            Operaciones o = new Operaciones();
            o.num1 = num1;
            o.num2 = num2;
            return o.triangulo();
        }
        [WebMethod]
        public double circulo(double r)
        {
            Operaciones o = new Operaciones();
            o.r = r;
            return o.circulo();
        }
    }
}
