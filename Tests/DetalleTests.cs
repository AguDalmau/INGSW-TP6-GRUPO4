using IngSw_TP6.TP6_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class DetalleTests
    {
        [TestMethod]
        public void Detalle_CantidadMayorACero()
        {
            //Arrange
            Detalle detalle = new();
            Producto producto = new()
            {
                Nombre = "Harry Potter 1",
                Desc = "Libro de ciencia ficcion para jovenes",
                Precio = 980,
                Stock = 2
            };
            detalle.Producto = producto;
            detalle.Cantidad = 1;
            bool expected = true;

            //Act
            bool actual = detalle.CantidadMayorACero();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
