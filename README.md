# 🎓 Sistema de Controle de Impressões - SENAC

Este projeto foi desenvolvido como parte das atividades do curso de programação.  
O objetivo é gerenciar impressões de alunos, permitindo cadastro, compra de pacotes de impressões, consulta de histórico e saldo.

---

## 🚀 Funcionalidades

- **Cadastrar aluno**  
  Permite registrar novos alunos no sistema.

- **Comprar impressões**  
  O aluno pode adquirir pacotes de impressões (25 ou 50 páginas).

- **Realizar impressão**  
  Consome o saldo de páginas do aluno.

- **Consultar saldo de todos os alunos**  
  Mostra o saldo disponível de todos os alunos cadastrados.

- **Consultar histórico de movimentações**  
  Exibe as compras e impressões realizadas por cada aluno.

- **Sair do sistema**  
  Fecha a aplicação.

---

## 🛠️ Tecnologias utilizadas

- **C#** (.NET Framework)  
- **Windows Forms** (interface gráfica)  
- **SQL Server** (banco de dados)  

---

## 📂 Estrutura do Projeto

- `Program.cs` → ponto de entrada do sistema  
- `CadastrarAluno.cs` → tela para cadastrar alunos  
- `ComprarImpressoes.cs` → tela para compra de pacotes  
- `Imprimir.cs` → tela para registrar impressões  
- `ConsultarHistorico.cs` → tela para exibir histórico de cada aluno  
- `VerSaldo.cs` → tela para consultar o saldo de todos os alunos  
- `Conexao.cs` → gerencia a conexão com o banco de dados  
- `Historico.cs` → responsável pelas consultas de movimentações

---

## 🗄️ Banco de Dados

As principais tabelas utilizadas no SQL Server:

- **Alunos**
  - `codigo` (int, PK)
  - `nome` (varchar)
  - `saldo` (int)

- **Historicos**
  - `id` (int, PK)
  - `codigoAluno` (int, FK)
  - `dataHistorico` (datetime)
  - `movimentacao` (bit) → `true = compra`, `false = impressão`
  - `saldoAntesMovimentacao` (int)
  - `saldoDepoisMovimentacao` (int)

---

## 📸 Interface

A aplicação utiliza **Windows Forms** para permitir navegação entre as telas:  
- Tela inicial com menu de opções  
- Formulários dedicados para cada funcionalidade  

---

👩‍💻 Autores

Projeto desenvolvido em dupla:

Daiana Gilli
Ana Beatriz
