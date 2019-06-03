using System;
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
        private void RegistroTabMENU_Click(object sender, EventArgs e)
        {
            RegistrosP RProd = new RegistrosP();
            RProd.Visible = true;
        }

        private void ConsultasTabMENU_Click(object sender, EventArgs e)
        {
            ConsultasP CProd = new ConsultasP();
            CProd.Visible= true;
        }
    }
}