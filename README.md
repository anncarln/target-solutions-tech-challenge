# target-solutions-tech-challenge
# Target Solutions - Desafio Técnico

Este repositório contém as soluções para o desafio técnico da **Target Solutions**, desenvolvidas em **C#/.NET**. O objetivo é resolver cada questão proposta aplicando boas práticas de programação, organização de código e lógica de desenvolvimento.

---

## Sobre o Projeto
O projeto foi estruturado como uma aplicação **Console App** para facilitar a execução e a escolha de qual desafio testar. Todas as questões estão separadas em classes organizadas na pasta `src/Desafios`.

---

## Estrutura do Repositório
`TargetSolutions-TechChallenge/`  
&nbsp;&nbsp; ├── `src/` *(Código-fonte das respostas)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Desafios/` *(Pasta onde cada questão tem sua própria classe)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao1.cs` *(Soma de números até 13)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao2.cs` *(Verificação na sequência de Fibonacci)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao3.cs` *(Análise de faturamento diário com JSON)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao4.cs` *(Percentual de faturamento por estado)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Questao5.cs` *(Inversão de strings sem métodos prontos)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `Program.cs` *(Ponto de entrada do programa - Menu interativo)*  
&nbsp;&nbsp; ├── `data/` *(Armazena o JSON de faturamento)*  
&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp; ├── `dados.json` *(Dados do faturamento diário - Questão 3)*  
&nbsp;&nbsp; ├── `.gitignore` *(Arquivos desnecessários para o repositório)*  
&nbsp;&nbsp; ├── `README.md` *(Instruções sobre o repositório e como rodar o projeto)* 

---

## Configuração do Projeto

### **Pré-requisitos**
- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download) instalado
- Editor de código como **Visual Studio Code** ou **Visual Studio**
- Git instalado para versionamento

### **Instalação**
1. **Clone o repositório**:
   ```sh
   git clone https://github.com/seu-usuario/target-solutions-tech-challenge.git
2. **Acesse o diretório do projeto**:
    ```sh
    cd target-solutions-tech-challenge/TargetSolutions
3. **Instale as dependências**:
    ```sh
    dotnet restore
### **Como executar o projeto**
1. **Entre na pasta do projeto**:
    ```sh
    cd TargetSolutions
2. **Execute o programa**
    ```sh
    dotnet run
3. **Escolha uma opção no menu interativo**
    ```diff
    === Desafio Técnico - Target Solutions ===
    Escolha uma questão para executar:
    1 - Questão 1
    2 - Questão 2
    3 - Questão 3
    4 - Questão 4
    5 - Questão 5
    0 - Sair
    Opção: