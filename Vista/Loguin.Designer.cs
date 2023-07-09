
namespace Vista
{
    partial class Loguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(98, 104);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(431, 23);
            this.txb_usuario.TabIndex = 0;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(98, 159);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.PasswordChar = '*';
            this.txb_clave.Size = new System.Drawing.Size(431, 23);
            this.txb_clave.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ingresar.BackColor = System.Drawing.Color.Black;
            this.btn_ingresar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.Location = new System.Drawing.Point(402, 246);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(148, 41);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_salir.Location = new System.Drawing.Point(98, 246);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(124, 41);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_autocompletar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_autocompletar.Location = new System.Drawing.Point(245, 210);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(135, 23);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = false;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_titulo.Location = new System.Drawing.Point(191, 39);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(247, 36);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Micro Mobile";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(260, 246);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 39);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 371);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_autocompletar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

