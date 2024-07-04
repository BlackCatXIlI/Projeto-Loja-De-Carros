using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_projetoLojaCarros
{
    public partial class Veiculos : Form
    {




        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        public int arquivoId { get; set; }
        public Veiculos()
        {
            InitializeComponent();
            
            TrocaLabel();
        }




        private void Veiculos_Load(object sender, EventArgs e)
        {

        }
        
        private void limpaCampos()
        {
            txtModelo.Clear();
            txtFab.Clear();
            CBcor.ResetText();
            txtPlaca.Clear();
            txtDesc.Clear();
            
            pbSelect.Image = null;

        }
        private void TrocaLabel()
        {
            if (CBimage.Checked)
            {
                LBLimagem.Text = "Com imagem";
            }
            else
                LBLimagem.Text = "Sem imagem";
        }
       

        private void btCada_Click(object sender, EventArgs e)
        {
           
            insert();
        }

        

            private void txtPesquisa_TextChanged(object sender, EventArgs e)
            {
            
                
            }
            
        private void insert()
        {

            if (txtModelo.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Modelo");
                txtModelo.Focus();
            }
            else if (txtFab.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Fabricante");
                txtFab.Focus();
            }

            else if (CBcor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo cor");
                CBcor.Focus();
            }
            else if (txtPlaca.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo placa");
                txtPlaca.Focus();
            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Descrição");
                txtDesc.Focus();
            }
            else if (CBimage.Checked)
            {


                
                ofdImage.Filter = "Image Files (*.jpg; *.png; *.gif; *.bmp)|*.jpg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                ofdImage.Title = "Selecione um arquivo de imagem";
                


                if (ofdImage.ShowDialog() == DialogResult.OK)
                {

                    string selectedFileName = ofdImage.FileName;
                    pbSelect.Image = new Bitmap(selectedFileName);


                    byte[] imageData;
                    using (FileStream fs = new FileStream(selectedFileName, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            imageData = br.ReadBytes((int)fs.Length);
                        }
                    }

                    string fileName = selectedFileName;
                    if (imageData.Length <= 16.000000)
                    {

                        MessageBox.Show("Maior que 16mb");

                    }
                    else
                        try
                        {
                            string sql = "" +

                                "insert into VEICULOS(MODELO,FABRICANTE,COR,PLACA,DESCRICAO,NOME, IMAGE_DATA)values(@modelo,@fabricante,@cor,@placa,@descricao,@fileName, @imageData);";

                            MySqlCommand cmd = new MySqlCommand(sql, con.ConectarBD());


                            cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = txtModelo.Text;
                            cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFab.Text;
                            cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = CBcor.Text;
                            cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txtPlaca.Text;
                            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = txtDesc.Text;

                            cmd.Parameters.Add("@fileName", MySqlDbType.VarChar).Value = fileName;
                            cmd.Parameters.Add("@imageData", MySqlDbType.MediumBlob).Value = imageData;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Dados cadastrados com Sucesso !!!");
                            limpaCampos();
                            txtModelo.Focus();
                            con.DesConectarBD();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            con.DesConectarBD();
                        }

                }
                


            }
            else
            {
                string caminho = ofdImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                 string xix = ofdImage.FileName = (caminho + @"\sistema_projetoLojaCarros\Resources\xix.jpg");
                string selectedFileName = xix;
                pbSelect.Image = new Bitmap(selectedFileName);


                byte[] imageData;
                using (FileStream fs = new FileStream(selectedFileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        imageData = br.ReadBytes((int)fs.Length);
                    }
                }


                try
                {
                    string fileName = selectedFileName;
                    string sql = "" +

                        "insert into VEICULOS(MODELO,FABRICANTE,COR,PLACA,DESCRICAO,NOME, IMAGE_DATA)values(@modelo,@fabricante,@cor,@placa,@descricao,@fileName, @imageData);";

                    MySqlCommand cmd = new MySqlCommand(sql, con.ConectarBD());
                    cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = txtModelo.Text;
                    cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFab.Text;
                    cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = CBcor.Text;
                    cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txtPlaca.Text;
                    cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = txtDesc.Text;

                    cmd.Parameters.Add("@fileName", MySqlDbType.VarChar).Value = fileName;
                    cmd.Parameters.Add("@imageData", MySqlDbType.MediumBlob).Value = imageData;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    limpaCampos();
                    txtModelo.Focus();
                    con.DesConectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD();
                }


            }

        }
        
        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        { }
        

        




        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TrocaLabel();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CBcor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
