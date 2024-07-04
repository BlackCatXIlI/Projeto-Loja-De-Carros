using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_projetoLojaCarros
{
    public partial class Login : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader objDados;
        public Login()
        {
            InitializeComponent();
            TrocaLabel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuario/Senha inválidos");
            }
            else
            {
                try
                {
                    con.ConectarBD();
                    cmd.CommandText = "select * from LOGIN where usuario =('" + txtUsu.Text + "') and senha =('" + txtSenha.Text + "')";
                    cmd.Connection = con.ConectarBD(); 
                    objDados = cmd.ExecuteReader();  

                    if (objDados.HasRows)
                    {
                        Loading splash = new Loading();
                        splash.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Usuario/senha Inválidos");
                        txtUsu.Clear();
                        txtSenha.Clear();
                        txtUsu.Focus();
                    }
                }
                catch (Exception erro) // explode mensagem de erro se alguma coisa acontecer de errado no try
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD(); // fechando conexao
                }
                finally
                {
                    con.DesConectarBD();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBvisivel_CheckedChanged(object sender, EventArgs e)
        {
            TrocaLabel();
        }
        private void TrocaLabel()
        {
            if (CBvisivel.Checked)
            {
                txtSenha.PasswordChar = '*';
                LBLvisivel.Text = "mostrar";
                

            }
            else 
            {
                txtSenha.PasswordChar = default;
                LBLvisivel.Text = "esconder";
            }
            
                
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
