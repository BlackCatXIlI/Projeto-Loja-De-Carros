using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistema_projetoLojaCarros
{
    public partial class AlterV : Form
    {
        Conexao con = new Conexao();
        Consulta consulta;
        public int arquivoId { get; set; }
        MySqlCommand cmd = new MySqlCommand();
        public AlterV(Consulta cons)
        {
            InitializeComponent();
            TrocaLabel();
            consulta = cons;
            carregar();
            carregarIMG();
            Manterimg();
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
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void carregar()
        {
            
            {
                int Cod1 = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);

                con.ConectarBD();
                
                cmd.CommandText= "select MODELO, FABRICANTE, COR, PLACA, DESCRICAO from VEICULOS where COD_VEICULO = @Id";


                
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.Parameters.Add("Id", MySqlDbType.Int32).Value = Cod1;
                    

                   

                    using MySqlDataReader rdr = cmd.ExecuteReader();
                    {

                    rdr.Read();
                        

                    txtModelo.Text = rdr[0].ToString();
                    txtFab.Text = rdr[1].ToString();
                    CBcor.Text = rdr[2].ToString();
                    txtPlaca.Text = rdr[3].ToString();
                    txtDesc.Text = rdr[4].ToString();

                        

                    }

                    con.DesConectarBD();
                    
                }

            }

        }
        public void carregarIMG()
        {

            
                
         int Cod1 = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);

            cmd.Connection = con.ConectarBD();
            cmd.CommandText = "select IMAGE_DATA from VEICULOS where COD_VEICULO = "+Cod1+";";



            
            
                    
        byte[] imageData = (byte[])cmd.ExecuteScalar();

        MemoryStream ms = new MemoryStream(imageData);

        pbSelect.Image = Image.FromStream(ms);

        con.DesConectarBD();        
               
        }
        private void alter()
        {
            if (!CBmanter.Checked)
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
                                int codV = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);
                                
                                cmd.Connection = con.ConectarBD();
                                cmd.CommandText =
                                    "UPDATE VEICULOS set MODELO =@modelo,FABRICANTE=@fabricante,COR=@cor," +
                                    "PLACA = @placa,DESCRICAO = @descricao,NOME = @fileName, IMAGE_DATA = @imageData " +
                                    " WHERE COD_VEICULO = " + codV + ";";

                                cmd.Connection = con.ConectarBD();
                                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = txtModelo.Text;
                                cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFab.Text;
                                cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = CBcor.Text;
                                cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txtPlaca.Text;
                                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = txtDesc.Text;

                                cmd.Parameters.Add("@fileName", MySqlDbType.VarChar).Value = fileName;
                                cmd.Parameters.Add("@imageData", MySqlDbType.MediumBlob).Value = imageData;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Dados alterados com Sucesso !!!");



                                cmd.Parameters.Clear();
                                con.DesConectarBD();
                                this.Visible = false;
                                consulta.pbSelect.Image = null;
                                consulta.SelectV();
                                consulta.TXTselect.ResetText();
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
                        int codV = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);
                        string fileName = selectedFileName;
                        
                        cmd.Connection = con.ConectarBD();
                        cmd.CommandText =
                                   "UPDATE VEICULOS set MODELO =@modelo,FABRICANTE=@fabricante,COR=@cor," +
                                   "PLACA = @placa,DESCRICAO = @descricao,NOME = @fileName, IMAGE_DATA = @imageData " +
                                   " WHERE COD_VEICULO = " + codV + ";";

                        cmd.Connection = con.ConectarBD();
                        cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = txtModelo.Text;
                        cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFab.Text;
                        cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = CBcor.Text;
                        cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txtPlaca.Text;
                        cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = txtDesc.Text;

                        cmd.Parameters.Add("@fileName", MySqlDbType.VarChar).Value = fileName;
                        cmd.Parameters.Add("@imageData", MySqlDbType.MediumBlob).Value = imageData;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados alterados com Sucesso !!!");
                        this.Visible = false;
                        consulta.pbSelect.Image = null;
                        consulta.TXTselect.ResetText();
                        consulta.SelectV();
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
                try
                {

                    int codV = Convert.ToInt32(consulta.dgvConsulta1.CurrentRow.Cells["COD_VEICULO"].Value);
                    
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText =
                               "UPDATE VEICULOS set MODELO =@modelo,FABRICANTE=@fabricante,COR=@cor," +
                               "PLACA = @placa,DESCRICAO = @descricao" +
                               " WHERE COD_VEICULO = " + codV + ";";

                    cmd.Connection = con.ConectarBD();
                    cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = txtModelo.Text;
                    cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFab.Text;
                    cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = CBcor.Text;
                    cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txtPlaca.Text;
                    cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = txtDesc.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com Sucesso !!!");
                    this.Visible = false;
                    consulta.pbSelect.Image = null;
                    consulta.TXTselect.ResetText();
                    consulta.SelectV();
                    con.DesConectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD();
                }

            }
            

        }

            
        
        private void pbSelect_Click(object sender, EventArgs e)
        {

        }

        private void AlterV_Load(object sender, EventArgs e)
        {

        }

        private void BTNatu_Click(object sender, EventArgs e)
        {
            alter();
        }

        private void CBimage_CheckedChanged(object sender, EventArgs e)
        {
         TrocaLabel();
            
        }

        private void CBmanter_CheckedChanged(object sender, EventArgs e)
        {
            Manterimg();
        }
        public void Manterimg()
        {
            if (CBmanter.Checked)
            {
                CBimage.Visible = false;
                LBLimagem.Visible = false;

            }
            else 
            {
                CBimage.Visible = true;
                LBLimagem.Visible = true;


            }


        }
    }
}
