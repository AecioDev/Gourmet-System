using GS.WIN.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS.WIN.Shared
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            EscondeControles(true);
            Cliente cli = new Cliente(0);
            cli.ShowDialog();
            EscondeControles(false);
        }

        private void EscondeControles(bool op)
        {
            if (op) //Esconder
            {
                bt_Clientes.Visible = false;

            }
            else
            {
                bt_Clientes.Visible = true;

            }

        }
    }
}
