using Microsoft.VisualStudio.TestTools.UnitTesting;
using PedidosBlazor.BLL;
using PedidosBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosBlazor.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        public void GuardarTest()
        {
            Ordenes ordenes = new Ordenes();
            ordenes.ordenId = 0;
            ordenes.suplidorId = 1;
            ordenes.fecha = DateTime.Now;
            ordenes.monto = 100;
            ordenes.OrdenDetalles.Add(new OrdenesDetalle
            {
                ordenDetalleId = 0,
                ordenId = 0,
                productoId = 1,
                costo = 100,
                cantidad = 1
            });

            Assert.IsTrue(OrdenesBLL.Guardar(ordenes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = OrdenesBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Assert.Fail();
        }
    }
}