# Garbage Collector

Fornece suporte para a criação e destruição de objetos na Heap.

GitHub: https://github.com/ricardovicentini/Reference-Type-And-Value-Type

# Vantagens

- Segurança: dispositivo evita falhas.
- Menor preocupação: programador não se preocupa com a liberação de memória.
- Evita a sobrescrita de memória.


# Desvantagens

- Performance: sempre buscando verificar se a Heap está correta (é possível desligar o GC).
- Observabilidade: não sabe o que pode prejudicar ou não a performance.

# Gerações

- **Gen 1** 
	- Objetos tem ciclo de vida curto: limpeza mais simples.
- **Gen 2** 
	- Buffer de alternância entre Gen 1 e Gen 3. Conforme o uso maior ou menos de algum Objeto.
- **Gen 3** 
	- Objetos tem ciclo de vida longo: em especial Objetos static. Alto custo.
