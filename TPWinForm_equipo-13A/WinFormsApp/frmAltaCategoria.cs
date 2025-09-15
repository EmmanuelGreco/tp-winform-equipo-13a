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
    public partial class frmAltaCategoria : Form
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        string modoABM;

        public frmAltaCategoria(string modoABM)
        {
            InitializeComponent();
            configVisual(modoABM);        //Acomoda los controles y cambia el nombre del form segun el modo elegido.
            this.modoABM = modoABM;
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

            cboModifCategoria.DataSource = categoriaNegocio.listar();
            cboModifCategoria.ValueMember = "Id";
            cboModifCategoria.DisplayMember = "Descripcion";
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            string nuevaCategoria = txtNuevaCategoria.Text;

            if (modoABM == "alta")
            {
                nuevaCategoria = validarEntrada(nuevaCategoria, 0);
                //Si el texto no es vacio, y no existe previamente en la BD, agregarlo.
                if (nuevaCategoria != "")
                    categoriaNegocio.agregar(nuevaCategoria);
                else
                    return;
                Close();
            }
            else if (modoABM == "modificar")
            {
                int idCategoria = (int)cboModifCategoria.SelectedValue;
                nuevaCategoria = validarEntrada(nuevaCategoria, idCategoria);
                if (nuevaCategoria != "")
                    categoriaNegocio.modificar(idCategoria, nuevaCategoria);
                else
                    return;
                Close();
            }
            else if (modoABM == "baja")
            {
                int idCategoria = (int)cboModifCategoria.SelectedValue;
                if (!categoriaNegocio.eliminar(idCategoria))
                {
                    MessageBox.Show("Esta 'Categoría' está en uso! No pueden eliminarse Categorías ligadas a artículos existentes.", "Aviso!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Close();
            }
        }
                
        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string validarEntrada(string nuevaCategoria, int idCategoria)
        {
            //Si el texto está vacio, avisar y retornar.
            if (nuevaCategoria == null || nuevaCategoria.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un texto valido!", "Aviso!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            //Si es válido, le sacamos los espacios extra.
            nuevaCategoria = nuevaCategoria.Trim();

            //Si ya existe la categoría, no te va a dejar.
            if (categoriaNegocio.existe(nuevaCategoria, idCategoria))
            {
                MessageBox.Show("La 'Categoría' ingresada ya existe! Ingrese una 'Categoría' diferente!", "Aviso!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return nuevaCategoria;
        }

        private void configVisual(string modoABM)
        {
            if (modoABM == "alta")
            {
                Text = "Nueva Categoría";
                lbModifCategoria.Visible = false;
                cboModifCategoria.Visible = false;
                lbNuevaCategoria.Location = new Point(15, 35);
                txtNuevaCategoria.Location = new Point(290, 35);
            }
            else if (modoABM == "modificar")
            {
                Text = "Modificar Categoría";
                lbNuevaCategoria.Text = "Nuevo nombre de la Categoría:";
            }
            else if (modoABM == "baja")
            {
                Text = "Eliminar Categoría";
                lbModifCategoria.Text = "Nombre de la Categoría a eliminar:";
                lbNuevaCategoria.Visible = false;
                txtNuevaCategoria.Visible = false;
                lbModifCategoria.Location = new Point(15, 35);
                cboModifCategoria.Location = new Point(290, 35);
            }
        }
    }
}
