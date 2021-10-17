using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngSw_TP6.TP6_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProductoTests
    {
        [TestMethod]
        public void ValidarLongitudNombre_LongitudMenor100Caracteres()
        {
            //Arrange
            Producto producto = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            bool expected = true;

            //Act
            bool actual = producto.ValidarLongitudNombre();

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ValidarLongitudDescripcion_LongitudMenor150Caracteres()
        {
            //Arrange
            Producto producto = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            bool expected = true;

            //Act
            bool actual = producto.ValidarLongitudDescripcion();

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ValidarCantidadStockMayor0_CantidadStockproductoMayor0 ()
        {
            //Arrange
            Producto producto = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            bool expected = true;

            //Act
            bool actual = producto.ValidarCantidadStockMayor0();

            //Assert
            Assert.AreEqual(expected,actual);
        }           
    
    }
}