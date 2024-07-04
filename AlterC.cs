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
    public partial class AlterC : Form
    {
        Conexao con = new Conexao();
        Consulta consulta;
        
        public AlterC(Consulta cons)
        {
            InitializeComponent();
            
            consulta = cons;
            carregar();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        public void carregar()
        {
            MySqlCommand cmd = new MySqlCommand();
            {
                int Cod1 = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_CLI"].Value);

                con.ConectarBD();
                cmd.CommandText= "select NOME, SOBRENOME, DATE_FORMAT(NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO, LOGRADOURO, NUMERO, BAIRRO, CIDADE from CLIENTE " +
                "INNER JOIN ENDERECO ON COD_CLI = CODIGO_END where COD_CLI = @Id";


                
          
            cmd.Connection = con.ConectarBD();
            cmd.Parameters.Add("Id", MySqlDbType.Int32).Value = Cod1;
                    

            using MySqlDataReader rdr = cmd.ExecuteReader();
            {

            rdr.Read() ;
                        
                            
            txtNome.Text = rdr[0].ToString();
            txtSobrenome.Text = rdr[1].ToString();
            DTPnasc.Value = Convert.ToDateTime(rdr[2]);
            txtLog.Text = rdr[3].ToString();
            txtNumero.Text = rdr[4].ToString();
            txtBairro.Text = rdr[5].ToString();
            txtCidade.Text = rdr[6].ToString();
                        

            }

            con.DesConectarBD();
                    
                

            }

        }
        private void BTNatu_Click(object sender, EventArgs e)
        {
            int codC = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_CLI"].Value);

            

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
            else
            {
                try
                {
                    
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "UPDATE CLIENTE JOIN ENDERECO ON CLIENTE.COD_CLI = ENDERECO.CODIGO_END SET CLIENTE.NOME = @nome, " +
                        "CLIENTE.SOBRENOME = @sobrenome, CLIENTE.NASCIMENTO = STR_TO_DATE(@data_nasc, '%d/%m/%Y'), ENDERECO.LOGRADOURO = @logradouro," +
                        "ENDERECO.NUMERO = @numero, ENDERECO.BAIRRO = @bairro, ENDERECO.CIDADE = @cidade " +
                        "where COD_CLI = " + codC +  " ;";
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text;
                    cmd.Parameters.Add("@data_nasc", MySqlDbType.VarChar).Value = DTPnasc.Text;
                    cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = txtLog.Text;
                    cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = txtNumero.Text;
                    cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                    cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados alterados com Sucesso !!!");
                    cmd.Parameters.Clear();
                    con.DesConectarBD();
                    consulta.pbSelect.Image = null;
                    consulta.TXTselect.ResetText();
                    this.Visible = false;
                    consulta.SelectC();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD();
                }
            }

        }

        private void txtNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void DTPnasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AlterC_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras

            char.IsSymbol(e.KeyChar) || //Símbolos

            char.IsWhiteSpace(e.KeyChar)
            && e.KeyChar != 8) //Espaço

                e.Handled = true; //Não permitir
        }
    }
}
