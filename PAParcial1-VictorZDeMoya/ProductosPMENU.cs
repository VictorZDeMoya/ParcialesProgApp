using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAParcial1_VictorZDeMoya.UI.Registros;
using PAParcial1_VictorZDeMoya.UI.Consultas;


namespace PAParcial1_VictorZDeMoya
{
    public partial class ProductosPMENU : Form
    {
        public ProductosPMENU()
        {
            InitializeComponent();
        }
        private void RegistroMENU_Click(object sender, EventArgs e)
        {
            RegistrosP RProd = new RegistrosP();
            RProd.Visible = true;
        }

        private void ConsultaMENU_Click(object sender, EventArgs e)
        {
            ConsultasP CProd = new ConsultasP();
            CProd.Visible= true;
        }
    }
}
