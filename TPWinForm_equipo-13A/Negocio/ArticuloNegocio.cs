using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datosArticulo = new AccesoDatos();
            AccesoDatos datosImagen = new AccesoDatos();
            
            try
            {
                datosArticulo.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio FROM ARTICULOS A, Marcas M, Categorias C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Articulo auxArticulo = new Articulo();
                    auxArticulo.Id = (int)datosArticulo.Lector["Id"];
                    auxArticulo.Codigo = (string)datosArticulo.Lector["Codigo"];
                    auxArticulo.Nombre = (string)datosArticulo.Lector["Nombre"];
                    auxArticulo.Descripcion = (string)datosArticulo.Lector["Descripcion"];
                    auxArticulo.Marca = new Marca();
                    auxArticulo.Marca.Descripcion = (string)datosArticulo.Lector["Marca"];
                    auxArticulo.Categoria = new Categoria();
                    auxArticulo.Categoria.Descripcion = (string)datosArticulo.Lector["Categoria"];
                    auxArticulo.Precio = (decimal)datosArticulo.Lector["Precio"];
                    
                    // OPCIONAL: (redondea los decimales a 2 nums despues de la coma)
                    auxArticulo.Precio = Math.Round(auxArticulo.Precio, 2, MidpointRounding.AwayFromZero);

                    //Agregar lista de imagenes
                    List<Imagen> listaImagen = new List<Imagen>();
                    try
                    {
                        datosImagen.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = " + auxArticulo.Id);
                        datosImagen.ejecutarLectura();

                        while (datosImagen.Lector.Read())
                        {
                            Imagen auxImagen = new Imagen();
                            auxImagen.Id = (int)datosImagen.Lector["Id"];
                            auxImagen.IdArticulo = (int)datosImagen.Lector["IdArticulo"];
                            auxImagen.ImagenUrl = (string)datosImagen.Lector["ImagenUrl"];

                            listaImagen.Add(auxImagen);
                        }

                        auxArticulo.ListaImagenes = listaImagen;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        datosImagen.cerrarConexion();
                    }

                    listaArticulo.Add(auxArticulo);
                }
                return listaArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosArticulo.cerrarConexion();
            }
        }
    }
}
