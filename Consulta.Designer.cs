namespace sistema_projetoLojaCarros
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTselect = new System.Windows.Forms.TextBox();
            this.CBconsulta = new System.Windows.Forms.ComboBox();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.LBLimg = new System.Windows.Forms.Label();
            this.pbSelect = new System.Windows.Forms.PictureBox();
            this.BTNatu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNexcel = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tomato;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Location = new System.Drawing.Point(767, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 29);
            this.button5.TabIndex = 18;
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
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(803, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(198)))), ((int)(((byte)(159)))));
            this.groupBox1.Controls.Add(this.BTNexcel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXTselect);
            this.groupBox1.Controls.Add(this.CBconsulta);
            this.groupBox1.Controls.Add(this.dgvConsulta1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LBLimg);
            this.groupBox1.Controls.Add(this.pbSelect);
            this.groupBox1.Controls.Add(this.BTNatu);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 427);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Texto selecionado:";
            // 
            // TXTselect
            // 
            this.TXTselect.BackColor = System.Drawing.Color.White;
            this.TXTselect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTselect.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTselect.ForeColor = System.Drawing.Color.DarkRed;
            this.TXTselect.Location = new System.Drawing.Point(32, 98);
            this.TXTselect.MaxLength = 15;
            this.TXTselect.Multiline = true;
            this.TXTselect.Name = "TXTselect";
            this.TXTselect.ReadOnly = true;
            this.TXTselect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTselect.Size = new System.Drawing.Size(266, 100);
            this.TXTselect.TabIndex = 23;
            this.TXTselect.TextChanged += new System.EventHandler(this.txtFab_TextChanged);
            // 
            // CBconsulta
            // 
            this.CBconsulta.BackColor = System.Drawing.Color.White;
            this.CBconsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBconsulta.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBconsulta.ForeColor = System.Drawing.Color.DarkRed;
            this.CBconsulta.Items.AddRange(new object[] {
            "VEICULOS",
            "CLIENTES"});
            this.CBconsulta.Location = new System.Drawing.Point(185, 24);
            this.CBconsulta.Name = "CBconsulta";
            this.CBconsulta.Size = new System.Drawing.Size(115, 25);
            this.CBconsulta.TabIndex = 22;
            this.CBconsulta.SelectedIndexChanged += new System.EventHandler(this.CBconsulta_SelectedIndexChanged);
            this.CBconsulta.TextUpdate += new System.EventHandler(this.CBconsulta_TextUpdate);
            this.CBconsulta.TextChanged += new System.EventHandler(this.CBconsulta_TextChanged);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.AllowUserToResizeColumns = false;
            this.dgvConsulta1.AllowUserToResizeRows = false;
            this.dgvConsulta1.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(6, 212);
            this.dgvConsulta1.MultiSelect = false;
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.Size = new System.Drawing.Size(764, 200);
            this.dgvConsulta1.TabIndex = 5;
            this.dgvConsulta1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta1_CellClick);
            this.dgvConsulta1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta1_CellContentClick);
            this.dgvConsulta1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsulta1_CellMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(92, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pesquisar:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // LBLimg
            // 
            this.LBLimg.AutoSize = true;
            this.LBLimg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLimg.ForeColor = System.Drawing.Color.DarkRed;
            this.LBLimg.Location = new System.Drawing.Point(392, 0);
            this.LBLimg.Name = "LBLimg";
            this.LBLimg.Size = new System.Drawing.Size(144, 21);
            this.LBLimg.TabIndex = 9;
            this.LBLimg.Text = "Imagem do carro:";
            // 
            // pbSelect
            // 
            this.pbSelect.AccessibleName = "Imagem do veículo";
            this.pbSelect.BackColor = System.Drawing.Color.White;
            this.pbSelect.Location = new System.Drawing.Point(363, 24);
            this.pbSelect.Name = "pbSelect";
            this.pbSelect.Size = new System.Drawing.Size(201, 174);
            this.pbSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelect.TabIndex = 15;
            this.pbSelect.TabStop = false;
            // 
            // BTNatu
            // 
            this.BTNatu.BackColor = System.Drawing.Color.Tomato;
            this.BTNatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNatu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNatu.Location = new System.Drawing.Point(609, 146);
            this.BTNatu.Name = "BTNatu";
            this.BTNatu.Size = new System.Drawing.Size(143, 37);
            this.BTNatu.TabIndex = 14;
            this.BTNatu.Text = "ATUALIZAR";
            this.BTNatu.UseVisualStyleBackColor = false;
            this.BTNatu.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(609, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "ALTERAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(609, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "DELETAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BTNexcel
            // 
            this.BTNexcel.BackColor = System.Drawing.Color.Tomato;
            this.BTNexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNexcel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNexcel.Location = new System.Drawing.Point(609, 103);
            this.BTNexcel.Name = "BTNexcel";
            this.BTNexcel.Size = new System.Drawing.Size(143, 37);
            this.BTNexcel.TabIndex = 25;
            this.BTNexcel.Text = "CRIAR PLANILHA";
            this.BTNexcel.UseVisualStyleBackColor = false;
            this.BTNexcel.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLimg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.ComboBox CBconsulta;
        private System.Windows.Forms.Button BTNatu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TXTselect;
        public System.Windows.Forms.PictureBox pbSelect;
        private System.Windows.Forms.Button BTNexcel;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}