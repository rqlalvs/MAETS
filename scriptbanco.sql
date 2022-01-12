CREATE DATABASE dbJogosInterativos
GO
use dbJogosInterativos
GO

CREATE TABLE tbAvaliarJogo( 
IdAval numeric(5) primary key,
DescAval varchar(100),
NotaAval decimal (2,2)
);
go

-- CREATE PROC DA AVALIAÇÃO

DECLARE @idavali Numeric(5)
DECLARE @descavali Varchar(100)
DECLARE @notaavali decimal(2,2)

GO
CREATE PROC SP_Avaliacao 
@idavali Numeric(5),@descavali Varchar(100),@notaavali decimal(2,2)
AS
BEGIN
		insert into tbAvaliarJogo(IdAval, DescAval, NotaAval)
		VALUES (@idavali, @descavali, @notaavali)
END
GO


CREATE TABLE tbCliente(
NomeCli varchar(60),
IdCli numeric(4) primary key,
CPFCli numeric(11),
EmailCli varchar(150),
IdadeCli numeric(2),
NomeUsu varchar(20),
SenhaUsu varchar(20),
IdAval numeric(5) foreign key references tbAvaliarJogo(IdAval), 
);
GO

-- CREATE PROC DO CLIENTE
DECLARE @nomeCli Varchar(60)
DECLARE @idcli Numeric(4)
DECLARE @cpfcli Numeric(11)
DECLARE @emailcli Varchar(150)
DECLARE @idadecli Numeric(2)
DECLARE @nomeusu Varchar(20)
DECLARE @senhausu varchar(20)
DECLARE @idavali Numeric(5)
GO
CREATE PROC SP_Cliente 
@nomeCli Varchar(60),
@idcli Numeric(4),
@cpfcli Numeric(11),
@emailcli Varchar(150),
@idadecli Numeric(2),
@nomeusu Varchar(20),
@senhausu varchar(20),
@idavali Numeric(5)
AS

BEGIN
		insert into tbCliente(NomeCli, IdCli, CPFCli, EmailCli, IdadeCli, NomeUsu, SenhaUsu, IdAval)
		VALUES (@nomeCli, @idcli, @cpfcli, @emailcli, @idadecli, @nomeusu, @senhausu, @idavali)
END
GO



CREATE TABLE tbJogo( 
IdJogo numeric identity(1,1) primary key,
NomeJogo varchar(50),
DescJogo varchar(300),
PrecoJogo decimal(4,2),
Idadejogo Varchar(5),
NomeEquipa varchar(50), 
IdAval numeric(5) foreign key references tbAvaliarJogo,
);
go
-- CREATE PROC DO JOGO
DECLARE @nomejogo Varchar(50)
DECLARE @descjogo varchar(300)
DECLARE @precojogo decimal(4,2)
DECLARE @idadejogo Varchar(5)
DECLARE @nomeequipa Varchar(50)

GO
CREATE PROC SP_Jogo 
@nomejogo Varchar(50),
@descjogo varchar(300),
@precojogo decimal(4,2),
@idadejogo Varchar(5),
@nomeequipa Varchar(50)

AS

BEGIN
		insert into tbJogo(NomeJogo, DescJogo, PrecoJogo, Idadejogo, NomeEquipa)
		VALUES (@nomejogo, @descjogo, @precojogo, @idadejogo, @nomeequipa)
END
GO
CREATE TABLE tbVenda( 
IdVenda numeric identity(1,1) primary key,
Preco decimal(4,2),
FormaPag varchar(50),
Quant numeric(3)
);
GO

-- CREATE PROC DA VENDA
DECLARE @idvenda Numeric(4)
DECLARE @precotot decimal(4,2)
DECLARE @formapag Varchar(50)
DECLARE @quant numeric(3)

GO
CREATE PROC SP_Venda
@idvenda Numeric(4),
@precotot decimal(4,2),
@formapag Varchar(50),
@quant numeric(3)
AS

BEGIN
		insert into tbVenda(IdVenda, Preco, FormaPag, Quant)
		VALUES (@idvenda, @precotot, @formapag, @quant)
END
GO

CREATE TABLE tbItemVenda( 
IdJogo numeric foreign key references tbJogo(IdJogo),
IdVenda numeric foreign key references tbVenda(IdVenda),
 );
GO



