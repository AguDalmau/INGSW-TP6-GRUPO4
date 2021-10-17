using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSw_TP6.TP6_Model
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public bool ValidarLongitudNombre()
        {
            if (this.Nombre.Length<=100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
