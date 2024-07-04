using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_projetoLojaCarros
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Tiker_Tick(object sender, EventArgs e)
        {
            {
                if (load.Value < 100)
                {
                    load.Value = load.Value + 2;
                }
                else
                {
                    Tiker.Enabled = false;
                    this.Visible = false;

                    Menu Menu = new Menu();
                    Menu.ShowDialog();
                    MessageBox.Show("Seja bem Vindo ao Sistema !!!");
                }
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
