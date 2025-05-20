# Fake Data Maker

**Fake Data Maker** é uma aplicação web desenvolvida com Blazor WebAssembly e MudBlazor para geração de dados fictícios customizáveis por setor da economia, idioma e volume. É ideal para testes de sistemas, prototipação de dashboards e simulação de cenários.

## 🔧 Tecnologias Utilizadas
- [Blazor WebAssembly (Framework de front-end baseado em HTML, CSS e C#)](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [MudBlazor (Biblioteca de componentes)](https://www.mudblazor.com/)
- [Bogus (Para gerar de dados fake)](https://github.com/bchavez/Bogus)
- [ClosedXML (Para gerar arquivos .xlsx)](https://docs.closedxml.io/en/latest/)
- [CsvHelper (Para gerar arquivos .csv)](https://joshclose.github.io/CsvHelper/)

## 📝 Funcionalidades
- Geração de dados por setor (ex: contábil, aeroespacial)
- Suporte a múltiplos idiomas (ex: pt-BR, en-US, fr-FR)
- Exportação para os formatos:
  - `.csv`
  - `.xlsx`
  - `.sql` (com `CREATE TABLE` e `INSERTs`)
- Interface responsiva e amigável com MudBlazor

## ⚙️ Como Executar o Projeto
1. Clone o repositório:
```bash
git clone https://github.com/andredobbss/FakeDataMaker.git
```
2. Abra com o Visual Studio 2022+ ou VS Code com suporte a Blazor
3. Execute o projeto com dotnet run ou pelo IDE

## 🚨 Pré-requisitos
.NET 8 SDK
Navegador moderno (Chrome, Edge, Firefox)

## 🌐 Aplicação Publicada em:
```bash
https://fakedatamaker.pages.dev/
```

## 📷 Capturas de Tela

![image](https://github.com/user-attachments/assets/a67d9358-9d1d-437d-9a21-c9b0d68a7eee)

![image](https://github.com/user-attachments/assets/12bbe301-4729-46e1-9327-cc59c2d1b331)

## 📄 Licença
Este projeto está licenciado sob a licença MIT.

Desenvolvido por André Dobbss
