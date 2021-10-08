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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            this.Hide();
            Home casa = new Home();
            casa.ShowDialog();
            this.Show();

            this.Close();
        }
    }
}
