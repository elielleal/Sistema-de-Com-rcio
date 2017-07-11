-- mostrar apresentacaoALTER 
create proc spmostrar_apresentacao
as
select top 200 * from Apresentacao
order by idapresentacao desc
go

-- criar buscar pelo nome
create proc spbuscar_apresentacao_nome
@textobuscar varchar(50)
as select * from Apresentacao where nome like @textobuscar + '%'
go


--criar inserir
create proc spinserir_apresentacao
@idapresentacao int output,
@nome varchar(50),
@descricao varchar(100)
as 
insert into Apresentacao(nome, descricao) values (@nome, @descricao)
go



--criar editar
create proc speditar_apresentacao
@idapresentacao int,
@nome varchar(50),
@descricao varchar(100)
as
update Apresentacao set nome=@nome,
descricao=@descricao where
idapresentacao=@idapresentacao
go


--criar deletar
create proc spdeletar_apresentacao
@idapresentacao int
as
delete from Apresentacao where
idapresentacao=@idapresentacao
go