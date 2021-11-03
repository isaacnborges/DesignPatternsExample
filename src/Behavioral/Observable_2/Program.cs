using Observable_2;

Console.WriteLine("*** Observable 2 ***");
Console.WriteLine();

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Subscribe(observerA);

var observerB = new ConcreteObserverB();
subject.Subscribe(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.UnSubscribe(observerB);

subject.SomeBusinessLogic();