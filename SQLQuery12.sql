--mostrar
create proc spmostrar_funcionario
as
select top 100 * from Funcionario 
order by nome asc 
go


--buscar pelo nome
create proc spbuscar_funcionario_nome
@textobuscar varchar(50)
as select * from Funcionario where nome 
like @textobuscar + '%'
order by nome asc
go


--buscar pelo documento
create proc spbuscar_funcionario_documento
@textobuscar varchar(50)
as select * from Funcionario where num_documento 
like @textobuscar + '%'
order by nome asc
go


--inserir
create proc spinserir_funcionario
@id int output,
@nome varchar(50),
@sobrenome varchar(50),
@sexo varchar(1),
@data_nasc date,
@num_documento varchar(9),
@endereco varchar(150),
@telefone varchar(14),
@email varchar(50),
@acesso varchar(20),
@usuario varchar(20),
@senha varchar(20)
as insert into Funcionario(nome, sobrenome, sexo, data_nascimento, num_documento, endereco, telefone, email, acesso, usuario, senha) values (@nome, @sobrenome, @sexo, @data_nasc, @num_documento, @endereco, @telefone, @email, @acesso, @usuario, @senha)
go

--editar
create proc speditar_funcionario
@id int,
@nome varchar(20),
@sobrenome varchar(40),
@sexo varchar(1),
@data_nasc date,
@num_documento varchar(8),
@endereco varchar(100),
@telefone varchar(10),
@email varchar(50),
@acesso varchar(20),
@usuario varchar(20),
@senha varchar(20)
as update Funcionario set nome=@nome, sobrenome=@sobrenome,
sexo=@sexo, data_nascimento=@data_nasc, num_documento = @num_documento,
endereco=@endereco, telefone=@telefone, email=@email,
acesso=@acesso, usuario=@usuario, senha=@senha
where idfuncionario = @id
go

--deletar
create proc spdeletar_funcionario
@id int
as delete from Funcionario where idfuncionario = @id
go