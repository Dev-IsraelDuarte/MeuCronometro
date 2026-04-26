# ⏱️ MeuCronometro - Cronômetro Digital em C#

<div align="center">
  <img src="https://via.placeholder.com/600x300?text=Screenshot+do+Cronometro" alt="Preview do MeuCronometro" width="500">
  <p><i>Interface do cronômetro desenvolvida em C# Windows Forms</i></p>
</div>

[cite_start]Este projeto consiste em uma aplicação desktop funcional desenvolvida em C# (Windows Forms) que oferece um cronômetro com precisão de milissegundos[cite: 3]. [cite_start]O objetivo é fornecer uma ferramenta prática para contagem de tempo com funcionalidades de registro de voltas[cite: 3].

## 🚀 Funcionalidades

* [cite_start]**Iniciar**: Começa a contagem do tempo real [cite: 49] [cite_start]e a atualização da interface[cite: 51].
* [cite_start]**Pausar**: Interrompe a contagem [cite: 54] [cite_start]e a atualização da tela[cite: 56].
* [cite_start]**Zerar**: Reseta o contador interno [cite: 59][cite_start], limpa a tela [cite: 60] [cite_start]e o histórico de voltas[cite: 61].
* [cite_start]**Marcar Volta**: Registra o tempo atual em uma lista enquanto o cronômetro roda[cite: 66, 69].
* [cite_start]**Precisão**: Exibição formatada em Horas, Minutos, Segundos e Milissegundos (`00:00:00.000`)[cite: 77].

## 🛠️ Ferramentas Necessárias

* [cite_start]**IDE**: Visual Studio (Community 2022 ou superior)[cite: 4].
* [cite_start]**Carga de Trabalho**: "Desenvolvimento para desktop com .NET"[cite: 4].
* [cite_start]**Framework**: Windows Forms (.NET Framework ou .NET Core/5+)[cite: 9, 10].

## 🏗️ Estrutura do Projeto

### Componentes da Interface

<table width="100%">
  <tr>
    <th>Componente</th>
    <th>Nome (ID)</th>
    <th>Texto/Função</th>
  </tr>
  <tr>
    <td><b>Label</b></td>
    <td><code>lblTempo</code></td>
    <td>Exibe o tempo formatado[cite: 16].</td>
  </tr>
  <tr>
    <td><b>Button</b></td>
    <td><code>btnIniciar</code></td>
    <td>Inicia o cronômetro[cite: 17].</td>
  </tr>
  <tr>
    <td><b>Button</b></td>
    <td><code>btnPausar</code></td>
    <td>Pausa a contagem[cite: 17].</td>
  </tr>
  <tr>
    <td><b>Button</b></td>
    <td><code>btnZerar</code></td>
    <td>Zera o contador e a tela[cite: 17].</td>
  </tr>
  <tr>
    <td><b>Button</b></td>
    <td><code>btnVolta</code></td>
    <td>Registra voltas na lista[cite: 17].</td>
  </tr>
  <tr>
    <td><b>ListBox</b></td>
    <td><code>lstVoltas</code></td>
    <td>Exibe o histórico de voltas[cite: 17].</td>
  </tr>
  <tr>
    <td><b>Timer</b></td>
    <td><code>timer1</code></td>
    <td>Atualiza a UI a cada 10ms[cite: 17].</td>
  </tr>
</table>

---
[cite_start]*Projeto baseado no guia passo a passo para criação de cronômetros digitais[cite: 1, 2].*