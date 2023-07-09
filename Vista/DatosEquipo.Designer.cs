namespace Vista
{
    partial class DatosEquipo
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
            this.txb_modelo = new System.Windows.Forms.TextBox();
            this.txb_serie = new System.Windows.Forms.TextBox();
            this.txb_imei = new System.Windows.Forms.TextBox();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.btn_cargarEquipo = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_modelo
            // 
            this.txb_modelo.BackColor = System.Drawing.Color.Black;
            this.txb_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_modelo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txb_modelo.Location = new System.Drawing.Point(47, 79);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.PlaceholderText = "Modelo";
            this.txb_modelo.Size = new System.Drawing.Size(275, 20);
            this.txb_modelo.TabIndex = 66;
            // 
            // txb_serie
            // 
            this.txb_serie.BackColor = System.Drawing.Color.Black;
            this.txb_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_serie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txb_serie.Location = new System.Drawing.Point(47, 29);
            this.txb_serie.Name = "txb_serie";
            this.txb_serie.PlaceholderText = "Serie";
            this.txb_serie.Size = new System.Drawing.Size(275, 20);
            this.txb_serie.TabIndex = 65;
            // 
            // txb_imei
            // 
            this.txb_imei.BackColor = System.Drawing.Color.Black;
            this.txb_imei.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_imei.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txb_imei.Location = new System.Drawing.Point(47, 177);
            this.txb_imei.Name = "txb_imei";
            this.txb_imei.PlaceholderText = "Imei";
            this.txb_imei.Size = new System.Drawing.Size(275, 20);
            this.txb_imei.TabIndex = 64;
            // 
            // txb_id
            // 
            this.txb_id.BackColor = System.Drawing.Color.Black;
            this.txb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txb_id.Location = new System.Drawing.Point(47, 128);
            this.txb_id.Name = "txb_id";
            this.txb_id.PlaceholderText = "ID ";
            this.txb_id.Size = new System.Drawing.Size(275, 20);
            this.txb_id.TabIndex = 63;
            // 
            // btn_cargarEquipo
            // 
            this.btn_cargarEquipo.Location = new System.Drawing.Point(34, 235);
            this.btn_cargarEquipo.Name = "btn_cargarEquipo";
            this.btn_cargarEquipo.Size = new System.Drawing.Size(121, 28);
            this.btn_cargarEquipo.TabIndex = 62;
            this.btn_cargarEquipo.Text = "Cancelar";
            this.btn_cargarEquipo.UseVisualStyleBackColor = true;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(218, 235);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(148, 28);
            this.btn_cargar.TabIndex = 67;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // DatosEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(405, 299);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.txb_modelo);
            this.Controls.Add(this.txb_serie);
            this.Controls.Add(this.txb_imei);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.btn_cargarEquipo);
            this.Name = "DatosEquipo";
            this.Text = "Datos Equipo";
            this.Load += new System.EventHandler(this.DatosEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_modelo;
        private System.Windows.Forms.TextBox txb_serie;
        private System.Windows.Forms.TextBox txb_imei;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Button btn_cargarEquipo;
        private System.Windows.Forms.Button btn_cargar;
    }
}