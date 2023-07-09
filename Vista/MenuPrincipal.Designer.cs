namespace Vista
{
    partial class MenuPrincipal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_crearTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotoRobadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviosMetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraviadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.planillasToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_crearTicket});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // mnt_crearTicket
            // 
            this.mnt_crearTicket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotoToolStripMenuItem,
            this.robadoToolStripMenuItem,
            this.extraviadoToolStripMenuItem});
            this.mnt_crearTicket.Name = "mnt_crearTicket";
            this.mnt_crearTicket.Size = new System.Drawing.Size(180, 22);
            this.mnt_crearTicket.Text = "Crear Ticket";
            this.mnt_crearTicket.Click += new System.EventHandler(this.mnt_crearTicket_Click);
            // 
            // planillasToolStripMenuItem
            // 
            this.planillasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.garantiaToolStripMenuItem,
            this.rotoRobadoToolStripMenuItem,
            this.enviosMetroToolStripMenuItem});
            this.planillasToolStripMenuItem.Name = "planillasToolStripMenuItem";
            this.planillasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.planillasToolStripMenuItem.Text = "Planillas";
            // 
            // garantiaToolStripMenuItem
            // 
            this.garantiaToolStripMenuItem.Name = "garantiaToolStripMenuItem";
            this.garantiaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.garantiaToolStripMenuItem.Text = "Garantia";
            // 
            // rotoRobadoToolStripMenuItem
            // 
            this.rotoRobadoToolStripMenuItem.Name = "rotoRobadoToolStripMenuItem";
            this.rotoRobadoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rotoRobadoToolStripMenuItem.Text = "Roto-Robado";
            // 
            // enviosMetroToolStripMenuItem
            // 
            this.enviosMetroToolStripMenuItem.Name = "enviosMetroToolStripMenuItem";
            this.enviosMetroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.enviosMetroToolStripMenuItem.Text = "Envios Metro";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rotoToolStripMenuItem
            // 
            this.rotoToolStripMenuItem.Name = "rotoToolStripMenuItem";
            this.rotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotoToolStripMenuItem.Text = "Roto";
            // 
            // robadoToolStripMenuItem
            // 
            this.robadoToolStripMenuItem.Name = "robadoToolStripMenuItem";
            this.robadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.robadoToolStripMenuItem.Text = "Robado";
            // 
            // extraviadoToolStripMenuItem
            // 
            this.extraviadoToolStripMenuItem.Name = "extraviadoToolStripMenuItem";
            this.extraviadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extraviadoToolStripMenuItem.Text = "Extraviado";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnt_crearTicket;
        private System.Windows.Forms.ToolStripMenuItem planillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotoRobadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviosMetroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraviadoToolStripMenuItem;
    }
}