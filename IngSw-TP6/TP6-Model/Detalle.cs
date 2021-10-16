using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSw_TP6.TP6_Model
{
    public class Detalle
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public bool CantidadMayorACero()
        {
            if (this.Cantidad > 0)
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
