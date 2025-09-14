namespace WinFormsApp
{
    partial class frmArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloAgregarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloModificarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloEliminarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaAgregarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaModificarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaEliminarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaAgregarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaModificarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaEliminarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 40);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(880, 200);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloAgregarTSMenuItem,
            this.articuloModificarTSMenuItem,
            this.articuloEliminarTSMenuItem});
            this.artículosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // articuloAgregarTSMenuItem
            // 
            this.articuloAgregarTSMenuItem.Name = "articuloAgregarTSMenuItem";
            this.articuloAgregarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.articuloAgregarTSMenuItem.Text = "Agregar";
            this.articuloAgregarTSMenuItem.Click += new System.EventHandler(this.articuloAgregarTSMenuItem_Click);
            // 
            // articuloModificarTSMenuItem
            // 
            this.articuloModificarTSMenuItem.Name = "articuloModificarTSMenuItem";
            this.articuloModificarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.articuloModificarTSMenuItem.Text = "Modificar";
            this.articuloModificarTSMenuItem.Click += new System.EventHandler(this.articuloModificarTSMenuItem_Click);
            // 
            // articuloEliminarTSMenuItem
            // 
            this.articuloEliminarTSMenuItem.Name = "articuloEliminarTSMenuItem";
            this.articuloEliminarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.articuloEliminarTSMenuItem.Text = "Eliminar";
            this.articuloEliminarTSMenuItem.Click += new System.EventHandler(this.articuloEliminarTSMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaAgregarTSMenuItem,
            this.marcaModificarTSMenuItem,
            this.marcaEliminarTSMenuItem});
            this.marcasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // marcaAgregarTSMenuItem
            // 
            this.marcaAgregarTSMenuItem.Name = "marcaAgregarTSMenuItem";
            this.marcaAgregarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.marcaAgregarTSMenuItem.Text = "Agregar";
            this.marcaAgregarTSMenuItem.Click += new System.EventHandler(this.marcaAgregarTSMenuItem_Click);
            // 
            // marcaModificarTSMenuItem
            // 
            this.marcaModificarTSMenuItem.Name = "marcaModificarTSMenuItem";
            this.marcaModificarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.marcaModificarTSMenuItem.Text = "Modificar";
            this.marcaModificarTSMenuItem.Click += new System.EventHandler(this.marcaModificarTSMenuItem_Click);
            // 
            // marcaEliminarTSMenuItem
            // 
            this.marcaEliminarTSMenuItem.Name = "marcaEliminarTSMenuItem";
            this.marcaEliminarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.marcaEliminarTSMenuItem.Text = "Eliminar";
            this.marcaEliminarTSMenuItem.Click += new System.EventHandler(this.marcaEliminarTSMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaAgregarTSMenuItem,
            this.categoriaModificarTSMenuItem,
            this.categoriaEliminarTSMenuItem});
            this.categoríasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // categoriaAgregarTSMenuItem
            // 
            this.categoriaAgregarTSMenuItem.Name = "categoriaAgregarTSMenuItem";
            this.categoriaAgregarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.categoriaAgregarTSMenuItem.Text = "Agregar";
            this.categoriaAgregarTSMenuItem.Click += new System.EventHandler(this.categoriaAgregarTSMenuItem_Click);
            // 
            // categoriaModificarTSMenuItem
            // 
            this.categoriaModificarTSMenuItem.Name = "categoriaModificarTSMenuItem";
            this.categoriaModificarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.categoriaModificarTSMenuItem.Text = "Modificar";
            this.categoriaModificarTSMenuItem.Click += new System.EventHandler(this.categoriaModificarTSMenuItem_Click);
            // 
            // categoriaEliminarTSMenuItem
            // 
            this.categoriaEliminarTSMenuItem.Name = "categoriaEliminarTSMenuItem";
            this.categoriaEliminarTSMenuItem.Size = new System.Drawing.Size(135, 24);
            this.categoriaEliminarTSMenuItem.Text = "Eliminar";
            this.categoriaEliminarTSMenuItem.Click += new System.EventHandler(this.categoriaEliminarTSMenuItem_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Image = global::WinFormsApp.Properties.Resources.flechaDer;
            this.btnImagenSiguiente.Location = new System.Drawing.Point(285, 385);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(30, 30);
            this.btnImagenSiguiente.TabIndex = 12;
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Image = global::WinFormsApp.Properties.Resources.flechaIzq;
            this.btnImagenAnterior.Location = new System.Drawing.Point(15, 385);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(30, 30);
            this.btnImagenAnterior.TabIndex = 11;
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Visible = false;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(15, 250);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(300, 300);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenArticulo.TabIndex = 1;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(576, 5);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(43, 17);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(625, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(175, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(806, 3);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(91, 22);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitulo.Location = new System.Drawing.Point(350, 325);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(545, 65);
            this.lbTitulo.TabIndex = 8;
            this.lbTitulo.Text = "Ningún artículo para mostrar!";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbDescripcion.Location = new System.Drawing.Point(355, 440);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(540, 100);
            this.lbDescripcion.TabIndex = 10;
            this.lbDescripcion.Text = "Debe contar con al menos una marca y una categoría para poder añadir un artículo." +
    "";
            // 
            // lbPrecio
            // 
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbPrecio.Location = new System.Drawing.Point(350, 395);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(545, 35);
            this.lbPrecio.TabIndex = 9;
            // 
            // lbCodigo
            // 
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbCodigo.Location = new System.Drawing.Point(355, 305);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(540, 20);
            this.lbCodigo.TabIndex = 7;
            // 
            // lbMarca
            // 
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMarca.Location = new System.Drawing.Point(355, 255);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(265, 40);
            this.lbMarca.TabIndex = 5;
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCategoria.Location = new System.Drawing.Point(630, 255);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(265, 40);
            this.lbCategoria.TabIndex = 6;
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 566);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloAgregarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloModificarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloEliminarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ToolStripMenuItem marcaAgregarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaModificarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaEliminarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaAgregarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaModificarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaEliminarTSMenuItem;
    }
}

