using GS.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS.WIN.Vendas
{
    public partial class Cliente : Form
    {

        private bool status = true;
        private int CodCli = 0;
        private readonly ;

        public Cliente(int _codcli)
        {
            InitializeComponent();
            CodCli = _codcli;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            if(CodCli > 0)
                Consulta();

            VerStatus();

        }

        private void Consulta()
        {

        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Status_Click(object sender, EventArgs e)
        {
            VerStatus();
        }

        private void VerStatus()
        {
            if (status) //true
            {
                bt_Status.Image = Properties.Resources.switch_on_icon_48X48;
                status = false;
            }
            else
            {
                bt_Status.Image = Properties.Resources.switch_off_icon_48X48;
                status = true;
            }
                
        }
    }
}
