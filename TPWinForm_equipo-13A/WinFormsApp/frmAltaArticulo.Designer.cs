namespace WinFormsApp
{
    partial class frmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lbUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(105, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(100, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(70, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 25);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(110, 305);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 25);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtCodigo.Location = new System.Drawing.Point(175, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 25);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtNombre.Location = new System.Drawing.Point(175, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtDescripcion.Location = new System.Drawing.Point(175, 110);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 80);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtPrecio.Location = new System.Drawing.Point(175, 305);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 25);
            this.txtPrecio.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(15, 405);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 35);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(505, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 35);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMarca.Location = new System.Drawing.Point(110, 210);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 25);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategoria.Location = new System.Drawing.Point(85, 260);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 25);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(175, 210);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(160, 26);
            this.cboMarca.TabIndex = 7;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(175, 260);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(160, 26);
            this.cboCategoria.TabIndex = 9;
            // 
            // lbUrlImagen
            // 
            this.lbUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUrlImagen.Location = new System.Drawing.Point(15, 350);
            this.lbUrlImagen.Name = "lbUrlImagen";
            this.lbUrlImagen.Size = new System.Drawing.Size(152, 25);
            this.lbUrlImagen.TabIndex = 12;
            this.lbUrlImagen.Text = "URL - Imagen N°1:";
            this.lbUrlImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtUrlImagen.Location = new System.Drawing.Point(175, 350);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(415, 25);
            this.txtUrlImagen.TabIndex = 13;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(365, 260);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(225, 25);
            this.btnAgregarImagen.TabIndex = 16;
            this.btnAgregarImagen.Text = "Confirmar/Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImagen.Location = new System.Drawing.Point(365, 305);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(225, 25);
            this.btnEliminarImagen.TabIndex = 17;
            this.btnEliminarImagen.Text = "Eliminar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Image = global::WinFormsApp.Properties.Resources.flechaIzq;
            this.btnImagenAnterior.Location = new System.Drawing.Point(365, 120);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(25, 25);
            this.btnImagenAnterior.TabIndex = 14;
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Visible = false;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Image = global::WinFormsApp.Properties.Resources.flechaDer;
            this.btnImagenSiguiente.Location = new System.Drawing.Point(565, 120);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(25, 25);
            this.btnImagenSiguiente.TabIndex = 15;
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(365, 20);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(225, 225);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenArticulo.TabIndex = 13;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 451);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lbUrlImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lbUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
    }
}