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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AbrirNovaJanela(new Inicio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void AbrirNovaJanela(object abrirnovajanela)
        {
            if (this.pnConteudo.Controls.Count > 0)
                this.pnConteudo.Controls.RemoveAt(0);
            Form novaJan = abrirnovajanela as Form;
            novaJan.TopLevel = false;
            novaJan.Dock = DockStyle.Fill;
            this.pnConteudo.Controls.Add(novaJan);
            this.pnConteudo.Tag = novaJan;
            novaJan.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Inicio());
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Cliente());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Veiculos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Consulta());
        }

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Consulta());
        }
    }
}
