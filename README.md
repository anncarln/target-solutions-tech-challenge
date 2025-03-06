# target-solutions-tech-challenge
# 🚀 Target Solutions - Desafio Técnico

Este repositório contém as soluções para o desafio técnico da **Target Solutions**, desenvolvidas em **C#/.NET**. O objetivo é resolver cada questão proposta aplicando boas práticas de programação, organização de código e lógica de desenvolvimento.

---

## 📌 Sobre o Projeto
O projeto foi estruturado como uma aplicação **Console App** para facilitar a execução e a escolha de qual desafio testar. Todas as questões estão separadas em classes organizadas na pasta `src/Desafios`.

---

## 📂 Estrutura do Repositório
📁 `TargetSolutions-TechChallenge/`  
&nbsp;&nbsp; ├── 📁 `src/` *(Código-fonte das respostas)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── 📁 `Desafios/` *(Pasta onde cada questão tem sua própria classe)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao1.cs` *(Soma de números até 13)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao2.cs` *(Verificação na sequência de Fibonacci)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao3.cs` *(Análise de faturamento diário com JSON)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao4.cs` *(Percentual de faturamento por estado)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao5.cs` *(Inversão de strings sem métodos prontos)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Program.cs` *(Ponto de entrada do programa - Menu interativo)*  
&nbsp;&nbsp; ├── 📁 `data/` *(Armazena o JSON de faturamento)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `dados.json` *(Dados do faturamento diário - Questão 3)*  
&nbsp;&nbsp; ├── `.gitignore` *(Arquivos desnecessários para o repositório)*  
&nbsp;&nbsp; ├── `README.md` *(Instruções sobre o repositório e como rodar o projeto)*  

---

## 🛠️ Configuração do Projeto

### 🔹 **Pré-requisitos**
- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download) instalado
- Editor de código como **Visual Studio Code** ou **Visual Studio**
- Git instalado para versionamento

### 🔹 **Instalação**
1. **Clone o repositório**:
   ```sh
   git clone https://github.com/seu-usuario/target-solutions-tech-challenge.git
   

📝 Explicação das Soluções
✅ Questão 1 - Soma de Números
Calcula a soma dos números de 1 a 13 usando um laço while.
Arquivo: Questao1.cs
✅ Questão 2 - Verificação de Fibonacci
Recebe um número e verifica se ele pertence à sequência de Fibonacci.
Arquivo: Questao2.cs
✅ Questão 3 - Análise de Faturamento Diário
Lê um arquivo JSON com valores de faturamento diário.
Calcula o menor e maior faturamento, além de quantos dias ficaram acima da média.
Arquivo: Questao3.cs
JSON utilizado: data/dados.json
✅ Questão 4 - Percentual de Faturamento por Estado
Calcula e exibe o percentual de faturamento de cada estado dentro do faturamento total.
Arquivo: Questao4.cs
✅ Questão 5 - Inversão de String
Recebe uma string do usuário e inverte os caracteres sem usar métodos prontos (Reverse()).
Arquivo: Questao5.cs