using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationTapiceria.Models
{
    public class Venta
    {

            public string numero { get; set; }
            public DateTime fecha { get; set; }
            public string cliente { get; set; }
            public string mueble { get; set; }
            public double precio { get; set; }

            public Venta()
            {
            numero = "";
            fecha = DateTime.Today;
            cliente = "";
            mueble = "";
            precio = 0;
            }
            
            public double Descuento()
            {
            if (precio <= 700)
                return 0.03 * precio;
            else
                return 0.07 * precio;

            }
            public double Total()
            {
            return precio - Descuento();
            }

    }
}