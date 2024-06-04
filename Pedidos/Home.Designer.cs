namespace Pedidos
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            toolTip = new ToolTip(components);
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            adicionaItemToolStripMenuItem = new ToolStripMenuItem();
            adicionaClienteToolStripMenuItem = new ToolStripMenuItem();
            adicionaPedidoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { operaçõesToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionaItemToolStripMenuItem, adicionaClienteToolStripMenuItem, adicionaPedidoToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // adicionaItemToolStripMenuItem
            // 
            adicionaItemToolStripMenuItem.Name = "adicionaItemToolStripMenuItem";
            adicionaItemToolStripMenuItem.Size = new Size(180, 22);
            adicionaItemToolStripMenuItem.Text = "Adiciona Item";
            adicionaItemToolStripMenuItem.Click += AddItem;
            // 
            // adicionaClienteToolStripMenuItem
            // 
            adicionaClienteToolStripMenuItem.Name = "adicionaClienteToolStripMenuItem";
            adicionaClienteToolStripMenuItem.Size = new Size(180, 22);
            adicionaClienteToolStripMenuItem.Text = "Adiciona Cliente";
            adicionaClienteToolStripMenuItem.Click += AddClient;
            // 
            // adicionaPedidoToolStripMenuItem
            // 
            adicionaPedidoToolStripMenuItem.Name = "adicionaPedidoToolStripMenuItem";
            adicionaPedidoToolStripMenuItem.Size = new Size(161, 22);
            adicionaPedidoToolStripMenuItem.Text = "Adiciona Pedido";
            adicionaPedidoToolStripMenuItem.Click += AddPedido;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem adicionaItemToolStripMenuItem;
        private ToolStripMenuItem adicionaClienteToolStripMenuItem;
        private ToolStripMenuItem adicionaPedidoToolStripMenuItem;
    }
}



