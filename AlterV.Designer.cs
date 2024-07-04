namespace sistema_projetoLojaCarros
{
    partial class AlterV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBmanter = new System.Windows.Forms.CheckBox();
            this.LBLimagem = new System.Windows.Forms.Label();
            this.CBimage = new System.Windows.Forms.CheckBox();
            this.pbSelect = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBcor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNatu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(198)))), ((int)(((byte)(159)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CBmanter);
            this.groupBox1.Controls.Add(this.LBLimagem);
            this.groupBox1.Controls.Add(this.CBimage);
            this.groupBox1.Controls.Add(this.pbSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBcor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BTNatu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txtFab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 426);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(333, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "manter imagem";
            // 
            // CBmanter
            // 
            this.CBmanter.AutoSize = true;
            this.CBmanter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBmanter.ForeColor = System.Drawing.Color.DarkRed;
            this.CBmanter.Location = new System.Drawing.Point(313, 244);
            this.CBmanter.Name = "CBmanter";
            this.CBmanter.Size = new System.Drawing.Size(15, 14);
            this.CBmanter.TabIndex = 52;
            this.CBmanter.UseVisualStyleBackColor = true;
            this.CBmanter.CheckedChanged += new System.EventHandler(this.CBmanter_CheckedChanged);
            // 
            // LBLimagem
            // 
            this.LBLimagem.AutoSize = true;
            this.LBLimagem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLimagem.ForeColor = System.Drawing.Color.DarkRed;
            this.LBLimagem.Location = new System.Drawing.Point(374, 339);
            this.LBLimagem.Name = "LBLimagem";
            this.LBLimagem.Size = new System.Drawing.Size(0, 21);
            this.LBLimagem.TabIndex = 51;
            // 
            // CBimage
            // 
            this.CBimage.AutoSize = true;
            this.CBimage.Checked = true;
            this.CBimage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBimage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBimage.ForeColor = System.Drawing.Color.DarkRed;
            this.CBimage.Location = new System.Drawing.Point(354, 343);
            this.CBimage.Name = "CBimage";
            this.CBimage.Size = new System.Drawing.Size(15, 14);
            this.CBimage.TabIndex = 50;
            this.CBimage.UseVisualStyleBackColor = true;
            this.CBimage.CheckedChanged += new System.EventHandler(this.CBimage_CheckedChanged);
            // 
            // pbSelect
            // 
            this.pbSelect.AccessibleName = "Imagem do veículo";
            this.pbSelect.BackColor = System.Drawing.Color.White;
            this.pbSelect.Location = new System.Drawing.Point(276, 59);
            this.pbSelect.Name = "pbSelect";
            this.pbSelect.Size = new System.Drawing.Size(195, 165);
            this.pbSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelect.TabIndex = 44;
            this.pbSelect.TabStop = false;
            this.pbSelect.Click += new System.EventHandler(this.pbSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(309, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Imagem do carro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(36, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Descrição:";
            // 
            // CBcor
            // 
            this.CBcor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBcor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.CBcor.FormattingEnabled = true;
            this.CBcor.Items.AddRange(new object[] {
            "Azul",
            "Amarelo",
            "Vermelho",
            "Prata",
            "Cinza",
            "Preto",
            "Branco"});
            this.CBcor.Location = new System.Drawing.Point(33, 131);
            this.CBcor.MaxLength = 10;
            this.CBcor.Name = "CBcor";
            this.CBcor.Size = new System.Drawing.Size(218, 29);
            this.CBcor.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(36, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Placa:";
            // 
            // BTNatu
            // 
            this.BTNatu.BackColor = System.Drawing.Color.Tomato;
            this.BTNatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNatu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNatu.Location = new System.Drawing.Point(159, 327);
            this.BTNatu.Name = "BTNatu";
            this.BTNatu.Size = new System.Drawing.Size(189, 46);
            this.BTNatu.TabIndex = 3;
            this.BTNatu.Text = "ATUALIZAR";
            this.BTNatu.UseVisualStyleBackColor = false;
            this.BTNatu.Click += new System.EventHandler(this.BTNatu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(36, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.DarkRed;
            this.txtModelo.Location = new System.Drawing.Point(36, 32);
            this.txtModelo.MaxLength = 20;
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtModelo.Size = new System.Drawing.Size(218, 24);
            this.txtModelo.TabIndex = 38;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDesc.Location = new System.Drawing.Point(31, 240);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesc.Size = new System.Drawing.Size(218, 58);
            this.txtDesc.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(36, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cor:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPlaca.Location = new System.Drawing.Point(33, 189);
            this.txtPlaca.MaxLength = 10;
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlaca.Size = new System.Drawing.Size(218, 24);
            this.txtPlaca.TabIndex = 40;
            // 
            // txtFab
            // 
            this.txtFab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFab.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFab.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFab.Location = new System.Drawing.Point(33, 83);
            this.txtFab.MaxLength = 15;
            this.txtFab.Multiline = true;
            this.txtFab.Name = "txtFab";
            this.txtFab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFab.Size = new System.Drawing.Size(218, 24);
            this.txtFab.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fabricante:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tomato;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Location = new System.Drawing.Point(475, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 29);
            this.button5.TabIndex = 37;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 56);
            this.button1.TabIndex = 36;
            this.button1.Text = "Atualizar veiculo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // AlterV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 511);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterV";
            this.Text = "AlterV";
            this.Load += new System.EventHandler(this.AlterV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNatu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBcor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLimagem;
        private System.Windows.Forms.CheckBox CBimage;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBmanter;
    }
}