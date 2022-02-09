# Introdução C#
Informações básicas sobre a linguagem C#!
## Tipos de variáveis

### Tipos de valor
Definição: Uma _variável_ é um espaço na memória do computador destinado a um dado que é_alterado durante a execução do algoritmo. Elas possuem os dados de fato, diretamente.

- **Numéricos**: sbyte, short, int, long, byte, ushort, uint, ulong
- **Caracteres Unicode**: char
- **Pontos flutuantes**: float, double, decimal
- **Booleano**: bool
- **Outros**: enum, struct e nullable (**int?**:pode ser nullo)

### Tipos de referência
Definição: armazenam apenas **referências** a seus dados. É possível que duas variáveis façam referência ao mesmo objeto e, portanto, que operações nas variáveis afetem o objeto referenciado por elas.

- **_Tipo classe_**: class, object, string
- **_Tipo classe_**: int[], int[,]
- **Outros**: inteface, delegate

## Instruções
Ações de um programa são expressas usando instruções.

- **Declarações**
- **if**
- **while**
- **switch**
- **do**
- **for**
- **foreach**
- **return**
- **break**
- **continue**
- **using**
- **try .. catch ... finally**

### Arrays

São estruturas de dados de tamanho pré-definido que possuem um conjunto de
dados do mesmo tipo. Sua leitura de inicia em 0 e vai até tamanho-1.