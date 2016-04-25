namespace PiedraPapelTijeras
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rojo = new System.Windows.Forms.PictureBox();
            this.empate = new System.Windows.Forms.PictureBox();
            this.azul = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PiedraPapelTijeras.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(-60, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PiedraPapelTijeras.Properties.Resources._2_d;
            this.pictureBox2.Location = new System.Drawing.Point(211, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rojo
            // 
            this.rojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rojo.Image = global::PiedraPapelTijeras.Properties.Resources.ROJO_GANA;
            this.rojo.Location = new System.Drawing.Point(1, 372);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(140, 76);
            this.rojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rojo.TabIndex = 2;
            this.rojo.TabStop = false;
            this.rojo.Click += new System.EventHandler(this.Verificar);
            // 
            // empate
            // 
            this.empate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empate.Image = global::PiedraPapelTijeras.Properties.Resources.EMPATE;
            this.empate.Location = new System.Drawing.Point(146, 372);
            this.empate.Name = "empate";
            this.empate.Size = new System.Drawing.Size(140, 76);
            this.empate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empate.TabIndex = 3;
            this.empate.TabStop = false;
            this.empate.Click += new System.EventHandler(this.Verificar);
            // 
            // azul
            // 
            this.azul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.azul.Image = global::PiedraPapelTijeras.Properties.Resources.AZULGANA;
            this.azul.Location = new System.Drawing.Point(288, 372);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(140, 76);
            this.azul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.azul.TabIndex = 4;
            this.azul.TabStop = false;
            this.azul.Click += new System.EventHandler(this.Verificar);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(-2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puntos";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblPuntos.Location = new System.Drawing.Point(45, 60);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(43, 42);
            this.lblPuntos.TabIndex = 8;
            this.lblPuntos.Text = "0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblTiempo.Location = new System.Drawing.Point(300, 25);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(33, 35);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiedraPapelTijeras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(429, 446);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.azul);
            this.Controls.Add(this.empate);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox rojo;
        private System.Windows.Forms.PictureBox empate;
        private System.Windows.Forms.PictureBox azul;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblTiempo;
    }
}

