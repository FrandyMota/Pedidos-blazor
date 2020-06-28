using PedidosBlazor.DAL;
using PedidosBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PedidosBlazor.BLL
{
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> expression)
        {
            List<Suplidores> lista = new List<Suplidores>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Suplidores.Where(expression).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                db.Dispose();
            }
            return lista;

        }
    }
}
