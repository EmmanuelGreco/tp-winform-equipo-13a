-- -- BORRAR
-- USE master
-- GO
-- ALTER DATABASE CATALOGO_P3_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- DROP DATABASE CATALOGO_P3_DB;
-- GO
-- -- BORRAR


USE master
GO
USE CATALOGO_P3_DB
GO
SELECT * FROM ARTICULOS
SELECT * FROM MARCAS
SELECT * FROM CATEGORIAS
SELECT * FROM IMAGENES


-- ARREGLA EL ERROR DE IDs EN EL MOTO G7
UPDATE ARTICULOS SET IdMarca = 5, IdCategoria = 1 WHERE Id = 2


-- ARTICULO EXTRA PARA DEMOSTRAR FUNCIONAMIENTO DE LA IMAGEN PLACEHOLDER
-- INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('SM4', 'iPod', 'Musiquita', 2, 3, 49.99);


-- IMAGENES QUE EXISTEN!! LAS QUE VENIAN DABAN ERROR
		-- Moto G7
UPDATE IMAGENES SET ImagenUrl = 'https://i.blogs.es/7dae03/moto-g7-power-6/650_1200.jpg' WHERE Id = 2
		-- PS4
UPDATE IMAGENES SET ImagenUrl = 'https://http2.mlstatic.com/D_NQ_926584-MLA71282395677_082023-OO.jpg' WHERE Id = 4
		-- Bravia 55
UPDATE IMAGENES SET ImagenUrl = 'https://www.radioshack.cr/media/catalog/product/9/0/9008010048tv.jpg' WHERE Id = 5
		-- Apple TV
UPDATE IMAGENES SET ImagenUrl = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRMRvBKDbRwTu_HB5TtOunIFsQ_t0li7CkndA&s' WHERE Id = 6


-- IMAGENES EXTRA PARA EL BRAVIA!! PARA PODER PROBAR LAS FLECHAS
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://buketomnisportpweb.s3.us-east-2.amazonaws.com/seo/gzg3H8cvix8kft0fxq8jMho7h11Ub2Vc5opACcOy.jpeg')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_1_FrontWithStand_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_2_CW_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_3_CCW_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_4_Angled_Back_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_5_Bezel_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_6_Stand_M?$productIntroPlatemobile$&fmt=png-alpha')
INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (4, 'https://sony.scene7.com/is/image/sonyglobalsolutions/TVFY24_UE_0_insitu_M?$productIntroPlatemobile$&fmt=png-alpha')

SELECT * FROM IMAGENES

-- QUERY UTILIZADA EN ARTICULO NEGOCIO: 
SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio FROM ARTICULOS A, Marcas M, Categorias C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria


-- QUERY UTILIZADA EN IMAGEN NEGOCIO;
SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES 


-- QUERY UTILIZADA EN ALTA ARTICULO SIMPLE:
INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio) VALUES ('', '', '', 1)

UPDATE ARTICULOS SET IdMarca = 1, IdCategoria = 1 WHERE Id = 13
UPDATE ARTICULOS SET Nombre = 'Prueba' WHERE Id = 7

SELECT * FROM ARTICULOS
DELETE FROM ARTICULOS WHERE Id > 5 --AND Id <= X
DBCC CHECKIDENT (ARTICULOS, RESEED, 5)


-- QUERY UTILIZADA EN LISTAR MARCA NEGOCIO:
SELECT Id, Descripcion FROM MARCAS

/*
SELECT * FROM MARCAS
DELETE FROM MARCAS WHERE Id > 5 --AND Id <= X
DBCC CHECKIDENT (MARCAS, RESEED, 5)
*/


-- QUERY UTILIZADA EN LISTAR CATEGORIA NEGOCIO:
SELECT Id, Descripcion FROM CATEGORIAS

/*
SELECT * FROM CATEGORIAS
DELETE FROM CATEGORIAS WHERE Id > 4 --AND Id <= X
DBCC CHECKIDENT (CATEGORIAS, RESEED, 4)
*/


-- QUERY UTILIZADA EN ALTA ARTICULO CON IMAGEN SIMPLE:
SELECT Id FROM ARTICULOS WHERE Codigo = 'X'
INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (6, 'ejemplo')
SELECT * FROM ARTICULOS
SELECT * FROM IMAGENES


-- QUERY UTILIZADA EN MODIFICAR ARTICULO:
SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria, Precio
FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria
SELECT * FROM ARTICULOS
SELECT * FROM MARCAS
SELECT * FROM CATEGORIAS
UPDATE ARTICULOS SET IdMarca = 3, IdCategoria = 2 WHERE Id = 6


-- QUERY UTILIZADA EN MODIFICAR ARTICULO:
UPDATE ARTICULOS SET Codigo = '', Nombre = '', Descripcion = '', IdMarca = 1, IdCategoria = 1, Precio = 1 WHERE Id = 8
UPDATE IMAGENES SET ImagenUrl = '' WHERE IdArticulo = 10
SELECT * FROM IMAGENES


-- ELIMINO Y REINICIO IDS DE PRUEBAS
DELETE FROM ARTICULOS
DBCC CHECKIDENT (ARTICULOS, RESEED, 0)
DELETE FROM IMAGENES
DBCC CHECKIDENT (IMAGENES, RESEED, 0)
DELETE FROM MARCAS
DBCC CHECKIDENT (MARCAS, RESEED, 0)
DELETE FROM CATEGORIAS
DBCC CHECKIDENT (CATEGORIAS, RESEED, 0)


-- QUERY UTILIZADA EN ELIMINAR ARTICULO:
SELECT * FROM ARTICULOS
DELETE FROM ARTICULOS WHERE Id = 6


-- QUERY UTILIZADA EN EXISTE CODIGO ARTICULO:
-- Fuerzo Case Sensitive
SELECT Id FROM Articulos WHERE Codigo = 'S01' COLLATE SQL_Latin1_General_CP1_CS_AS AND Id <> 1


-- MARCAS - AGREGAR 
SELECT * FROM MARCAS
INSERT INTO MARCAS (Descripcion) VALUES ('Tesla'); SELECT SCOPE_IDENTITY() AS NuevoID;
DELETE FROM MARCAS

SELECT LEN(Descripcion) FROM MARCAS;

INSERT INTO MARCAS (Descripcion) SELECT ('Cono')
WHERE NOT EXISTS (
    SELECT * FROM MARCAS WHERE Descripcion = 'Cono'
) SELECT SCOPE_IDENTITY() AS NuevoID;