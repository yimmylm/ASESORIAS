namespace GrabadorSonido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Micro = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new System.Windows.Forms.PictureBox();
            this.btnParar = new System.Windows.Forms.PictureBox();
            this.btnReproducir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UrlReproductor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Micro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).BeginInit();
            this.SuspendLayout();
            // 
            // Micro
            // 
            this.Micro.Image = global::GrabadorSonido.Properties.Resources.MicroOff;
            this.Micro.Location = new System.Drawing.Point(-5, 30);
            this.Micro.Name = "Micro";
            this.Micro.Size = new System.Drawing.Size(256, 256);
            this.Micro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Micro.TabIndex = 0;
            this.Micro.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::GrabadorSonido.Properties.Resources.Record;
            this.btnGrabar.Location = new System.Drawing.Point(13, 292);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(70, 70);
            this.btnGrabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.TabStop = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Image = global::GrabadorSonido.Properties.Resources.Stopoff;
            this.btnParar.Location = new System.Drawing.Point(89, 292);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(70, 70);
            this.btnParar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnParar.TabIndex = 2;
            this.btnParar.TabStop = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Image = global::GrabadorSonido.Properties.Resources.playoff;
            this.btnReproducir.Location = new System.Drawing.Point(165, 292);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(70, 70);
            this.btnReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReproducir.TabIndex = 3;
            this.btnReproducir.TabStop = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grabar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reproducir";
            // 
            // UrlReproductor
            // 
            this.UrlReproductor.AutoSize = true;
            this.UrlReproductor.Location = new System.Drawing.Point(13, 11);
            this.UrlReproductor.Name = "UrlReproductor";
            this.UrlReproductor.Size = new System.Drawing.Size(0, 13);
            this.UrlReproductor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 382);
            this.Controls.Add(this.UrlReproductor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.Micro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grabador de sonido";
            ((System.ComponentModel.ISupportInitialize)(this.Micro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Micro;
        private System.Windows.Forms.PictureBox btnGrabar;
        private System.Windows.Forms.PictureBox btnParar;
        private System.Windows.Forms.PictureBox btnReproducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UrlReproductor;
    }
}

