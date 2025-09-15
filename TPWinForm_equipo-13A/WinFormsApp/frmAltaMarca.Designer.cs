namespace WinFormsApp
{
    partial class frmAltaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaMarca));
            this.lbNuevaMarca = new System.Windows.Forms.Label();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.lbModifMarca = new System.Windows.Forms.Label();
            this.cboModifMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNuevaMarca
            // 
            this.lbNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNuevaMarca.Location = new System.Drawing.Point(15, 55);
            this.lbNuevaMarca.Name = "lbNuevaMarca";
            this.lbNuevaMarca.Size = new System.Drawing.Size(240, 25);
            this.lbNuevaMarca.TabIndex = 2;
            this.lbNuevaMarca.Text = "Nombre de la nueva Marca:";
            this.lbNuevaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.txtNuevaMarca.Location = new System.Drawing.Point(270, 55);
            this.txtNuevaMarca.MaxLength = 50;
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(320, 25);
            this.txtNuevaMarca.TabIndex = 3;
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptarMarca.BackColor = System.Drawing.Color.Lime;
            this.btnAceptarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptarMarca.Location = new System.Drawing.Point(16, 96);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(85, 35);
            this.btnAceptarMarca.TabIndex = 4;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = false;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarMarca.BackColor = System.Drawing.Color.Red;
            this.btnCancelarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarMarca.Location = new System.Drawing.Point(506, 96);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(85, 35);
            this.btnCancelarMarca.TabIndex = 5;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // lbModifMarca
            // 
            this.lbModifMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbModifMarca.Location = new System.Drawing.Point(15, 15);
            this.lbModifMarca.Name = "lbModifMarca";
            this.lbModifMarca.Size = new System.Drawing.Size(240, 25);
            this.lbModifMarca.TabIndex = 0;
            this.lbModifMarca.Text = "Nombre de la Marca a modificar:";
            this.lbModifMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboModifMarca
            // 
            this.cboModifMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModifMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModifMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.cboModifMarca.FormattingEnabled = true;
            this.cboModifMarca.Location = new System.Drawing.Point(270, 15);
            this.cboModifMarca.Name = "cboModifMarca";
            this.cboModifMarca.Size = new System.Drawing.Size(320, 26);
            this.cboModifMarca.TabIndex = 1;
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 141);
            this.Controls.Add(this.cboModifMarca);
            this.Controls.Add(this.lbModifMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lbNuevaMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Marca";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNuevaMarca;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Label lbModifMarca;
        private System.Windows.Forms.ComboBox cboModifMarca;
    }
}