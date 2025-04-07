# Método Abstrato (Abstract Method)

## Problema
Imagine que você está desenvolvendo uma aplicação que precisa criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. Você deseja garantir que os objetos criados sejam compatíveis entre si e que a criação de novas famílias de objetos seja fácil e flexível.

## Solução
O padrão de projeto Abstract Method resolve esse problema ao fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. Isso permite que a criação de objetos seja delegada a classes concretas que implementam a interface, garantindo a compatibilidade entre os objetos criados.

## Como Implementar

1. **Defina uma interface ou classe abstrata para a fábrica que declara métodos para criar cada tipo de objeto:**
 
2. **Implemente a interface ou classe abstrata em subclasses concretas que criam instâncias de objetos específicos:**

3. **Defina interfaces ou classes abstratas para os objetos que serão criados:**

4. **Implemente as interfaces ou classes abstratas em classes concretas de objetos:**

5. **Utilize a fábrica abstrata para criar famílias de objetos sem especificar suas classes concretas:**



## Conclusão
O padrão Abstract Method permite que você crie famílias de objetos relacionados ou dependentes de maneira flexível e extensível, delegando a responsabilidade de criação para classes concretas específicas. Isso promove a compatibilidade entre os objetos criados e facilita a manutenção e a adição de novas famílias de produtos.




