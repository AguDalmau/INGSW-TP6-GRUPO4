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
        public bool ValidarLongitudDescripcion()
        {
            if(this.Desc.Length<=150)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*----------------------------------------*/

         public bool ValidarLongitudMinNombre()
        {
            if (this.Nombre.Length>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidarLongitudMinDescripcion()
        {
            if(this.Desc.Length>=20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------*/

        public bool ValidarCantidadStockMayor0()
        {
            if ( this.Stock>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarTodoProductoTieneNombre() 
        {
            if (this.Nombre != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarProductoTieneNombreSinCaracteresEspeciales() 
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Nombre,"^[a-zA-Z0-9\x20]+$"))
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
