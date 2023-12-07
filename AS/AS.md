**Sistema de Biblioteca utilizando Programação Orientada a Objetos (POO)**

---

**Introdução:**

Este documento tem como objetivo explicar a abordagem utilizada na implementação do sistema de biblioteca em C# utilizando os conceitos de Programação Orientada a Objetos (POO). A implementação consiste em três classes principais: `ItemBiblioteca` (classe base abstrata), `Livro` (classe derivada de `ItemBiblioteca`), e `Biblioteca` (gerenciadora de uma coleção de itens bibliotecários). Além disso, a classe `Program` é utilizada como ponto de entrada do sistema.

---

**Conceitos de POO Utilizados:**

1. **Classe e Objeto:**
   - **`ItemBiblioteca`**: Uma classe abstrata que serve como base para itens que podem ser armazenados em uma biblioteca. Propriedades como `Id` e `Titulo` são compartilhadas por todas as classes derivadas.
   - **`Livro`**: Uma classe derivada de `ItemBiblioteca` que representa um livro específico, com uma propriedade adicional, `Autor`.

2. **Herança:**
   - **`Livro` herda de ItemBiblioteca**: Isso permite que a classe `Livro` herde as propriedades e métodos da classe base `ItemBiblioteca`, promovendo a reutilização de código.

3. **Polimorfismo:**
   - **Métodos com Sobrecarga:**
      - `BuscarItemPorTitulo` e `BuscarItemPorId` na classe `Biblioteca`: Esses métodos são sobrecarregados para permitir a busca de itens na biblioteca por título ou ID.
      - `ExibirDescricaoInterna` no `Program`: Um método que pode funcionar de maneira diferente dependendo do tipo do item encontrado.

4. **Encapsulamento:**
   - **Propriedade Protegida:**
      - `DescricaoInterna` na classe `ItemBiblioteca` é protegida, permitindo acesso somente pelas classes derivadas. Isso encapsula a propriedade e controla o acesso.

5. **Composição:**
   - **`Biblioteca` contém uma coleção de `ItemBiblioteca`**: A classe `Biblioteca` é composta por uma lista de itens bibliotecários, permitindo a gestão eficiente dos itens.

---

**Explicação da Implementação:**

1. **`ItemBiblioteca`:**
   - Uma classe abstrata com propriedades compartilhadas por todos os itens bibliotecários.
   - A propriedade `DescricaoInterna` é protegida, encapsulando-a e permitindo acesso somente a classes derivadas.

2. **`Livro`:**
   - Uma classe derivada de `ItemBiblioteca` com uma propriedade adicional, `Autor`.
   - Possui um método específico, `ExibirDescricaoInterna`, que imprime a Descrição Interna do livro.

3. **`Biblioteca`:**
   - Gerencia uma coleção de itens bibliotecários.
   - Métodos para adicionar, remover e buscar itens por título ou ID.
   - Utiliza polimorfismo para adaptar o comportamento de busca conforme o tipo do item.

4. **`Program`:**
   - Ponto de entrada do sistema com um menu interativo.
   - Permite ao usuário adicionar, buscar e remover livros, além de exibir a Descrição Interna de um livro.

---

**Conclusão:**

A implementação do sistema de biblioteca em C# demonstra a aplicação prática de conceitos fundamentais de Programação Orientada a Objetos. O uso de herança, polimorfismo, encapsulamento e composição resulta em um código modular, reutilizável e de fácil manutenção.
