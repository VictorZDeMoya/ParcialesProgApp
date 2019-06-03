using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using PAParcial1_VictorZDeMoya.DAL;
using PAParcial1_VictorZDeMoya.Entidades;

namespace PAParcial1_VictorZDeMoya.BLL
{
    public class InvBLL
    {
        public static bool Guardar(Inv inv)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.inv.Add(inv) != null)
                    paso = db.SaveChanges() > 0;
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
        public static bool Modificar(Inv inv)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(inv).State = EntityState.Modified;
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
        public static Inv Buscar(int id)
        {
            Contexto db = new Contexto();
            Inv inv = new Inv();

            try
            {
                inv = db.inv.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inv;
        }

    }
}

