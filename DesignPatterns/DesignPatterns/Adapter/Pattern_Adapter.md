# Adapter (Adaptador)

## Problema
Imagine que você está desenvolvendo um sistema que precisa integrar componentes ou classes com interfaces incompatíveis. Por exemplo, você pode estar trabalhando com uma biblioteca de terceiros ou um sistema legado que não pode ser modificado, mas precisa utilizá-lo em conjunto com o restante do seu código. A incompatibilidade de interfaces pode dificultar ou até mesmo impossibilitar essa integração.

## Solução
O padrão de projeto Adapter resolve esse problema ao criar uma classe intermediária (o adaptador) que converte a interface de uma classe em outra interface esperada pelo sistema. Isso permite que classes incompatíveis trabalhem juntas sem a necessidade de alterar seu código original.

## Como Implementar

1. **Identifique as interfaces incompatíveis:**
   Determine quais classes ou componentes precisam ser integrados, mas possuem interfaces diferentes.

2. **Crie uma interface-alvo:**
   Defina a interface que o sistema espera que seja utilizada.

3. **Implemente o adaptador:**
   Crie uma classe que implemente a interface-alvo e delegue as chamadas para a classe ou componente existente, adaptando os métodos conforme necessário.

4. **Utilize o adaptador no sistema:**
   Substitua o uso direto da classe incompatível pelo adaptador, garantindo que o sistema interaja apenas com a interface-alvo.

   
## Conclusão
O padrão Adapter é uma solução eficaz para integrar classes ou componentes com interfaces incompatíveis. Ele promove a reutilização de código existente, reduz a necessidade de modificações em classes originais e melhora a flexibilidade do sistema. Esse padrão é especialmente útil ao trabalhar com bibliotecas de terceiros ou sistemas legados.



