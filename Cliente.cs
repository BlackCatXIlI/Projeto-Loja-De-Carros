using MySql.Data.MySqlClient;
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
    public partial class Cliente : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public Cliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
        public void carregarClientes()
        {
            

        }


        private void limpaCampos()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            DTPnasc.Text = "11/11/2011";
            txtLog.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();

        }

        
        private void btCada_Click(object sender, EventArgs e)
        {

            DTPnasc.MaxDate = DateTime.Today;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtNome.Focus();
            }
            else if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo sobrenome");
                txtSobrenome.Focus();
            }
            else if (txtLog.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo logradouro");
                txtLog.Focus();
            }
            
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Número");
                txtNumero.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo bairro");
                txtBairro.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo cidade");
                txtCidade.Focus();
            }
            else if (DTPnasc.Value >= DateTime.Today)
            {
                MessageBox.Show("Data invalida");
                txtCidade.Focus();
            }
            else
            {
                try
                {
                    string sql = "insert into CLIENTE(NOME,SOBRENOME,NASCIMENTO)values(@nome,@sobrenome,STR_TO_DATE(@data_nasc, '%d/%m/%Y'));" +
                        "insert into ENDERECO(LOGRADOURO,NUMERO,BAIRRO,CIDADE)values(@logradouro,@numero,@bairro,@cidade)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConectarBD());

                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text;
                    cmd.Parameters.Add("@data_nasc", MySqlDbType.VarChar).Value = DTPnasc.Text;
                    cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = txtLog.Text;
                    cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = txtNumero.Text;
                    cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                    cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                   
                    limpaCampos();
                    txtNome.Focus();
                    con.DesConectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD();
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLog_Click(object sender, EventArgs e)
        {
            Text = "";
        }

        private void txtLog_MouseClick(object sender, MouseEventArgs e)
        {
            Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || //Letras

            char.IsSymbol(e.KeyChar) || //Símbolos

            char.IsWhiteSpace(e.KeyChar)
            && e.KeyChar !=8) //Espaço

            e.Handled = true; //Não permitir
        }

        private void DTPnasc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

