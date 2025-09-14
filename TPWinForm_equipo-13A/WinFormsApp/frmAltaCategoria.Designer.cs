namespace WinFormsApp
{
    partial class frmAltaCategoria
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
            this.cboModifCategoria = new System.Windows.Forms.ComboBox();
            this.lbModifCategoria = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lbNuevaCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboModifCategoria
            // 
            this.cboModifCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModifCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.cboModifCategoria.FormattingEnabled = true;
            this.cboModifCategoria.Location = new System.Drawing.Point(290, 15);
            this.cboModifCategoria.Name = "cboModifCategoria";
            this.cboModifCategoria.Size = new System.Drawing.Size(300, 26);
            this.cboModifCategoria.TabIndex = 1;
            // 
            // lbModifCategoria
            // 
            this.lbModifCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbModifCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbModifCategoria.Location = new System.Drawing.Point(15, 15);
            this.lbModifCategoria.Name = "lbModifCategoria";
            this.lbModifCategoria.Size = new System.Drawing.Size(260, 25);
            this.lbModifCategoria.TabIndex = 0;
            this.lbModifCategoria.Text = "Nombre de la categoría a modificar:";
            this.lbModifCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.Color.Red;
            this.btnCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCategoria.Location = new System.Drawing.Point(506, 96);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(85, 35);
            this.btnCancelarCategoria.TabIndex = 5;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.BackColor = System.Drawing.Color.Lime;
            this.btnAceptarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptarCategoria.Location = new System.Drawing.Point(16, 96);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(85, 35);
            this.btnAceptarCategoria.TabIndex = 4;
            this.btnAceptarCategoria.Text = "Aceptar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = false;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtNuevaCategoria.Location = new System.Drawing.Point(290, 55);
            this.txtNuevaCategoria.MaxLength = 50;
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(300, 25);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // lbNuevaCategoria
            // 
            this.lbNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNuevaCategoria.Location = new System.Drawing.Point(15, 55);
            this.lbNuevaCategoria.Name = "lbNuevaCategoria";
            this.lbNuevaCategoria.Size = new System.Drawing.Size(260, 25);
            this.lbNuevaCategoria.TabIndex = 2;
            this.lbNuevaCategoria.Text = "Nombre de la nueva categoría:";
            this.lbNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 141);
            this.Controls.Add(this.cboModifCategoria);
            this.Controls.Add(this.lbModifCategoria);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lbNuevaCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAltaCategoria";
            this.Text = "frmAltaCategoria.Text";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboModifCategoria;
        private System.Windows.Forms.Label lbModifCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Label lbNuevaCategoria;
    }
}