# Projeto GestãoEnergia: Aplicação de POO em C#

O projeto **GestãoEnergia** foi desenvolvido com base nas aulas de **Programação Orientada a Objetos (POO)**, com o objetivo de aplicar de forma prática os principais conceitos dessa abordagem utilizando a linguagem **C#**.  
O projeto explora os princípios de **Encapsulamento**, **Composição**, **Responsabilidade Única (SRP)** e **Abstração**, refletindo boas práticas de modelagem e organização de código.

A estrutura é composta pelas classes **`ContaDeEnergia`** e **`Imovel`**, demonstrando a aplicação dos conceitos de POO conforme o diagrama UML a seguir.

---

## Diagrama UML
<img width="1682" height="718" alt="DiagramaV1" src="https://github.com/user-attachments/assets/3b9ebcd2-ceed-4d94-bde3-fc7e35f54ab5" />



---

## Princípios Aplicados

### Encapsulamento
Todos os atributos de estado (por exemplo, `_codigoRegistro`, `_contas`) são **privados**, garantindo que o acesso e a modificação dos dados ocorram apenas por meio de **métodos e propriedades públicas** (por exemplo, `CodigoRegistro => _codigoRegistro`).  
Essa prática assegura a **integridade dos dados** e evita modificações indevidas no estado interno dos objetos.

---

### Composição
A classe **`Imovel`** mantém internamente uma lista de objetos **`ContaDeEnergia`** (`List<ContaDeEnergia>`), estabelecendo uma relação de **composição “tem-um”** — ou seja, **um imóvel possui diversas contas de energia**.  
Essa relação reforça o **baixo acoplamento** entre as classes e promove uma **estrutura modular e coesa**.

---

### Responsabilidade Única (SRP)
A classe **`ContaDeEnergia`** é responsável exclusivamente pelos **cálculos de consumo e tarifas**.  
A classe **`Imovel`**, por sua vez, trata da **agregação e análise das contas**, implementando métodos como `CalcularValorMedio`.  
Essa separação garante que cada classe possua uma **única responsabilidade**, facilitando a manutenção e a evolução do sistema.

---

### Abstração
Métodos como **`ResumoAnual`**, presentes na classe **`Imovel`**, utilizam os resultados de **`ContaDeEnergia.ValorTotal`** sem conhecer os detalhes internos de seu cálculo (como tarifas, impostos e encargos adicionais).  
Dessa forma, o sistema mantém **simplicidade de uso** e **clareza de propósito**, seguindo os princípios de uma boa abstração.
