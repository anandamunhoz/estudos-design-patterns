# Padr�o Bridge (Ponte)

## Problema
Voc� est� desenvolvendo um sistema que precisa separar a abstra��o de sua implementa��o para que ambos possam ser desenvolvidos e evolu�dos independentemente. Isso � especialmente �til quando voc� tem v�rias abstra��es que podem ser combinadas com v�rias implementa��es, resultando em uma explos�o de subclasses se n�o houver uma separa��o clara.

## Solu��o
O padr�o Bridge resolve esse problema ao introduzir uma ponte entre a abstra��o e sua implementa��o. Ele desacopla as duas partes, permitindo que elas variem independentemente. A abstra��o mant�m uma refer�ncia para a implementa��o, e as chamadas s�o delegadas para a implementa��o concreta.

## Como Implementar

1. **Defina uma interface para a implementa��o:**
   - Essa interface declara os m�todos que as implementa��es concretas devem fornecer.

2. **Crie classes concretas que implementem a interface de implementa��o:**
   - Cada classe concreta fornece uma implementa��o espec�fica.

3. **Defina uma classe abstrata para a abstra��o:**
   - Essa classe cont�m uma refer�ncia para a interface de implementa��o e delega as chamadas para ela.

4. **Crie subclasses concretas da abstra��o:**
   - Essas subclasses podem adicionar funcionalidades espec�ficas, mas ainda delegam as chamadas para a implementa��o.

5. **Utilize a abstra��o e a implementa��o de forma independente:**
   - Combine diferentes abstra��es com diferentes implementa��es conforme necess�rio.


## Conclus�o
O padr�o Bridge � �til para desacoplar abstra��es de suas implementa��es, permitindo que ambas evoluam de forma independente. Ele reduz a complexidade do sistema, evita a explos�o de subclasses e promove maior flexibilidade e reutiliza��o de c�digo.


