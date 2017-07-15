--mostrar
create proc spmostrar_fornecedor
as
select top 100 * from Fornecedor
order by empresa asc
go


--buscar por empresea
create proc spbuscar_fornecedor_empresa
@textobuscar varchar(50)
as
select * from Fornecedor where empresa
like @textobuscar + '%'
go


--buscar por documento
create proc spbuscar_fornecedor_documento
@textobuscar varchar(50)
as
select * from Fornecedor where num_documento
like @textobuscar + '%'
go


--inserir
create proc spinserir_fornecedor
@id int output,
@empresa varchar(150),
@setor_comercial varchar(50),
@tipo_documento varchar(50),
@num_documento varchar(11),
@endereco varchar(100),
@telefone varchar(50),
@email varchar(50),
@url varchar(100)
as
insert into Fornecedor (idfornecedor, empresa, setor_comercial, tipo_documento, num_documento, endereco, telefone, email, url) values (@id , @empresa, @setor_comercial, @tipo_documento, @num_documento, @endereco, @telefone, @email, @url)
go




--editar
create proc speditar_fornecedor
@id int output,
@empresa varchar(150),
@setor_comercial varchar(50),
@tipo_documento varchar(50),
@num_documento varchar(11),
@endereco varchar(100),
@telefone varchar(50),
@email varchar(50),
@url varchar(100)
as
update Fornecedor set empresa=@empresa, setor_comercial=@setor_comercial, tipo_documento=@tipo_documento, num_documento=@num_documento,
endereco=@endereco, telefone=@telefone, email=@email,
url=@url where idfornecedor=@id
go 

--deletar
create proc spdeletar_fornecedor
@id int 
as 
delete from Fornecedor 
where idfornecedor = @id
go