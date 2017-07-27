use dbcomercio

--mostrar venda
create proc spmostrar_venda 
as 
select top 100 v.idvenda, (f.nome+' '+f.sobrenome)
as Funcionario, (c.nome+' '+c.sobrenome) as
Cliente, v.data, v.tipo_comprovante, v.serie, 
v.correlativo, v.imposto,
sum((d.quantidade*d.preco_venda)-d.desconto) as Total
from Detalhe_Venda d inner join Venda v on 
d.idvenda=v.idvenda inner join Cliente c on 
v.idcliente=c.idcliente inner join Funcionario f on 
v.idfuncionario=f.idfuncionario
group by
v.idvenda, (f.nome+' '+f.sobrenome), 
(c.nome+' '+c.sobrenome), 
v.data, v.tipo_comprovante, v.serie, 
v.correlativo, v.imposto
order by v.idvenda desc
go

--buscar vendas entre datas
create proc spbuscar_venda_data
@textobuscar varchar(50),
@textobuscar2 varchar(50)
as
select v.idvenda, (f.nome+' '+f.sobrenome)
as Funcionario, (c.nome+' '+c.sobrenome) as
Cliente, v.data, v.tipo_comprovante, v.serie, 
v.correlativo, 
sum((d.quantidade*d.preco_venda)-d.desconto) as Total
from Detalhe_Venda d inner join Venda v on 
d.idvenda=v.idvenda inner join Cliente c on 
v.idcliente=c.idcliente inner join Funcionario f on 
v.idfuncionario=f.idfuncionario
group by
v.idvenda, (f.nome+' '+f.sobrenome), 
(c.nome+' '+c.sobrenome), 
v.data, v.tipo_comprovante, v.serie, 
v.correlativo
having v.data>=@textobuscar and 
v.data<=@textobuscar2 
go


--inserir venda
create proc spinserir_venda
@idvenda int=null output,
@idcliente int,
@idfuncionario int,
@data date,
@tipo_comprovante varchar(20),
@serie varchar(4),
@correlativo varchar(7),
@imposto decimal(4,2)
as
insert into Venda (idcliente, idfuncionario,
data, tipo_comprovante, serie, correlativo, imposto)
 values (@idcliente, @idfuncionario,
@data, @tipo_comprovante, @serie, @correlativo,
 @imposto)
 set @idvenda=@@IDENTITY
 go


 --DELETAR VENDA
 create proc spdeletar_venda
 @idvenda int
 as 
 delete from Venda where idvenda=@idvenda
 go


 --inserir os detalhes da venda
 create proc spinserir_detalhes_venda
 @iddetalhe_venda int output,
 @idvenda int,
 @iddetalhe_entrada int,
 @quantidade int,
 @preco_venda money,
 @desconto money

as insert into Detalhe_Venda (idvenda,
iddetalhe_entrada, quantidade, preco_venda,
desconto) values (@idvenda,
@iddetalhe_entrada, @quantidade, @preco_venda,
@desconto)
go


--ATUALIZAR ESTOQUE DEPOIS DE DELETAR UMA VENDA
create trigger tratualizar_estoque
on [detalhe_venda] for delete as 
update de set de.estoque_atual=de.estoque_atual+
dv.quantidade from Detalhe_Entrada as de inner join
deleted as dv on 
de.iddetalhe_entrada=dv.iddetalhe_entrada
go


--abater itens estoque apos venda
create proc spdiminuir_estoque
@iddetalhe_entrada int,
@quantidade int
as update detalhe_entrada set
estoque_atual=estoque_atual - @quantidade
where iddetalhe_entrada=@iddetalhe_entrada
go

--mostrar os detalhes de venda
create proc spmostrar_detalhe_venda
@textobuscar int
as
select d.iddetalhe_entrada, p.nome as Produto,
d.quantidade, d.preco_venda, d.desconto,
((d.preco_venda*d.quantidade)-d.desconto) as 
SubTotal from detalhe_venda d inner join 
detalhe_entrada de
 on d.iddetalhe_entrada=de.iddetalhe_entrada 
 inner join produto p on de.idproduto=p.idproduto
 where 
 d.idvenda=@textobuscar
 go


 --mostrar os produtos para venda   pelo none
 create proc spbuscarproduto_venda_nome
 @textobuscar varchar(50)
 as
 select d.iddetalhe_entrada, p.codigo, p.nome,
 c.nome as Categoria, a.nome as Apresentacao,
 d.estoque_atual, d.preco_compra, d.preco_venda,
 d.data_vencimento from produto p inner join 
 categoria c on p.idcategoria=c.idcategoria 
 inner join apresentacao a on 
 p.idapresentacao=a.idapresentacao inner join
 detalhe_entrada d on p.idproduto=d.idproduto 
 inner join entrada e on d.identrada=e.identrada
where p.nome like @textobuscar + '%' and 
d.estoque_atual > 0 and e.estado<>'ANULADO'
go



--mostrar os produtos para venda pelo codigo
 create proc spbuscarproduto_venda_codigo
 @textobuscar varchar(50)
 as
 select d.iddetalhe_entrada, p.codigo, p.nome,
 c.nome as Categoria, a.nome as Apresentacao,
 d.estoque_atual, d.preco_compra, d.preco_venda,
 d.data_vencimento from produto p inner join 
 categoria c on p.idcategoria=c.idcategoria 
 inner join apresentacao a on 
 p.idapresentacao=a.idapresentacao inner join
 detalhe_entrada d on p.idproduto=d.idproduto 
 inner join entrada e on d.identrada=e.identrada
where p.codigo = @textobuscar and 
d.estoque_atual > 0 and e.estado<>'ANULADO'
go