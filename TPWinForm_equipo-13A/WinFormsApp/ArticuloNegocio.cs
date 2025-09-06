using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //PEDRO
                conexion.ConnectionString = "Server=localhost;Database=CATALOGO_P3_DB; integrated security=false; user ID=sa; password=BaseDeDatos#2";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "SELECT * FROM ARTICULOS";
                comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio FROM ARTICULOS A, Marcas M, Categorias C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
