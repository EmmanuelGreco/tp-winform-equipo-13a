SELECT * FROM ARTICULOS
SELECT * FROM MARCAS
SELECT * FROM CATEGORIAS
SELECT * FROM IMAGENES

SELECT Codigo, Nombre, A.Descripcion, M.Descripcion, C.Descripcion, Precio
FROM ARTICULOS A, Marcas M, Categorias C
WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria


update ARTICULOS set IdMarca = 5, IdCategoria = 1 where id = 2