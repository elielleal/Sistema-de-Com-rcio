use dbcomercio

--mostrar
create proc spmostrar_cliente
as
select top 100 * from Cliente 
order by nome asc 
go

--buscar pelo nome
create proc spbuscar_cliente_nome
@textobuscar varchar(50)
as select * from Cliente where nome 
like @textobuscar + '%'
order by nome asc
go

--buscar pelo documento
create proc spbuscar_cliente_documento
@textobuscar varchar(50)
as select * from Cliente where num_documento 
like @textobuscar + '%'
order by nome asc
go


--inserir
create proc spinserir_cliente
@id int output,
@nome varchar(35),
@sobrenome varchar(25),
@sexo varchar(1),
@data_nasc date,
@tipo_documento varchar(20),
@num_documento varchar(20),
@endereco varchar(40),
@telefone varchar(16),
@email varchar(50)
as insert into Cliente (nome, sobrenome, sexo, data_nascimento, tipo_documento, num_documento, endereco, telefone, email) values (@nome, @sobrenome, @sexo, @data_nasc, @tipo_documento, @num_documento, @endereco, @telefone, @email)
go

--editar
create proc speditar_cliente
@id int,
@nome varchar(35),
@sobrenome varchar(25),
@sexo varchar(1),
@data_nasc date,
@tipo_documento varchar(20),
@num_documento varchar(20),
@endereco varchar(40),
@telefone varchar(16),
@email varchar(50)
as update Cliente set nome=@nome, sobrenome=@sobrenome,
sexo=@sexo, data_nascimento=@data_nasc,tipo_documento=@tipo_documento, num_documento = @num_documento,
endereco=@endereco, telefone=@telefone, email=@email
where idcliente = @id
go

--deletar
create proc spdeletar_cliente
@id int
as delete from Cliente where idcliente = @id
go