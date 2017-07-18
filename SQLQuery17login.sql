use dbcomercio;

--preced login
create proc splogin
@usuario varchar(20),
@senha varchar(20)
as
select idfuncionario, nome, sobrenome, acesso
from Funcionario where usuario=@usuario and 
senha=@senha
go
