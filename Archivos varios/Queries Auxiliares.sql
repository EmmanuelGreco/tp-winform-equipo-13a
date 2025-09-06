SELECT * FROM ARTICULOS
SELECT * FROM MARCAS
SELECT * FROM CATEGORIAS
SELECT * FROM IMAGENES

-- Así se ve mas lindo, pero al pegarlo en Visual queda con \r\n por el salto de linea. Peguen el de abajo
SELECT Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio
FROM ARTICULOS A, Marcas M, Categorias C
WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria

-- El de abajo xd: 
SELECT Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio FROM ARTICULOS A, Marcas M, Categorias C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria


-- update ARTICULOS set IdMarca = 5, IdCategoria = 1 where id = 2