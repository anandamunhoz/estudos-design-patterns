# M�todo Factory (Factory Method)

## Problema
Imagine que voc� est� desenvolvendo uma aplica��o que precisa criar objetos de diferentes tipos, mas voc� n�o sabe de antem�o quais tipos de objetos ser�o necess�rios. Al�m disso, voc� deseja que a cria��o desses objetos seja flex�vel e extens�vel, permitindo a adi��o de novos tipos de objetos sem modificar o c�digo existente.

## Solu��o
O padr�o de projeto Factory Method resolve esse problema ao definir uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar. Isso permite que a cria��o de objetos seja delegada a subclasses, promovendo a flexibilidade e a extensibilidade do c�digo.

## Como Implementar

1. **Defina uma interface ou classe abstrata que declare o m�todo de f�brica**

2. **Implemente a interface ou classe abstrata em subclasses concretas que criam inst�ncias de objetos espec�ficos**

3. **Defina a interface ou classe abstrata para os objetos que ser�o criados**

4. **Implemente a interface ou classe abstrata em classes concretas**

5. **Utilize o m�todo de f�brica para criar objetos sem especificar a classe concreta**

    
## Conclus�o

O padr�o Factory Method permite que voc� crie objetos de maneira flex�vel e extens�vel, delegando a responsabilidade de cria��o para subclasses espec�ficas. Isso promove a reutiliza��o de c�digo e facilita a manuten��o e a adi��o de novos tipos de produtos.




    

    
    


    