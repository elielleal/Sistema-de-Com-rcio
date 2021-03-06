use dbcomercio

--procedimento mostrar
create proc spmostrar_categoria
as 
select top 200 * from Categoria
order by idcategoria desc
go

--procedimento buscar nome
create proc spbuscar_nome
@textobuscar varchar(50)
as select * from Categoria where nome like @textobuscar + '%'

go

--procedimento inserir categ
create proc spinserir_categoria
@idcategoria int output,
@nome varchar(50),
@descricao varchar(256)
as 
insert into Categoria (nome, descricao) values (@nome, @descricao)
go


--procedimento editar categ
create proc speditar_categoria
@idcategoria int,
@nome varchar(50),
@descricao varchar(256)
as 
update Categoria set nome=@nome, descricao=@descricao where idcategoria=@idcategoria
go

--procedimento deletar categ
create proc spdeletar_categoria
@idcategoria int 
as 
delete from Categoria where idcategoria=@idcategoria
go