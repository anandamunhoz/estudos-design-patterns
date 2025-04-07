# Método Factory (Factory Method)

## Problema
Imagine que você está desenvolvendo uma aplicação que precisa criar objetos de diferentes tipos, mas você não sabe de antemão quais tipos de objetos serão necessários. Além disso, você deseja que a criação desses objetos seja flexível e extensível, permitindo a adição de novos tipos de objetos sem modificar o código existente.

## Solução
O padrão de projeto Factory Method resolve esse problema ao definir uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar. Isso permite que a criação de objetos seja delegada a subclasses, promovendo a flexibilidade e a extensibilidade do código.

## Como Implementar

1. **Defina uma interface ou classe abstrata que declare o método de fábrica**

2. **Implemente a interface ou classe abstrata em subclasses concretas que criam instâncias de objetos específicos**

3. **Defina a interface ou classe abstrata para os objetos que serão criados**

4. **Implemente a interface ou classe abstrata em classes concretas**

5. **Utilize o método de fábrica para criar objetos sem especificar a classe concreta**

    
## Conclusão

O padrão Factory Method permite que você crie objetos de maneira flexível e extensível, delegando a responsabilidade de criação para subclasses específicas. Isso promove a reutilização de código e facilita a manutenção e a adição de novos tipos de produtos.




    

    
    


    