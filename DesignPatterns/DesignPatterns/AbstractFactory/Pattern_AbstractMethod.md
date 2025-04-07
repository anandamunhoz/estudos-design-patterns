# M�todo Abstrato (Abstract Method)

## Problema
Imagine que voc� est� desenvolvendo uma aplica��o que precisa criar fam�lias de objetos relacionados ou dependentes sem especificar suas classes concretas. Voc� deseja garantir que os objetos criados sejam compat�veis entre si e que a cria��o de novas fam�lias de objetos seja f�cil e flex�vel.

## Solu��o
O padr�o de projeto Abstract Method resolve esse problema ao fornecer uma interface para criar fam�lias de objetos relacionados ou dependentes sem especificar suas classes concretas. Isso permite que a cria��o de objetos seja delegada a classes concretas que implementam a interface, garantindo a compatibilidade entre os objetos criados.

## Como Implementar

1. **Defina uma interface ou classe abstrata para a f�brica que declara m�todos para criar cada tipo de objeto:**
 
2. **Implemente a interface ou classe abstrata em subclasses concretas que criam inst�ncias de objetos espec�ficos:**

3. **Defina interfaces ou classes abstratas para os objetos que ser�o criados:**

4. **Implemente as interfaces ou classes abstratas em classes concretas de objetos:**

5. **Utilize a f�brica abstrata para criar fam�lias de objetos sem especificar suas classes concretas:**



## Conclus�o
O padr�o Abstract Method permite que voc� crie fam�lias de objetos relacionados ou dependentes de maneira flex�vel e extens�vel, delegando a responsabilidade de cria��o para classes concretas espec�ficas. Isso promove a compatibilidade entre os objetos criados e facilita a manuten��o e a adi��o de novas fam�lias de produtos.




