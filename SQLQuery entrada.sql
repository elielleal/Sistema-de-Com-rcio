

--mostrar tudo
create proc spmostrar_entrada
as 
select top 100
e.identrada, (f.nome+' '+f.sobrenome) as Funcionario,
p.empresa as Fornecedor, e.data, e.tipo_comprovante, 
e.serie, e.correlativo, e.imposto, e.estado, 
sum(d.preco_compra*d.estoque_inicial) as Total
from Detalhe_Entrada d inner join Entrada e
on d.identrada=e.identrada inner join
Fornecedor p on e.idfornecedor=p.idfornecedor
inner join Funcionario f on
e.idfuncionario=f.idfuncionario
group by 
e.identrada, f.nome+' '+f.sobrenome,
p.empresa, e.data, e.tipo_comprovante,
 e.serie, e.correlativo, e.imposto, e.estado
 order by e.identrada desc
 go


 --buscar por data
create proc spbuscar_entrada_data
 @textobuscar varchar(20),
 @textobuscar2 varchar(20)
 as 
 select e.identrada, (f.nome+' '+f.sobrenome) as Funcionario,
p.empresa as Fornecedor, e.data, e.tipo_comprovante, e.serie, e.correlativo, e.estado, 
sum(d.preco_compra*d.estoque_inicial) as Total
from Detalhe_Entrada d inner join Entrada e
on d.identrada=e.identrada inner join
Fornecedor p on e.idfornecedor=p.idfornecedor
inner join Funcionario f on
e.idfuncionario=f.idfuncionario
group by 
e.identrada, f.nome+' '+f.sobrenome,
p.empresa, e.data, e.tipo_comprovante,
 e.serie, e.correlativo, e.estado
 having e.data>=@textobuscar and
 e.data<=@textobuscar2
 go

 --inserir
 create proc spinserir_entrada
 @identrada int=null output,
 @idfuncionario int,
 @idfornecedor int,
 @data date,
 @tipo_comprovante varchar(20),
 @serie varchar(4),
 @correlativo varchar(7),
 @imposto decimal(4,2),
 @estado varchar(7)
 as
 insert into Entrada (idfuncionario, 
 idfornecedor, data, tipo_comprovante, serie,
 correlativo, imposto, estado ) values (
 @idfuncionario, @idfornecedor, @data,
 @tipo_comprovante, @serie, @correlativo,
 @imposto, @estado)
 SET @identrada=@@IDENTITY
  go

  --anular inserção
  create proc spanular_entrada
  @identrada int
  as
  update Entrada set estado='ANULADO' 
  where identrada=@identrada
   go

   --inserir tabela detalhes entrada
   create proc spinserir_detalhe_entrada
   @iddetalhe_entrada int output,
   @identrada int,
   @idproduto int,
   @preco_compra money,
   @preco_venda money,
   @estoque_inicial int,
   @estoque_atual int,
   @data_producao date,
   @data_vencimento date
   as 
   insert into Detalhe_Entrada ( 
   identrada, idproduto, preco_compra, preco_venda,
   estoque_inicial, estoque_atual, data_producao,
   data_vencimento) VALUES (@identrada, @idproduto, 
   @preco_compra, @preco_venda, @estoque_inicial, 
   @estoque_atual, @data_producao, @data_vencimento)
   go

   --mostrar detalhes da entrada
   create proc spmostrar_detalhes_entrada
   @textobuscar int
   as
   select d.idproduto, p.nome as Produto, d.preco_compra,
   d.preco_venda, d.estoque_inicial, d.data_producao,
   d.data_vencimento, (d.estoque_inicial*d.preco_compra)
   as SubTotal from Detalhe_Entrada d inner join
   produto p on d.idproduto = p.idproduto 
   where d.identrada=@textobuscar  
   go
