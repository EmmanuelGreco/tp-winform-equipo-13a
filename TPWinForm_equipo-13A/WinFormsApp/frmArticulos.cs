using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        Articulo seleccionado;
        private int indiceImagen = 0;
        private bool ordenAscendente = true;
        private string columnaOrdenActual = "";

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            // Si bien el metodo formatearColumnas(); se llama varias veces
            // y parece repetitivo, es porque con 1 solo llamado, por algun motivo
            // no respesta la medida seleccionada y existen variaciones
            formatearColumnas();
            cboCampoFiltro.Items.Add("Nombre");
            cboCampoFiltro.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listaArticulo = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            formatearColumnas();

            try
            {
                seleccionado = (Articulo)dgvArticulos.Rows[0].DataBoundItem;
                if (seleccionado.ListaImagen.Count < 2) btnImagenSiguiente.Visible = false;
                else btnImagenSiguiente.Visible = true;
                articuloModificarTSMenuItem.Enabled = true;
                articuloEliminarTSMenuItem.Enabled = true;
                formatearColumnas();
                cargarDetalles(seleccionado);
            }
            catch (Exception)
            {
                seleccionado = new Articulo();
                btnImagenSiguiente.Visible = false;
                articuloModificarTSMenuItem.Enabled = false;
                articuloEliminarTSMenuItem.Enabled = false;

                lbCategoria.Text = "";
                lbCodigo.Text = "";
                lbMarca.Text = "";
                lbPrecio.Text = "";
                lbTitulo.Text = "Ningún artículo para mostrar!";
                lbDescripcion.Text = "Debe contar con al menos una marca y una categoría para poder añadir un artículo.";

                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
                btnImagenSiguiente.Visible = false;
                btnImagenAnterior.Visible = false;

                formatearColumnas();
            }

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            
            int cantMarcas = marcaNegocio.listar().Count;
            int cantCategorias = categoriaNegocio.listar().Count;

            if (cantMarcas == 0)
            {
                marcaModificarTSMenuItem.Enabled = false;
                marcaEliminarTSMenuItem.Enabled = false;
                articuloAgregarTSMenuItem.Enabled = false;
            } else
            {
                marcaModificarTSMenuItem.Enabled = true;
                marcaEliminarTSMenuItem.Enabled = true;
            }
            
            if (cantCategorias == 0)
            {
                categoriaModificarTSMenuItem.Enabled = false;
                categoriaEliminarTSMenuItem.Enabled = false;
                articuloAgregarTSMenuItem.Enabled = false;
            }
            else
            {
                categoriaModificarTSMenuItem.Enabled = true;
                categoriaEliminarTSMenuItem.Enabled = true;
            }

            if (cantMarcas != 0 && cantCategorias != 0)
                articuloAgregarTSMenuItem.Enabled = true;

            formatearColumnas();
        }

        private void formatearColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            //dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Codigo"].Width = 120;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Width = 120;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C";   //En formato dinero!
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns["Precio"].Width = 120;
        }

        private void dgvArticulos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindingSource BindingSource = new BindingSource();
            BindingSource.DataSource = listaArticulo;
            dgvArticulos.DataSource = BindingSource;

            string columna = dgvArticulos.Columns[e.ColumnIndex].DataPropertyName;
            
            if (columna != columnaOrdenActual)
            {
                ordenAscendente = true;
                columnaOrdenActual = columna;
            }

            if (columna == "Codigo")
            {
                listaArticulo = ordenAscendente
                    ? listaArticulo.OrderBy(p => p.Codigo).ToList()
                    : listaArticulo.OrderByDescending(p => p.Codigo).ToList();
            }
            else if (columna == "Nombre")
            {
                listaArticulo = ordenAscendente
                    ? listaArticulo.OrderBy(p => p.Nombre).ToList()
                    : listaArticulo.OrderByDescending(p => p.Nombre).ToList();
            }  
            // Se rompe
            /*else if (columna == "Categoria")
            {
                //listaArticulo = listaArticulo.OrderBy(p => p.Categoria).ToList();

            }*/
            else if (columna == "Precio")
            {
                listaArticulo = ordenAscendente
                    ? listaArticulo.OrderBy(p => p.Precio).ToList()
                    : listaArticulo.OrderByDescending(p => p.Precio).ToList();
            }

            BindingSource.DataSource = listaArticulo;
            dgvArticulos.AllowUserToAddRows = false;

            ordenAscendente = !ordenAscendente;

            for (int i = 0; i < dgvArticulos.Columns.Count; i++)
            {
                // No cambiar la dirección de la flecha para Categoria, ya que el OrderBy rompe
                if (dgvArticulos.Columns[i].DataPropertyName == columna &&
                    dgvArticulos.Columns[i].DataPropertyName != "Categoria")
                {
                    // Establecer la flecha en orden ascendente o descendente
                    dgvArticulos.Columns[i].HeaderCell.SortGlyphDirection = ordenAscendente
                        ? SortOrder.Ascending
                        : SortOrder.Descending;
                }
                else
                {
                    // Limpiar la flecha en las otras columnas
                    dgvArticulos.Columns[i].HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            formatearColumnas();
        }

        private void cargarDetalles(Articulo seleccionado)
        {
            try
            {
                cargarImagen(seleccionado.ListaImagen[indiceImagen].ImagenUrl);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }

            lbTitulo.Text = seleccionado.Nombre;
            lbPrecio.Text = seleccionado.Precio.ToString("C");              //En formato dinero!
            lbDescripcion.Text = seleccionado.Descripcion;
            lbCodigo.Text = seleccionado.Codigo;
            lbMarca.Text = seleccionado.Marca.Descripcion;
            lbCategoria.Text = seleccionado.Categoria.Descripcion;
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

                // if (seleccionado.ListaImagen.Count < )
                try
                {
                    cargarDetalles(seleccionado);
                }
                catch (Exception ex)
                {
                    throw ex;
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
            //Articulo seleccionado;
            //seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void articuloEliminarTSMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioImagen = new ImagenNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea confirmar la Eliminación del Artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    //seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    negocioImagen.eliminarConIdArticulo(seleccionado.Id);
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
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltroAvanzado())
                    return;
                string campo = cboCampoFiltro.SelectedItem.ToString();
                string criterio = cboCriterioFiltro.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltroAvanzado()
        {
            if (cboCampoFiltro.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el Campo a filtrar.", "Aviso!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (cboCriterioFiltro.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el Criterio a filtrar.", "Aviso!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (cboCampoFiltro.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text))){
                MessageBox.Show("Por favor, ingrese un Precio válido!", "Aviso!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            // Reemplazo las ',' por '.' para tomar los decimales y minimizar errores del usuario.
            cadena = cadena.Trim().Replace(',', '.');
            decimal precio;

            if (!decimal.TryParse(cadena, NumberStyles.Number, CultureInfo.InvariantCulture, out precio))
            {
                return false;
            }

            return true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            busquedaFiltro();
            formatearColumnas();
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
            formatearColumnas();
        }

        private void marcaAgregarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca("alta");
            alta.ShowDialog();
            cargar();
        }

        private void marcaModificarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarca modif = new frmAltaMarca("modificar");
            modif.ShowDialog();
            cargar();
        }

        private void marcaEliminarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarca baja = new frmAltaMarca("baja");
            baja.ShowDialog();
            cargar();
        }

        private void categoriaAgregarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria("alta");
            alta.ShowDialog();
            cargar();
        }

        private void categoriaModificarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCategoria modif = new frmAltaCategoria("modificar");
            modif.ShowDialog();
            cargar();
        }

        private void categoriaEliminarTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCategoria baja = new frmAltaCategoria("baja");
            baja.ShowDialog();
            cargar();
        }

        private void cboCampoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoFiltro.SelectedItem.ToString();
            if(opcion == "Nombre")
            {
                cboCriterioFiltro.Items.Clear();
                cboCriterioFiltro.Items.Add("Comienza con");
                cboCriterioFiltro.Items.Add("Termina con");
                cboCriterioFiltro.Items.Add("Contiene");
            }
            else
            {
                cboCriterioFiltro.Items.Clear();
                cboCriterioFiltro.Items.Add("Mayor a");
                cboCriterioFiltro.Items.Add("Menor a");
                cboCriterioFiltro.Items.Add("Igual a");
            }
        }
    }
}
