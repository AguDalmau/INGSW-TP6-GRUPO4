using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngSw_TP6.TP6_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CarritoTests
    {
        [TestMethod]
        public void CarritoVacio_ElCarritoContieneUnDetalle()
        {
            //Arrange
            Carrito carrito = new();
            Producto producto1 = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            Detalle detalle = new()
            {
                Producto = producto1,
                Cantidad = 1
            };
            carrito.ListaDetalle.Add(detalle);
            var expected = false;

            //Act
            var actual = carrito.CarritoVacio();

            //Assert
            Assert.AreEqual(expected, actual);
        } 
        [TestMethod]  
        public void CantidadProductos_CarritoContieneAlMenosUnProducto ()
        {
            //Arrange
            Carrito carrito = new();
            Producto producto1 = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            Detalle detalle = new()
            {
                Producto = producto1,
                Cantidad = 1
            };
            carrito.ListaDetalle.Add(detalle);
            var expected = 1;

            //Act
            var actual= carrito.CantidadProductos() ;

            //Assert
            Assert.AreEqual(expected, actual) ;
            
        }

    }
}