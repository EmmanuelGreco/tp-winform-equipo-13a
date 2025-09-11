using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dominio;
using Negocio;

namespace WinFormsApp
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        Articulo seleccionado;
        private int indiceImagen = 0;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listaArticulo = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulo;

            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (seleccionado.ListaImagen.Count < 2) btnImagenSiguiente.Visible = false;
            else btnImagenSiguiente.Visible = true;

            try
            {
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ListaImagen[0].ImagenUrl);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                indiceImagen = 0;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (seleccionado.ListaImagen.Count <= 1)
                {
                    btnImagenAnterior.Visible = false;
                    btnImagenSiguiente.Visible = false;
                }
                else
                {
                    btnImagenAnterior.Visible = false;
                    btnImagenSiguiente.Visible = true;
                }

                //if (seleccionado.ListaImagen.Count < )
                try
                {
                    cargarImagen(seleccionado.ListaImagen[indiceImagen].ImagenUrl);
                }
                catch (Exception)
                {
                    pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
                }
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            indiceImagen -= 1;
            if (indiceImagen == 0) btnImagenAnterior.Visible = false;
            btnImagenSiguiente.Visible = true;
            cargarImagen(seleccionado.ListaImagen[indiceImagen].ImagenUrl);
            
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            indiceImagen += 1;
            if (indiceImagen == seleccionado.ListaImagen.Count - 1) btnImagenSiguiente.Visible = false;
            btnImagenAnterior.Visible = true;
            cargarImagen(seleccionado.ListaImagen[indiceImagen].ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void articuloAgregarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void articuloModificarTSMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void articuloEliminarTSMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea confirmar la Eliminación?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            // Si bien el método txtFiltro_TextChanged hace lo mismo, este botón
            // queda para el Filtro Avanzado contra DB
            busquedaFiltro();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            busquedaFiltro();
        }

        private void busquedaFiltro()
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper())
                                                        || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper())
                                                        || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
