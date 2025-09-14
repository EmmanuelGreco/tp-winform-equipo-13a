using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmAltaMarca : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        string altaModif;
        
        public frmAltaMarca(string altaModif)
        {
            InitializeComponent();
            configVisual(altaModif);        //Acomoda los controles y cambia el nombre del form segun el modo elegido.
            this.altaModif = altaModif;
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

            cboModifMarca.DataSource = marcaNegocio.listar();
            cboModifMarca.ValueMember = "Id";
            cboModifMarca.DisplayMember = "Descripcion";
        }

        private void configVisual(string altaModif)
        {
            if (altaModif == "alta")
            {
                Text = "Nueva Marca";
                lbModifMarca.Visible = false;
                cboModifMarca.Visible = false;
                lbNuevaMarca.Location = new Point(15, 35);
                txtNuevaMarca.Location = new Point(255, 35);
            }
            else if (altaModif == "modificar")
            {
                Text = "Modificar Marca";
                lbNuevaMarca.Text = "Nuevo nombre de la marca:";
            } 
            else if (altaModif == "baja")
            {
                Text = "Eliminar Marca";
                lbModifMarca.Text = "Nombre de la marca a eliminar:";
                lbNuevaMarca.Visible = false;
                txtNuevaMarca.Visible = false;
                lbModifMarca.Location = new Point(15, 35);
                cboModifMarca.Location = new Point(255, 35);
            }
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            string nuevaMarca = txtNuevaMarca.Text;
            
            if (altaModif == "alta") 
            {
                nuevaMarca = validarEntrada(nuevaMarca, 0);
                //Si el texto no es vacio, y no existe previamente en la BD, agregarlo.
                if (nuevaMarca != "")
                    marcaNegocio.agregar(nuevaMarca);
                else
                    return;                
                Close();
            } 
            else if (altaModif == "modificar")
            {
                int idMarca = (int)cboModifMarca.SelectedValue;
                nuevaMarca = validarEntrada(nuevaMarca, idMarca);
                if (nuevaMarca != "")
                    marcaNegocio.modificar(idMarca, nuevaMarca);
                else
                    return;
                Close();
            }
            else if (altaModif == "baja")
            {
                int idMarca = (int)cboModifMarca.SelectedValue;
                if (!marcaNegocio.eliminar(idMarca))
                {
                    MessageBox.Show("Esta marca está en uso! No pueden eliminarse marcas ligadas a artículos existentes.", "Aviso!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Close();
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string validarEntrada(string nuevaMarca, int idMarca)
        {
            //Si el texto está vacio, avisar y retornar.
            if (nuevaMarca == null || nuevaMarca.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un texto valido!", "Aviso!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            //Si es válido, le sacamos los espacios extra.
            nuevaMarca = nuevaMarca.Trim();

            //Si ya existe la marca, no te va a dejar.
            if (marcaNegocio.existe(nuevaMarca, idMarca))
            {
                MessageBox.Show("La marca ingresada ya existe! Ingrese una marca diferente!", "Aviso!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return nuevaMarca;
        }
    }
}
