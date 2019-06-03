using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAParcial1_VictorZDeMoya.Entidades;
using System.Data.Entity;

namespace PAParcial1_VictorZDeMoya.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Producto> producto { get; set; }
        public DbSet<Inv> inv { get; set; }
        public Contexto() : base("ConStr") { }
    }
}