# Padrão Bridge (Ponte)

## Problema
Você está desenvolvendo um sistema que precisa separar a abstração de sua implementação para que ambos possam ser desenvolvidos e evoluídos independentemente. Isso é especialmente útil quando você tem várias abstrações que podem ser combinadas com várias implementações, resultando em uma explosão de subclasses se não houver uma separação clara.

## Solução
O padrão Bridge resolve esse problema ao introduzir uma ponte entre a abstração e sua implementação. Ele desacopla as duas partes, permitindo que elas variem independentemente. A abstração mantém uma referência para a implementação, e as chamadas são delegadas para a implementação concreta.

## Como Implementar

1. **Defina uma interface para a implementação:**
   - Essa interface declara os métodos que as implementações concretas devem fornecer.

2. **Crie classes concretas que implementem a interface de implementação:**
   - Cada classe concreta fornece uma implementação específica.

3. **Defina uma classe abstrata para a abstração:**
   - Essa classe contém uma referência para a interface de implementação e delega as chamadas para ela.

4. **Crie subclasses concretas da abstração:**
   - Essas subclasses podem adicionar funcionalidades específicas, mas ainda delegam as chamadas para a implementação.

5. **Utilize a abstração e a implementação de forma independente:**
   - Combine diferentes abstrações com diferentes implementações conforme necessário.


## Conclusão
O padrão Bridge é útil para desacoplar abstrações de suas implementações, permitindo que ambas evoluam de forma independente. Ele reduz a complexidade do sistema, evita a explosão de subclasses e promove maior flexibilidade e reutilização de código.


