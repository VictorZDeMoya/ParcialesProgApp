using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAParcial1_VictorZDeMoya.BLL;
using PAParcial1_VictorZDeMoya.Entidades;

namespace PAParcial1_VictorZDeMoya.UI.Consultas
{
    public partial class ConsultasP : Form
    {
        public ConsultasP()
        {
            InitializeComponent();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            Inv inv = InvBLL.Buscar(1);
            double Total = inv.Total;
            TotalInvWrite.Text = Total.ToString();
        }
    }
}
