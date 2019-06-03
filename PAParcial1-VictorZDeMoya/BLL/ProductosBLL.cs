using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAParcial1_VictorZDeMoya.DAL;
using PAParcial1_VictorZDeMoya.Entidades;
using System.Linq.Expressions;
using System.Data.Entity;


namespace PAParcial1_VictorZDeMoya.BLL
{
    public class ProductosBLL
    {
        public static Producto Buscar(int id)
        {
            Contexto db = new Contexto();
            Producto producto = new Producto();

            try
            {
                producto = db.producto.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;
        }
        public static bool Guardar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.producto.Add(producto) != null)
                    paso = db.SaveChanges() > 0;
                Inv inv = InvBLL.Buscar(1);
                inv.Total += producto.ValorInv;
                InvBLL.Modificar(inv);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Modificar(Producto producto)
        {
            bool paso = false;
            Producto productos = ProductosBLL.Buscar(producto.IdProducto);
            Contexto db = new Contexto();
            try
            {
                float resultado = producto.ValorInv - productos.ValorInv;

                Inv inve = InvBLL.Buscar(1);
                inve.Total += resultado;
                InvBLL.Modificar(inve);

                db.Entry(producto).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.producto.Find(id);
                var Inv = InvBLL.Buscar(1);
                Inv.Total -= eliminar.ValorInv;
                InvBLL.Modificar(Inv);

                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static List<Producto> GetList(Expression<Func<Producto, bool>> producto)
        {
            List<Producto> Lista = new List<Producto>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.producto.Where(producto).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}