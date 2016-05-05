namespace JuegoMarmota
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
            this.panelJuego = new System.Windows.Forms.TableLayoutPanel();
            this.pbxatrapame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblFallas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.ColumnCount = 3;
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.panelJuego.Location = new System.Drawing.Point(139, 114);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.RowCount = 3;
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelJuego.Size = new System.Drawing.Size(331, 263);
            this.panelJuego.TabIndex = 0;
            // 
            // pbxatrapame
            // 
            this.pbxatrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxatrapame.Image = global::JuegoMarmota.Properties.Resources.a1;
            this.pbxatrapame.Location = new System.Drawing.Point(476, 167);
            this.pbxatrapame.Name = "pbxatrapame";
            this.pbxatrapame.Size = new System.Drawing.Size(132, 130);
            this.pbxatrapame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxatrapame.TabIndex = 1;
            this.pbxatrapame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puntos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fallas";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntos.Location = new System.Drawing.Point(51, 190);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(30, 31);
            this.lblPuntos.TabIndex = 8;
            this.lblPuntos.Text = "0";
            // 
            // lblFallas
            // 
            this.lblFallas.AutoSize = true;
            this.lblFallas.BackColor = System.Drawing.Color.Transparent;
            this.lblFallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFallas.Location = new System.Drawing.Point(51, 300);
            this.lblFallas.Name = "lblFallas";
            this.lblFallas.Size = new System.Drawing.Size(30, 31);
            this.lblFallas.TabIndex = 9;
            this.lblFallas.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoMarmota.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.lblFallas);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxatrapame);
            this.Controls.Add(this.panelJuego);
            this.Name = "Form1";
            this.Text = "Aplasta a la Marmota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelJuego;
        private System.Windows.Forms.PictureBox pbxatrapame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblFallas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

