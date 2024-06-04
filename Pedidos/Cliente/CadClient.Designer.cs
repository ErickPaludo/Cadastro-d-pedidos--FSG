namespace Pedidos
{
    partial class CadClient
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
            textcep = new MaskedTextBox();
            button1 = new Button();
            label2 = new Label();
            textname = new TextBox();
            textlogradouro = new TextBox();
            textbairro = new TextBox();
            textmuni = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            combouf = new ComboBox();
            buttonenv = new Button();
            textcnpj = new MaskedTextBox();
            textel = new MaskedTextBox();
            textnumber = new TextBox();
            label17 = new Label();
            nomefantasia = new TextBox();
            dataGridClient = new DataGridView();
            Column1d = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textcep
            // 
            textcep.Location = new Point(329, 167);
            textcep.Mask = "00,000-000";
            textcep.Name = "textcep";
            textcep.Size = new Size(104, 23);
            textcep.TabIndex = 93;
            // 
            // button1
            // 
            button1.Location = new Point(294, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 55;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BuscaCnpj;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 33);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 57;
            label2.Text = "CNPJ";
            // 
            // textname
            // 
            textname.Enabled = false;
            textname.Location = new Point(69, 100);
            textname.MaxLength = 80;
            textname.Name = "textname";
            textname.Size = new Size(360, 23);
            textname.TabIndex = 58;
            // 
            // textlogradouro
            // 
            textlogradouro.Location = new Point(103, 228);
            textlogradouro.Name = "textlogradouro";
            textlogradouro.Size = new Size(182, 23);
            textlogradouro.TabIndex = 67;
            // 
            // textbairro
            // 
            textbairro.Location = new Point(69, 199);
            textbairro.Name = "textbairro";
            textbairro.Size = new Size(216, 23);
            textbairro.TabIndex = 65;
            // 
            // textmuni
            // 
            textmuni.Location = new Point(89, 167);
            textmuni.Name = "textmuni";
            textmuni.Size = new Size(196, 23);
            textmuni.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 103);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 70;
            label3.Text = "Nome:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 232);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 73;
            label7.Text = "Logradouro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 232);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 74;
            label8.Text = "Numero:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 202);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 76;
            label10.Text = "Bairro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 170);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 77;
            label11.Text = "Município:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(292, 170);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 78;
            label12.Text = "CEP:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(301, 202);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 79;
            label13.Text = "UF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(150, 132);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 80;
            label14.Text = "Tel:";
            // 
            // combouf
            // 
            combouf.Cursor = Cursors.Hand;
            combouf.DropDownStyle = ComboBoxStyle.DropDownList;
            combouf.FormattingEnabled = true;
            combouf.ItemHeight = 15;
            combouf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            combouf.Location = new Point(329, 199);
            combouf.Name = "combouf";
            combouf.Size = new Size(104, 23);
            combouf.TabIndex = 66;
            // 
            // buttonenv
            // 
            buttonenv.Location = new Point(194, 254);
            buttonenv.Name = "buttonenv";
            buttonenv.Size = new Size(75, 31);
            buttonenv.TabIndex = 71;
            buttonenv.Text = "Gravar";
            buttonenv.UseVisualStyleBackColor = true;
            buttonenv.Click += Gravar;
            // 
            // textcnpj
            // 
            textcnpj.Location = new Point(180, 29);
            textcnpj.Mask = "##,###,###/####-##";
            textcnpj.Name = "textcnpj";
            textcnpj.Size = new Size(108, 23);
            textcnpj.TabIndex = 54;
            textcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textel
            // 
            textel.Location = new Point(180, 129);
            textel.Mask = "(99) 0000-0000";
            textel.Name = "textel";
            textel.Size = new Size(117, 23);
            textel.TabIndex = 62;
            // 
            // textnumber
            // 
            textnumber.Location = new Point(363, 229);
            textnumber.Name = "textnumber";
            textnumber.Size = new Size(70, 23);
            textnumber.TabIndex = 68;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 64);
            label17.Name = "label17";
            label17.Size = new Size(53, 30);
            label17.TabIndex = 92;
            label17.Text = "Nome \r\nFantasia:";
            // 
            // nomefantasia
            // 
            nomefantasia.Location = new Point(69, 71);
            nomefantasia.MaxLength = 80;
            nomefantasia.Name = "nomefantasia";
            nomefantasia.Size = new Size(360, 23);
            nomefantasia.TabIndex = 56;
            // 
            // dataGridClient
            // 
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Columns.AddRange(new DataGridViewColumn[] { Column1d, ColumnNome });
            dataGridClient.Location = new Point(12, 323);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.Size = new Size(451, 320);
            dataGridClient.TabIndex = 94;
            // 
            // Column1d
            // 
            Column1d.HeaderText = "Id";
            Column1d.Name = "Column1d";
            Column1d.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Cliente";
            ColumnNome.Name = "ColumnNome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nomefantasia);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textcep);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textnumber);
            groupBox1.Controls.Add(textname);
            groupBox1.Controls.Add(buttonenv);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(combouf);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textcnpj);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textbairro);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textlogradouro);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textmuni);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 291);
            groupBox1.TabIndex = 95;
            groupBox1.TabStop = false;
            // 
            // CadClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 655);
            Controls.Add(groupBox1);
            Controls.Add(dataGridClient);
            Name = "CadClient";
            Text = "CadClient";
            Load += CadClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaskedTextBox textcep;
        private Button button1;
        private Label label2;
        private TextBox textname;
        private TextBox textlogradouro;
        private TextBox textbairro;
        private TextBox textmuni;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox combouf;
        private Button buttonenv;
        private MaskedTextBox textcnpj;
        private MaskedTextBox textel;
        private TextBox textnumber;
        private Label label17;
        private TextBox nomefantasia;
        private DataGridView dataGridClient;
        private DataGridViewTextBoxColumn Column1d;
        private DataGridViewTextBoxColumn ColumnNome;
        private GroupBox groupBox1;
    }
}