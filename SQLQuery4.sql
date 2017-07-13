-- mostrar 
use dbcomercio
create proc spmostrar_produto as
SELECT top 100 dbo.Produto.idproduto, dbo.Produto.codigo, dbo.Produto.nome, 
 dbo.Produto.descricao, dbo.Produto.imagem, dbo.Produto.idcategoria, 
 dbo.Categoria.nome AS Categoria, dbo.Produto.idapresentacao, 
 dbo.Apresentacao.nome AS Apresentacao
FROM  dbo.Apresentacao INNER JOIN
 dbo.Produto ON dbo.Apresentacao.idapresentacao = dbo.Produto.idapresentacao 
 INNER JOIN
 dbo.Categoria ON dbo.Produto.idcategoria = dbo.Categoria.idcategoria
 order by dbo.Produto.idproduto desc
 go

-- criar buscar pelo nome
create proc spbuscar_produto_nome 
@textobuscar varchar(50)
as
SELECT  dbo.Produto.idproduto, dbo.Produto.codigo, dbo.Produto.nome, 
 dbo.Produto.descricao, dbo.Produto.imagem, dbo.Produto.idcategoria, 
 dbo.Categoria.nome AS Categoria, dbo.Produto.idapresentacao, 
 dbo.Apresentacao.nome AS Apresentacao
FROM  dbo.Apresentacao INNER JOIN
 dbo.Produto ON dbo.Apresentacao.idapresentacao = dbo.Produto.idapresentacao 
 INNER JOIN
 dbo.Categoria ON
 dbo.Produto.idcategoria = dbo.Categoria.idcategoria
 where dbo.Produto.nome like @textobuscar + '%'
 order by dbo.Produto.idproduto desc
 go


--criar inserir
create proc spinserir_produto
@id int output,
@codigo varchar(50),
@nome varchar(50),
@descricao varchar(500),
@imagem image,
@idcategoria int,
@idapresentacao int
as
insert into Produto(codigo, nome, descricao, imagem, idcategoria, idapresentacao) 
values(@codigo, @nome, @descricao, @imagem, @idcategoria, @idapresentacao)
go



--criar editar
create proc speditar_produto
@id int,
@codigo varchar(50),
@nome varchar(50),
@descricao varchar(500),
@imagem image,
@idcategoria int,
@idapresentacao int
as
update Produto set codigo=@codigo, nome=@nome, descricao=@descricao, 
imagem=@imagem, idcategoria=@idcategoria, idapresentacao=@idapresentacao
where idproduto=@id
go


--criar deletar
create proc spdeletar_produto
@id int
as
delete from Produto
where idproduto=@id
go