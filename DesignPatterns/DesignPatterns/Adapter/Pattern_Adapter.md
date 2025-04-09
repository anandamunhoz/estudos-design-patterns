# Adapter (Adaptador)

## Problema
Imagine que voc� est� desenvolvendo um sistema que precisa integrar componentes ou classes com interfaces incompat�veis. Por exemplo, voc� pode estar trabalhando com uma biblioteca de terceiros ou um sistema legado que n�o pode ser modificado, mas precisa utiliz�-lo em conjunto com o restante do seu c�digo. A incompatibilidade de interfaces pode dificultar ou at� mesmo impossibilitar essa integra��o.

## Solu��o
O padr�o de projeto Adapter resolve esse problema ao criar uma classe intermedi�ria (o adaptador) que converte a interface de uma classe em outra interface esperada pelo sistema. Isso permite que classes incompat�veis trabalhem juntas sem a necessidade de alterar seu c�digo original.

## Como Implementar

1. **Identifique as interfaces incompat�veis:**
   Determine quais classes ou componentes precisam ser integrados, mas possuem interfaces diferentes.

2. **Crie uma interface-alvo:**
   Defina a interface que o sistema espera que seja utilizada.

3. **Implemente o adaptador:**
   Crie uma classe que implemente a interface-alvo e delegue as chamadas para a classe ou componente existente, adaptando os m�todos conforme necess�rio.

4. **Utilize o adaptador no sistema:**
   Substitua o uso direto da classe incompat�vel pelo adaptador, garantindo que o sistema interaja apenas com a interface-alvo.

   
## Conclus�o
O padr�o Adapter � uma solu��o eficaz para integrar classes ou componentes com interfaces incompat�veis. Ele promove a reutiliza��o de c�digo existente, reduz a necessidade de modifica��es em classes originais e melhora a flexibilidade do sistema. Esse padr�o � especialmente �til ao trabalhar com bibliotecas de terceiros ou sistemas legados.



