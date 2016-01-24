namespace YoutubePlayercsharp
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
            this.dtgListaVideos = new System.Windows.Forms.DataGridView();
            this.PlayerYoutube = new System.Windows.Forms.WebBrowser();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaVideos
            // 
            this.dtgListaVideos.AllowUserToAddRows = false;
            this.dtgListaVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Imagen,
            this.Nombre});
            this.dtgListaVideos.Location = new System.Drawing.Point(12, 298);
            this.dtgListaVideos.Name = "dtgListaVideos";
            this.dtgListaVideos.RowTemplate.Height = 50;
            this.dtgListaVideos.Size = new System.Drawing.Size(529, 152);
            this.dtgListaVideos.TabIndex = 0;
            this.dtgListaVideos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgListaVideos_CellMouseClick);
            // 
            // PlayerYoutube
            // 
            this.PlayerYoutube.Location = new System.Drawing.Point(12, 12);
            this.PlayerYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.PlayerYoutube.Name = "PlayerYoutube";
            this.PlayerYoutube.Size = new System.Drawing.Size(529, 262);
            this.PlayerYoutube.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.Name = "Imagen";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 462);
            this.Controls.Add(this.PlayerYoutube);
            this.Controls.Add(this.dtgListaVideos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaVideos;
        private System.Windows.Forms.WebBrowser PlayerYoutube;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;

    }
}

