using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSw_TP6.TP6_Model
{
    public class Carrito
    {
        public List<Detalle> ListaDetalle { get; set; }

        public Carrito()
        {
            this.ListaDetalle = new List<Detalle>();
        }

        public bool CarritoVacio()
        {
            if (this.ListaDetalle.Count == 0)
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
