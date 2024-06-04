namespace Pedidos
{
    partial class CadItem
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
            label1 = new Label();
            tNome = new TextBox();
            tPreco = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dataGridItem = new DataGridView();
            Column1d = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridItem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tNome
            // 
            tNome.Location = new Point(12, 24);
            tNome.Name = "tNome";
            tNome.Size = new Size(346, 23);
            tNome.TabIndex = 1;
            // 
            // tPreco
            // 
            tPreco.Location = new Point(12, 68);
            tPreco.Name = "tPreco";
            tPreco.PlaceholderText = "R$00,00";
            tPreco.Size = new Size(346, 23);
            tPreco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Preco";
            // 
            // button1
            // 
            button1.Location = new Point(125, 97);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Cadastrar;
            // 
            // dataGridItem
            // 
            dataGridItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItem.Columns.AddRange(new DataGridViewColumn[] { Column1d, ColumnNome, ColumnPreco });
            dataGridItem.Location = new Point(12, 126);
            dataGridItem.Name = "dataGridItem";
            dataGridItem.Size = new Size(346, 342);
            dataGridItem.TabIndex = 5;
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
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preco";
            ColumnPreco.Name = "ColumnPreco";
            // 
            // CadItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 480);
            Controls.Add(dataGridItem);
            Controls.Add(button1);
            Controls.Add(tPreco);
            Controls.Add(label2);
            Controls.Add(tNome);
            Controls.Add(label1);
            Name = "CadItem";
            Text = "CadItem";
            ((System.ComponentModel.ISupportInitialize)dataGridItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tNome;
        private TextBox tPreco;
        private Label label2;
        private Button button1;
        private DataGridView dataGridItem;
        private DataGridViewTextBoxColumn Column1d;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnPreco;
    }
}