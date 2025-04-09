# Padrão Chain of Responsibility (Cadeia de Responsabilidade)

## Problema
Você está desenvolvendo um sistema onde múltiplos objetos podem processar uma solicitação, mas não deseja acoplar o remetente da solicitação aos seus manipuladores. Além disso, você quer que os manipuladores sejam organizados em uma cadeia, permitindo que a solicitação passe por cada um deles até que seja processada.

Por exemplo, em um sistema de suporte técnico, uma solicitação pode ser tratada por diferentes níveis de suporte (nível 1, nível 2, etc.), dependendo da complexidade do problema.

## Solução
O padrão Chain of Responsibility resolve esse problema ao permitir que múltiplos objetos tenham a chance de processar uma solicitação. Ele organiza os manipuladores em uma cadeia, onde cada manipulador decide se processa a solicitação ou a encaminha para o próximo manipulador na cadeia.

## Como Implementar

1. **Defina uma interface ou classe base para os manipuladores:**
   - Essa interface deve declarar um método para processar a solicitação e um método para definir o próximo manipulador na cadeia.

2. **Implemente manipuladores concretos:**
   - Cada manipulador concreto deve decidir se processa a solicitação ou a encaminha para o próximo manipulador.

3. **Configure a cadeia de responsabilidade:**
   - Crie os manipuladores e conecte-os em uma cadeia.

4. **Envie a solicitação para o primeiro manipulador da cadeia:**
   - A solicitação será processada por um dos manipuladores ou passará por toda a cadeia sem ser processada.

   
## Conclusão
O padrão Chain of Responsibility é útil para desacoplar o remetente de uma solicitação de seus manipuladores, permitindo que múltiplos objetos tenham a chance de processar a solicitação. Ele promove maior flexibilidade e extensibilidade, pois novos manipuladores podem ser adicionados à cadeia sem alterar o código existente. Esse padrão é ideal para cenários onde o processamento de uma solicitação pode variar dinamicamente.


