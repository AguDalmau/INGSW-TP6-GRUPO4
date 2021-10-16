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
        public void Carrito_NoVacio()
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
                producto = producto1,
                cantidad = 1
            };
            carrito.ListaDetalle.Add(detalle);
            var expected = false;

            //Act
            var actual = carrito.carritoVacio();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}