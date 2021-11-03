# Padroes de projeto

- https://refactoring.guru/design-patterns/catalog
- https://www.dofactory.com/net/design-patterns

Gang of Four (GOF) - criado por 4 desenvolvedores

## Catalogo design patterns

- **_Creational_** - Criacionais: Fornecem meios de criação de um objeto e de como ele será instanciado.
	- **Abstract Factory**: Cria uma instância de diversas familias de classes - Fabrica de Fabrica.
		- Prós:
			- pode ter certeza que os produtos que você obtém de uma fábrica são compatíveis entre si.
			- evita um vínculo forte entre produtos concretos e o código cliente.
			- Princípio de responsabilidade única. Você pode extrair o código de criação do produto para um lugar, fazendo o código ser de fácil manutenção.
			- Princípio aberto/fechado. Você pode introduzir novas variantes de produtos sem quebrar o código cliente existente.
		- Contras:
			- O código pode tornar-se mais complicado do que deveria ser, uma vez que muitas novas interfaces e classes são introduzidas junto com o padrão.
	
	- **Factory Method**: Cria uma instancia de diversas derivações de classes.
		- Prós:
			- Evita acoplamentos firmes entre o criador e os produtos concretos.
			- Princípio de responsabilidade única. Você pode mover o código de criação do produto para um único local do programa, facilitando a manutenção do código.
			- Princípio aberto/fechado. Você pode introduzir novos tipos de produtos no programa sem quebrar o código cliente existente.	
		- Contras:
			- O código pode se tornar mais complicado, pois você precisa introduzir muitas subclasses novas para implementar o padrão. O melhor cenário é quando você está introduzindo o padrão em uma hierarquia existente de classes criadoras.
	
	- **Singleton**: Cria uma unica instancia que será utilizada por todos os recursos.
		- Prós:
			- Pode ter certeza que uma classe só terá uma única instância.
			- Ganha um ponto de acesso global para aquela instância.
			- O objeto singleton é inicializado somente quando for pedido pela primeira vez.
		- Contras:
			- Viola o princípio de responsabilidade única. O padrão resolve dois problemas de uma só vez.
			- O padrão Singleton pode mascarar um design ruim, por exemplo, quando os componentes do programa sabem muito sobre cada um.
			-  O padrão requer tratamento especial em um ambiente multithreaded para que múltiplas threads não possam criar um objeto singleton várias vezes.
			-  Pode ser difícil realizar testes unitários do código cliente do Singleton porque muitos frameworks de teste dependem de herança quando produzem objetos simulados. Já que o construtor da classe singleton é privado e sobrescrever métodos estáticos é impossível na maioria das linguagem, você terá que pensar em uma maneira criativa de simular o singleton. Ou apenas não escreva os testes. Ou não use o padrão Singleton.
	
	- **Builder**: Permite construir objetos complexos passo a passo.
		- Prós:
			- Pode construir objetos passo a passo, adiar as etapas de construção ou rodar etapas recursivamente.
			- Pode reutilizar o mesmo código de construção quando construindo várias representações de produtos.
			- Princípio de responsabilidade única. Você pode isolar um código de construção complexo da lógica de negócio do produto.
		- Contras:
			- A complexidade geral do código aumenta uma vez que o padrão exige criar múltiplas classes novas.

- **_Structural_** - Estruturais: Tratam da composição de objetos por heranças e interfaces para diferentes funcionalidades.
	- **Adapter**: Compatibiliza objetos de interface diferentes. 
		- Prós:
			- Princípio de responsabilidade única. Você pode separar a conversão de interface ou de dados da lógica primária do negócio do programa.
			- Princípio aberto/fechado. Você pode introduzir novos tipos de adaptadores no programa sem quebrar o código cliente existente, desde que eles trabalhem com os adaptadores através da interface cliente.
		- Contras:
			- A complexidade geral do código aumenta porque você precisa introduzir um conjunto de novas interfaces e classes. Algumas vezes é mais simples mudar a classe serviço para que ela se adeque com o resto do seu código.

	- **Facade**: Uma única classe que representa um subsistema
		- Prós:
			- Pode isolar seu código da complexidade de um subsistema.
		- Contras:
			- Uma fachada pode se tornar um "objeto deus" acoplado a todas as classes de uma aplicação.

	- **Composite**: Compartilha um objeto em estruturas de árvores que representam hierarquias.
		- Prós:
			- Pode trabalhar com estruturas de árvore complexas mais convenientemente: utilize o polimorfismo e a recursão a seu favor.
			- Princípio aberto/fechado. Você pode introduzir novos tipos de elemento na aplicação sem quebrar o código existente, o que agora funciona com a árvore de objetos.
		- Contras:
			- Pode ser difícil providenciar uma interface comum para classes cuja funcionalidade difere muito. Em certos cenários, você precisaria generalizar muito a interface componente, fazendo dela uma interface de difícil compreensão.

	- **Decorator**: Permite que você acople novos comportamentos para objetos ao colocá-los dentro de invólucros de objetos que contém os comportamentos.
		- Prós:
			- Pode estender o comportamento de um objeto sem fazer um nova subclasse.
			- Pode adicionar ou remover responsabilidades de um objeto no momento da execução.
			- Pode combinar diversos comportamentos ao envolver o objeto com múltiplos decoradores.
			- Princípio de responsabilidade única. Você pode dividir uma classe monolítica que implementa muitas possíveis variantes de um comportamento em diversas classes menores.
		- Contras:
			- É difícil remover um invólucro de uma pilha de invólucros.
			- É difícil implementar um decorador de tal maneira que seu comportamento não dependa da ordem do pilha de decoradores.
			- A configuração inicial do código de camadas pode ficar bastante feia.

- **_Behavorial_** - Comportamentais: Tratam das interações e comunicação entre os objetos além da divisão de responsabilidades.
	- **Command**: Encapsula um command request em um objeto
		- Prós:
			- Princípio de responsabilidade única. Você pode desacoplar classes que invocam operações de classes que fazem essas operações.
			- Princípio aberto/fechado. Você pode introduzir novos comandos na aplicação sem quebrar o código cliente existente.
			- Pode implementar desfazer/refazer.
			- Pode implementar a execução adiada de operações.
			- Pode montar um conjunto de comandos simples em um complexo.
		- Contras:
			- O código pode ficar mais complicado uma vez que você está introduzindo uma nova camada entre remetentes e destinatários.

	- **Strategy**: Encapsula um algoritmo dentro de uma classe
		- Prós:
			- Pode trocar algoritmos usados dentro de um objeto durante a execução.
			- Pode isolar os detalhes de implementação de um algoritmo do código que usa ele.
			- Pode substituir a herança por composição.
			- Princípio aberto/fechado. Você pode introduzir novas estratégias sem mudar o contexto.
		- Contras:
			- Se você só tem um par de algoritmos e eles raramente mudam, não há motivo real para deixar o programa mais complicado com novas classes e interfaces que vêm junto com o padrão.
			- Os Clientes devem estar cientes das diferenças entre as estratégias para serem capazes de selecionar a adequada.
			- Muitas linguagens de programação modernas tem suporte do tipo funcional que permite que você implemente diferentes versões de um algoritmo dentro de um conjunto de funções anônimas. Então você poderia usar essas funções exatamente como se estivesse usando objetos estratégia, mas sem inchar seu código com classes e interfaces adicionais.

	- **Observer**: Uma forma de notificar mudanças a uma série de classes
		- Prós:
			- Princípio aberto/fechado. Você pode introduzir novas classes assinantes sem ter que mudar o código da publicadora (e vice versa se existe uma interface publicadora).
			- Pode estabelecer relações entre objetos durante a execução.
		- Contras:
			- Assinantes são notificados em ordem aleatória.

### Outros Design Patterns:
- Rules Design Patterns
- Dependency Injection
- Intercepting filter
- Lazy loading
- Mock object
- Method chaining
- Inversion of control
- Unit of Work

### Padrões arquiteturais:
- Interceptor
- Model View Controler (MVC)
- Model View ViewModel (MVVM)
- Model View Presenter (MVP)
- Specification
- Publish–subscribe
- Inversion of control