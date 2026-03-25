# 📅 Sistema de Gestão de Eventos - PIM V

Este projeto é uma aplicação Web desenvolvida para o **PIM V (Projeto Integrado Multidisciplinar)** do curso de Análise e Desenvolvimento de Sistemas. O objetivo é gerenciar o ciclo de vida de eventos, desde o cadastro de atividades até o controle de participantes e inscrições.

O projeto evoluiu de uma aplicação de console para uma interface **Blazor Web** moderna, utilizando C# de ponta a ponta.

---

## 🚀 Funcionalidades

- **Dashboard Inicial:** Visão geral amigável do sistema.
- **Cadastro de Eventos:** Interface reativa para agendamento de novos eventos com validação em tempo real.
- **Listagem de Eventos:** Visualização organizada de todos os eventos registrados no sistema.
- **Arquitetura Reutilizável:** Uso dos mesmos modelos de dados (Models) para lógica de negócio e interface.

---

## 🛠️ Tecnologias Utilizadas

- **C# 12 / .NET 8**
- **Blazor Web App** (Interactive Server Mode)
- **Bootstrap 5** (Design Responsivo)
- **Npgsql** (Driver para futura integração com PostgreSQL)

---

## 📂 Estrutura do Projeto

O projeto segue a estrutura padrão do Blazor, com foco na separação de responsabilidades:

- `/Models`: Contém as classes de negócio (`Evento.cs`, `Participante.cs`, `Inscricao.cs`, etc).
- `/Components/Pages`: Contém as telas da aplicação (`CadastroEvento.razor`, `ListaEventos.razor`).
- `/Components/Layout`: Contém o menu de navegação e o design principal do site.

---

## ⚙️ Como Executar o Projeto

1. **Pré-requisitos:**
   - Possuir o [SDK do .NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.
