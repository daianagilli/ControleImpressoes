CREATE DATABASE sistemaImpressoes
USE sistemaImpressoes

CREATE TABLE Alunos(
codigo INT IDENTITY PRIMARY KEY,
nome VARCHAR(100),
saldoImpressao INT,
matricula INT NOT NULL
);

CREATE TABLE Compras(
codigo INT IDENTITY PRIMARY KEY,
codigoAluno INT,
dataCompra DATE, 
quantidadeComprada INT,
CONSTRAINT FK_AlunosCompras
FOREIGN KEY (codigoAluno)
REFERENCES Alunos(codigo)
);

CREATE TABLE Historicos(
codigo INT IDENTITY PRIMARY KEY,
codigoAluno INT NOT NULL,
dataHistorico DATE, 
movimentacao BIT NOT NULL,
saldoAntesMovimentacao INT NOT NULL, 
saldoDepoisMovimentacao INT NOT NULL, 
CONSTRAINT FK_AlunosHistoricos
FOREIGN KEY (codigoAluno)
REFERENCES Alunos(codigo)
);

CREATE TABLE Impressoes(
codigo INT IDENTITY PRIMARY KEY, 
codigoAluno INT NOT NULL,
dataImpressao DATE,
quantidadeImpressa INT NOT NULL, 
CONSTRAINT FK_AlunosImpressoes
FOREIGN KEY (codigoAluno)
REFERENCES Alunos(codigo)
);

ALTER TABLE Compras 
	ALTER COLUMN dataCompra DATETIME

ALTER TABLE Historicos
	ALTER COLUMN dataHistorico DATETIME
	
ALTER TABLE Impressoes
	ALTER COLUMN dataImpressao DATETIME

ALTER TABLE Alunos ADD saldo INT DEFAULT 0