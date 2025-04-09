# Padr�o Chain of Responsibility (Cadeia de Responsabilidade)

## Problema
Voc� est� desenvolvendo um sistema onde m�ltiplos objetos podem processar uma solicita��o, mas n�o deseja acoplar o remetente da solicita��o aos seus manipuladores. Al�m disso, voc� quer que os manipuladores sejam organizados em uma cadeia, permitindo que a solicita��o passe por cada um deles at� que seja processada.

Por exemplo, em um sistema de suporte t�cnico, uma solicita��o pode ser tratada por diferentes n�veis de suporte (n�vel 1, n�vel 2, etc.), dependendo da complexidade do problema.

## Solu��o
O padr�o Chain of Responsibility resolve esse problema ao permitir que m�ltiplos objetos tenham a chance de processar uma solicita��o. Ele organiza os manipuladores em uma cadeia, onde cada manipulador decide se processa a solicita��o ou a encaminha para o pr�ximo manipulador na cadeia.

## Como Implementar

1. **Defina uma interface ou classe base para os manipuladores:**
   - Essa interface deve declarar um m�todo para processar a solicita��o e um m�todo para definir o pr�ximo manipulador na cadeia.

2. **Implemente manipuladores concretos:**
   - Cada manipulador concreto deve decidir se processa a solicita��o ou a encaminha para o pr�ximo manipulador.

3. **Configure a cadeia de responsabilidade:**
   - Crie os manipuladores e conecte-os em uma cadeia.

4. **Envie a solicita��o para o primeiro manipulador da cadeia:**
   - A solicita��o ser� processada por um dos manipuladores ou passar� por toda a cadeia sem ser processada.

   
## Conclus�o
O padr�o Chain of Responsibility � �til para desacoplar o remetente de uma solicita��o de seus manipuladores, permitindo que m�ltiplos objetos tenham a chance de processar a solicita��o. Ele promove maior flexibilidade e extensibilidade, pois novos manipuladores podem ser adicionados � cadeia sem alterar o c�digo existente. Esse padr�o � ideal para cen�rios onde o processamento de uma solicita��o pode variar dinamicamente.


