<div align="center">

# 🎧 HelpDesk

### *Algo deu errado? Abra um chamado e a gente resolve.*

Um sistema desktop para **abrir, acompanhar e resolver chamados** de suporte técnico de forma simples e organizada.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-B84FE8?style=for-the-badge)

</div>

---

## 📖 Sobre o projeto

**HelpDesk** é um aplicativo desktop que centraliza os pedidos de suporte técnico em um só lugar. Em vez de problemas perdidos em conversas e e-mails, cada solicitação vira um **chamado** com título, descrição, prioridade e status, do momento em que é aberto até ser resolvido.

A ideia é simples: o usuário descreve o problema, abre o chamado, e a equipe de suporte acompanha e atualiza o andamento até a solução.

O projeto nasceu como uma forma de praticar **desenvolvimento de sistemas** e **arquitetura de software** na prática, separando tela, regras e dados em camadas bem definidas.

## 🎯 Para quem é

| Público | Como o app ajuda |
|---|---|
| 🙋 **Solicitantes** | Abrir chamados e acompanhar o andamento sem depender de recados |
| 🛠️ **Equipe de suporte** | Visualizar, priorizar e resolver os chamados com organização |
| 👔 **Gestores** | Ter visão geral do que está aberto, em andamento e resolvido |

---

## ✨ Ideias e funcionalidades

- [x] 🎫 **Abertura de chamados** com título, descrição e prioridade
- [x] 📊 **Controle de status**: aberto, em andamento e resolvido
- [x] 🧱 **Camadas de Models e Data** funcionando
- [ ] 🔎 **Busca e filtros** por status, prioridade e data
- [ ] 👥 **Perfis de usuário**: solicitante, técnico e administrador
- [ ] 📝 **Histórico** de interações em cada chamado
- [ ] 📈 **Painel** com resumo dos chamados
- [ ] 📄 **Relatórios** em PDF

> ✏️ *Marque com [x] só o que já está pronto no seu projeto e apague o que não existir.*

---

## 🖼️ Telas

> Adicione aqui as capturas de tela do app (veja a dica no final do arquivo).

<div align="center">

| Tela de login | Painel de chamados |
|:---:|:---:|
| ![Login](docs/tela-login.png) | ![Painel](docs/tela-painel.png) |

| Novo chamado | Detalhes do chamado |
|:---:|:---:|
| ![Novo chamado](docs/tela-novo-chamado.png) | ![Detalhes](docs/tela-detalhes.png) |

</div>

---

## 🏗️ Arquitetura

O projeto segue a ideia de **separar responsabilidades**: cada camada faz uma coisa só e conversa apenas com a vizinha.

```
┌─────────────────────────────┐
│   Interface (Windows Forms) │   ← o que o usuário vê e clica
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Services                  │   ← regras: abrir, filtrar e atualizar chamados
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Data                      │   ← acesso ao banco de dados
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Models                    │   ← o formato de um Chamado e de um Usuário
└─────────────────────────────┘
```

### 📐 Modelo de dados

Cada chamado possui:

| Campo | Descrição |
|---|---|
| `Id` | Identificador único do chamado |
| `Titulo` | Resumo do problema |
| `Descricao` | Detalhes do que está acontecendo |
| `Prioridade` | Baixa, média, alta ou crítica |
| `Status` | Aberto, em andamento ou resolvido |
| `DataAbertura` | Quando o chamado foi criado |
| `Solicitante` | Quem abriu o chamado |

---

## 🛠️ Tecnologias

- **C#** com **.NET**
- **Windows Forms** para a interface desktop
- **SQL Server** para armazenar os chamados
- **Git e GitHub** para versionamento
- **Asana** para organizar e planejar as tarefas

---

## 🚀 Como executar

**Pré-requisitos:** Windows, [.NET SDK](https://dotnet.microsoft.com/download), Visual Studio 2022 ou superior e SQL Server (a versão Express já serve).

```bash
# 1. Clone o repositório
git clone https://github.com/viniciuscury147-spec/HelpDesk.git

# 2. Entre na pasta
cd HelpDesk

# 3. Crie o banco de dados executando o script SQL da pasta database/

# 4. Ajuste a connection string com o seu servidor

# 5. Abra a solução no Visual Studio e pressione F5
```

---

## 🧭 Roadmap

```
✅ Definir tema, público e dados
✅ Criar modelos e acesso ao banco
✅ Desenhar telas de abertura de chamado
🔜 Busca e filtros
🔜 Perfis de usuário
🔜 Histórico do chamado
🔜 Relatórios em PDF
```

---

## 👨‍💻 Autor

Feito com 💜 por:

<div align="center">

| 👤 **Vinicius Cury** |
|:---:|
| [![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat-square&logo=github&logoColor=white)](https://github.com/viniciuscury147-spec) |
| [![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=flat-square&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/vinicius-cury-258896324/) |

</div>

---

<div align="center">

*HelpDesk: cada problema, um chamado; cada chamado, uma solução.* 🎧

</div>
