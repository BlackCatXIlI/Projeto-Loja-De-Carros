using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace sistema_projetoLojaCarros
{
    public partial class Consulta : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Consulta()
        {
            InitializeComponent();
            LoadImageNames();
            
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void LoadImageNames()
        {
            try
            {
                con.ConectarBD();
                
                cmd.CommandText= "SELECT COD_VEICULO, NOME FROM VEICULOS";



                cmd.Connection = con.ConectarBD();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                    

                    while (reader.Read())
                        {


                            int imageId = reader.GetInt32("COD_VEICULO");
                            string imageName = reader.GetString("NOME");


                        }
                    }

                
                con.DesConectarBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em carregar o nome da imagem: " + ex.Message);
                con.DesConectarBD();
            }
        }
        private void limpaCampos()
        {
            
            
            pbSelect.Image = null;

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!CBconsulta.SelectedIndex.Equals(-1))
            {

                DialogResult excluir = MessageBox.Show("Deseja excluir esse registro ?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (excluir == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                        try
                        {
                            int selectedId = Convert.ToInt32(dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);
                            
                            con.ConectarBD();
                            cmd.CommandText = "delete from VEICULOS where COD_VEICULO=" + selectedId;
                           
                            cmd.ExecuteNonQuery();
                            cmd.Connection = con.ConectarBD();
                            MessageBox.Show("Registro exluido com sucesso");
                            SelectV();
                            
                            TXTselect.ResetText();
                            dgvConsulta1.Refresh();
                            cmd.Parameters.Clear();
                            con.DesConectarBD();

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
                    {

                        try
                        {
                            int selectedId = Convert.ToInt32(dgvConsulta1.CurrentRow.Cells["COD_CLI"].Value);
                            
                            con.ConectarBD();
                            cmd.CommandText = "delete from Cliente where COD_CLI=" + selectedId;
                            
                            cmd.ExecuteNonQuery();
                            cmd.Connection = con.ConectarBD();
                            MessageBox.Show("Registro exluido com sucesso");
                            SelectC();
                            
                            TXTselect.ResetText();
                            dgvConsulta1.Refresh();
                            cmd.Parameters.Clear();
                            con.DesConectarBD();

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }

                    }

                }
            }

            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
            
        }

        private void dgvConsulta1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                try
                {
                    string[] nomes = ["COD_VEICULO", "MODELO", "FABRICANTE", "COR", "PLACA", "DESCRICAO"];

                    int selectedId = Convert.ToInt32(dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);
                    
                    int cell = (dgvConsulta1.CurrentCell.ColumnIndex);


                    
                    {
                        con.ConectarBD();
                        
                        cmd.CommandText= "SELECT " + nomes[cell] + " FROM VEICULOS WHERE COD_VEICULO = "+selectedId+";";
            
                        
                        

                           
                        cmd.Connection = con.ConectarBD();

                        using MySqlDataReader rdr = cmd.ExecuteReader();
                            {
                                if (rdr.HasRows)
                                {
                                rdr.Read() ;
                                    
                                TXTselect.Text = rdr[0].ToString();

                                    
                                }

                            }
                            
                            con.DesConectarBD();
                            
                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro em carregar o texto V: " + ex.Message);
                }
            else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
            {

                try
                {
                    string[] nomesC = ["COD_CLI", "NOME", "SOBRENOME", "DATE_FORMAT(NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO", "LOGRADOURO", "NUMERO", "BAIRRO", "CIDADE"];

                    int selectedId1 = Convert.ToInt32(dgvConsulta1.CurrentRow.Cells["COD_CLI"].Value);
                    int cell1 = (dgvConsulta1.CurrentCell.ColumnIndex);


                    
                    {
                        con.ConectarBD();
                        
                        cmd.CommandText= "select " + nomesC[cell1] + " from CLIENTE " +
                        "INNER JOIN ENDERECO ON COD_CLI = CODIGO_END where COD_CLI = "+ selectedId1 + ";";
                        
                        cmd.Connection = con.ConectarBD();

                        using MySqlDataReader rdr = cmd.ExecuteReader();
                        {


                        rdr.Read() ;
                            
                        TXTselect.Text = rdr[0].ToString();

                            



                        }
                            
                        con.DesConectarBD();
                          
                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro em carregar o texto C: " + ex.Message);
                }

            }


            
        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void CBconsulta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (CBconsulta.SelectedIndex.Equals(-1))
            {
                

                MessageBox.Show("Nenhum item selecionado");

            }
            
            else 
            {
                
                if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                {
                    CBconsulta.ResetText();
                    TXTselect.Text = "";
                    pbSelect.Image = null;
                    SelectV();
                }
                else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
                {
                    CBconsulta.ResetText();
                    TXTselect.Text = "";
                    pbSelect.Image = null;
                    SelectC();
                }
            }
        }

        private void CBconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CBconsulta.SelectedIndex.Equals (-1))
            {

                if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                {
                    pbSelect.Visible = true;
                    LBLimg.Visible = true;
                    TXTselect.Text = "";
                    pbSelect.Image = null;
                    try
                    {
                        SelectV();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
                else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
                {
                    TXTselect.Text = "";
                    pbSelect.Visible = false;
                    LBLimg.Visible = false;
                    try
                    {
                        SelectC();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }

            }
            
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        public void SelectV()
        {

            con.ConectarBD();
            
            cmd.CommandText = "select COD_VEICULO, MODELO, FABRICANTE,COR, PLACA, DESCRICAO from VEICULOS ";
            cmd.Connection = con.ConectarBD();
            MySqlDataAdapter da = new MySqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvConsulta1.DataSource = dt;
            con.DesConectarBD();

        }
        public void SelectC() 
        {

            pbSelect.Image = null;

            con.ConectarBD();
            
            cmd.CommandText = "select COD_CLI, NOME, SOBRENOME,DATE_FORMAT(NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO, LOGRADOURO, NUMERO, BAIRRO, CIDADE from CLIENTE " +
                "INNER JOIN ENDERECO ON COD_CLI = CODIGO_END";

            cmd.Connection = con.ConectarBD();
            MySqlDataAdapter da = new MySqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvConsulta1.DataSource = dt;
            con.DesConectarBD();

        }
        private void CBconsulta_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CBconsulta.SelectedIndex.Equals(-1))
            {


                MessageBox.Show("Nenhum item selecionado");

            }

            else
            {

                if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                {
                    AlterV alterV = new AlterV(this);
                    alterV.Show();
                }
                else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
                {
                    AlterC alter = new AlterC(this);
                    alter.Show();
                }
            }
        }

        private void txtFab_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dgvConsulta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
        
        private void dgvConsulta1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                try
                {


                    int selectedImageId = Convert.ToInt32(dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);

                    
                    {
                        con.ConectarBD();
                        
                        cmd.CommandText= "SELECT IMAGE_DATA FROM VEICULOS WHERE COD_VEICULO = "+ selectedImageId + ";";

                        cmd.Connection = con.ConectarBD();
                        

                        byte[] imageData = (byte[])cmd.ExecuteScalar();


                        MemoryStream ms = new MemoryStream(imageData);

                        pbSelect.Image = Image.FromStream(ms);

                        con.DesConectarBD();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro em carregar a imagem: " + ex.Message);
                }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CriarPlanilha();
        }
        private void CriarPlanilha()
        {

            if (CBconsulta.SelectedIndex.Equals(-1))
            {


                MessageBox.Show("Nenhum item selecionado");

            }

            else
            {

                if (CBconsulta.SelectedItem.Equals("VEICULOS"))
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook pasta = app.Workbooks.Add();
                    Excel.Worksheet planilha;
                    planilha = pasta.Worksheets.Add();
                    //COD_VEICULO, MODELO, FABRICANTE,COR, PLACA, DESCRICAO
                    planilha.Range["A1"].Value = "Codigo";
                    planilha.Range["B1"].Value = "Modelo";
                    planilha.Range["C1"].Value = "Fabricante";
                    planilha.Range["D1"].Value = "Cor";
                    planilha.Range["E1"].Value = "Placa";
                    planilha.Range["F1"].Value = "Descrição";
                    


                    int N = 2;
                    foreach (DataGridViewRow row in dgvConsulta1.Rows)
                    {

                        planilha.Range["A" + N].Value = row.Cells["COD_VEICULO"].Value;
                        planilha.Range["B" + N].Value = row.Cells["MODELO"].Value;
                        planilha.Range["C" + N].Value = row.Cells["FABRICANTE"].Value;
                        planilha.Range["D" + N].Value = row.Cells["COR"].Value;
                        planilha.Range["E" + N].Value = row.Cells["PLACA"].Value;
                        planilha.Range["F" + N++].Value = row.Cells["DESCRICAO"].Value;
                        

                    }

                    string caminho = ofdImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string Arquivo = ofdImage.FileName = (caminho + @"\sistema_projetoLojaCarros\Planilhas\dadosDoVeiculo.xlsx");
                    MessageBox.Show("Planilha criada");
                    pasta.SaveAs(Arquivo);
                    pasta.Close();
                    app.Quit();
                }
                else if (CBconsulta.SelectedItem.Equals("CLIENTES"))
                {
                    //COD_CLI, NOME, SOBRENOME,DATE_FORMAT(NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO, LOGRADOURO, NUMERO, BAIRRO, CIDADE
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook pasta = app.Workbooks.Add();
                    Excel.Worksheet planilha;
                    planilha = pasta.Worksheets.Add();

                    planilha.Range["A1"].Value = "Codigo";
                    planilha.Range["B1"].Value = "Nome";
                    planilha.Range["C1"].Value = "Sobrenome";
                    planilha.Range["D1"].Value = "Nascimento";
                    planilha.Range["E1"].Value = "Logradouro";
                    planilha.Range["F1"].Value = "Número";
                    planilha.Range["G1"].Value = "Bairo";
                    planilha.Range["H1"].Value = "Cidade";


                    int N = 2;
                    foreach (DataGridViewRow row in dgvConsulta1.Rows)
                    {

                        planilha.Range["A" + N].Value = row.Cells["COD_CLI"].Value;
                        planilha.Range["B" + N].Value = row.Cells["NOME"].Value;
                        planilha.Range["C" + N].Value = row.Cells["SOBRENOME"].Value;
                        planilha.Range["D" + N].Value = row.Cells["NASCIMENTO"].Value;
                        planilha.Range["E" + N].Value = row.Cells["LOGRADOURO"].Value;
                        planilha.Range["F" + N].Value = row.Cells["NUMERO"].Value;
                        planilha.Range["G" + N].Value = row.Cells["BAIRRO"].Value;
                        planilha.Range["H" + N++].Value = row.Cells["CIDADE"].Value;

                    }
                    
                    string caminho = ofdImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string Arquivo = ofdImage.FileName = (caminho + @"\sistema_projetoLojaCarros\Planilhas\dadosDoCliente.xlsx");
                    MessageBox.Show("Planilha criada");
                    pasta.SaveAs(Arquivo);
                    pasta.Close();
                    app.Quit();
                }
            }

            

        }
    }
}
