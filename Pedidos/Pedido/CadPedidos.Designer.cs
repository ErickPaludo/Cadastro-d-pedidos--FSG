namespace Pedidos
{
    partial class CadPedidos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelClient = new Label();
            dataGridClient = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCnpj = new DataGridViewTextBoxColumn();
            ColumnCidade = new DataGridViewTextBoxColumn();
            ColumnUF = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGriditemSelecionado = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            dataGridItem = new DataGridView();
            Column1d = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            button2 = new Button();
            textBoxPesq = new TextBox();
            dataGridViewPItens = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridPedidos = new DataGridView();
            Column = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ColumnEdit = new DataGridViewButtonColumn();
            ColumnRem = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriditemSelecionado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItem).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelClient);
            tabPage1.Controls.Add(dataGridClient);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Selecionar Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(6, 14);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(113, 15);
            labelClient.TabIndex = 1;
            labelClient.Text = "Cliente selecionado:";
            // 
            // dataGridClient
            // 
            dataGridClient.AllowUserToAddRows = false;
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCnpj, ColumnCidade, ColumnUF });
            dataGridClient.Location = new Point(6, 32);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.ReadOnly = true;
            dataGridClient.Size = new Size(896, 380);
            dataGridClient.TabIndex = 0;
            dataGridClient.CellClick += SelecionaCliente;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Cliente";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            ColumnCnpj.HeaderText = "Cnpj";
            ColumnCnpj.Name = "ColumnCnpj";
            ColumnCnpj.ReadOnly = true;
            ColumnCnpj.Width = 150;
            // 
            // ColumnCidade
            // 
            ColumnCidade.HeaderText = "Cidade";
            ColumnCidade.Name = "ColumnCidade";
            ColumnCidade.ReadOnly = true;
            // 
            // ColumnUF
            // 
            ColumnUF.HeaderText = "UF";
            ColumnUF.Name = "ColumnUF";
            ColumnUF.ReadOnly = true;
            ColumnUF.Width = 50;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGriditemSelecionado);
            tabPage2.Controls.Add(dataGridItem);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Selecionar Item";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(812, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CadastraPedido;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 3);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 12;
            label2.Text = "Itens no Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 11;
            label1.Text = "Pedidos em estoque";
            // 
            // dataGriditemSelecionado
            // 
            dataGriditemSelecionado.AllowUserToAddRows = false;
            dataGriditemSelecionado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriditemSelecionado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, ColumnQuantidade });
            dataGriditemSelecionado.Location = new Point(394, 21);
            dataGriditemSelecionado.Name = "dataGriditemSelecionado";
            dataGriditemSelecionado.Size = new Size(512, 338);
            dataGriditemSelecionado.TabIndex = 10;
            dataGriditemSelecionado.CellDoubleClick += SelecionaItemPedido;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nome";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Preco";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            // 
            // dataGridItem
            // 
            dataGridItem.AllowUserToAddRows = false;
            dataGridItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItem.Columns.AddRange(new DataGridViewColumn[] { Column1d, dataGridViewTextBoxColumn1, ColumnPreco });
            dataGridItem.Location = new Point(0, 21);
            dataGridItem.Name = "dataGridItem";
            dataGridItem.ReadOnly = true;
            dataGridItem.Size = new Size(388, 338);
            dataGridItem.TabIndex = 9;
            dataGridItem.CellClick += SelecionaItem;
            // 
            // Column1d
            // 
            Column1d.HeaderText = "Id";
            Column1d.Name = "Column1d";
            Column1d.ReadOnly = true;
            Column1d.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preco";
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(textBoxPesq);
            tabPage3.Controls.Add(dataGridViewPItens);
            tabPage3.Controls.Add(dataGridPedidos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(918, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consultar Pedidos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(87, 29);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PesquisarPedido;
            // 
            // textBoxPesq
            // 
            textBoxPesq.Location = new Point(6, 29);
            textBoxPesq.Name = "textBoxPesq";
            textBoxPesq.Size = new Size(75, 23);
            textBoxPesq.TabIndex = 2;
            // 
            // dataGridViewPItens
            // 
            dataGridViewPItens.AllowUserToAddRows = false;
            dataGridViewPItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPItens.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column1, Column3 });
            dataGridViewPItens.Location = new Point(344, 71);
            dataGridViewPItens.Name = "dataGridViewPItens";
            dataGridViewPItens.ReadOnly = true;
            dataGridViewPItens.Size = new Size(568, 341);
            dataGridViewPItens.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Item";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Quantidade";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Preço";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.AllowUserToAddRows = false;
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Columns.AddRange(new DataGridViewColumn[] { Column, Column2, ColumnEdit, ColumnRem });
            dataGridPedidos.Location = new Point(6, 71);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.ReadOnly = true;
            dataGridPedidos.Size = new Size(332, 341);
            dataGridPedidos.TabIndex = 0;
            dataGridPedidos.CellContentClick += BotoesTabela;
            dataGridPedidos.CellDoubleClick += SelecionaPedido;
            // 
            // Column
            // 
            Column.HeaderText = "Id";
            Column.Name = "Column";
            Column.ReadOnly = true;
            Column.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Cliente";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            ColumnEdit.HeaderText = "Edit";
            ColumnEdit.Name = "ColumnEdit";
            ColumnEdit.ReadOnly = true;
            ColumnEdit.Resizable = DataGridViewTriState.True;
            ColumnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnEdit.Width = 40;
            // 
            // ColumnRem
            // 
            ColumnRem.HeaderText = "Rem";
            ColumnRem.Name = "ColumnRem";
            ColumnRem.ReadOnly = true;
            ColumnRem.Width = 40;
            // 
            // CadPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(tabControl1);
            Name = "CadPedidos";
            Text = "CadPedidos";
            FormClosed += DefaultId;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriditemSelecionado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItem).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridClient;
        private TabPage tabPage2;
        private Label labelClient;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCnpj;
        private DataGridViewTextBoxColumn ColumnCidade;
        private DataGridViewTextBoxColumn ColumnUF;
        private DataGridView dataGriditemSelecionado;
        private DataGridView dataGridItem;
        private DataGridViewTextBoxColumn Column1d;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnPreco;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private Label label2;
        private Label label1;
        private Button button1;
        private TabPage tabPage3;
        private DataGridView dataGridPedidos;
        private DataGridView dataGridViewPItens;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private Button button2;
        private TextBox textBoxPesq;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnRem;
    }
}