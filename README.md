OOP Questions

JavaScript is a multi-paradigm language, meaning (That means it supports multiple programming styles, not just one.)

Procedural Programming (Step-by-step): Code runs line by line like instructions.
function cookMaggi() {
    console.log("Boil water");
    console.log("Add noodles");
    console.log("Cook for 2 minutes");
}

cookMaggi();

Functional programming : Functions are treated like values (you can pass them, return them).
function greet(name) {
    return "Hello " + name;
}

function processUser(fn) {
    console.log(fn("Sameer"));
}

processUser(greet);

Object-oriented programming : You use objects and classes to organize code.
class Car {
    constructor(name) {
        this.name = name;
    }

    drive() {
        console.log(this.name + " is driving");
    }
}

const myCar = new Car("BMW");
myCar.drive();

Event-Driven Programming : Code runs when something happens (click, input, etc.)

document.getElementById("btn").addEventListener("click", function () {
    console.log("Button clicked!");
});
Prototype-based OOP under the hood

==============================================================================================================================

What is Object-Oriented Programming?

Object oriented programming is the way to write code that revolve around the concept of object (Object are the instance of classes and classes are the blue-prient or template) that contain:

Data (properties) what object has: color , model
Function (action/actions) what object do : start() , stop()

const car = {
  color: "red",
  model: 2025,

  start() {
    console.log("car start");
  },

  stop() {
    console.log("car stop");
  }
};

==============================================================================================================================

What are the 4 pillars of OOP? Explain briefly.

Encapsolation : hiding the data and restriction the access

Inheritence : child class use the properties of parent class

Polymorphisn : same funtion (method) behave different in different class

Abstraction : A key concept to hide internal detail and show only necessary things

==============================================================================================================================

What is Encapsulation? Give a real-world example.

Encapsulation is the concept of wrapping(hinding) data (variables) and methods (functions) together in a single unit (class) and restricting direct access to some of the data.


class BankAccount {
  #balance;

  constructor(balance) {
    this.#balance = balance;
  }

  deposit(amount) {
    this.#updateBalance(amount); // calling private method
  }

  #updateBalance(amount) {
    if (amount > 0) {
      this.#balance += amount;
    }
  }

  getBalance() {
    return this.#balance;
  }
}
const acc = new BankAccount(1000);

acc.deposit(500);
console.log(acc.getBalance());  1500
acc.#updateBalance(100);  ❌ ERROR

==============================================================================================================================

What is Inheritance? Why do we use it?

Inheritance is a concept where one class (child) acquires(take) the properties and methods of another class (parent or super-class).

class Parent {
  #privateVar = "PRIVATE";    ❌ not inherited
  _protectedVar = "PROTECTED";   inherited (by convention)
  publicVar = "PUBLIC";      inherited

  getPrivate() {
    return this.#privateVar;  access private via method
  }
}

class Child extends Parent {
  show() {
    console.log(this.publicVar);       works
    console.log(this._protectedVar);   works

    console.log(this.#privateVar); ❌ ERROR

    console.log(this.getPrivate());   works (via method)
  }
}

const obj = new Child();
obj.show();
 
==============================================================================================================================

What is Polymorphism? Types?

Polymorphism means 'many forms' — the same method or function can behave differently in different situations.

class Animal {
  speak() {
    console.log("Animal makes a sound");
  }
}

class Dog extends Animal {
  speak() {
    console.log("Dog barks");  different behavior
  }
}

class Cat extends Animal {
  speak() {
    console.log("Cat meows");  different behavior
  }
}

// same method, different outputs
const animals = [new Animal(), new Dog(), new Cat()];

animals.forEach(a => a.speak());

==============================================================================================================================

Types of Polymorphism?

1. Compile-time Polymorphism (phase where source code translate into machine code) static .
Achieved by: Method Overloading (same method name, different parameters).

class Calculator {
  add(a, b, c) {
    if (c !== undefined) {
      return a + b + c;  3 parameters
    }
    return a + b;  2 parameters
  }
}

const calc = new Calculator();

console.log(calc.add(2, 3));      5
console.log(calc.add(2, 3, 4));   9

JavaScript does not support true method overloading directly.We simulate it using:
if/else
arguments
default values

2. Runtime Polymorphism (Dynamic) phase when code execute/ run on machine.
Achieved by:Method Overriding Child class provides its own implementation of a parent method

==============================================================================================================================

What is Abstraction?

Abstraction is key concept in programming where hiding the complex implementation details and showing only the essential features to the user.
it help you focus what a object can do not how to do.

class Car {
    startEngine() {
        this.#checkEngine();
        this.#fuelInjection();
        console.log("Car started");
    }

    #checkEngine() {
        console.log("Checking engine...");
    }

    #fuelInjection() {
        console.log("Injecting fuel...");
    }
}

const car = new Car();
car.startEngine();

==============================================================================================================================

Difference between Abstract Class vs Interface

==============================================================================================================================

What is a constructor?

A sepcial method that runs automatically when a object is created.

class Person {
  constructor(name) {  
    this.name = name;
  }
}

const p1 = new Person("Sameer");

console.log(p1.name); 

==============================================================================================================================

Types of constructor?
Default Constructor :A constructor with no parameters .Provides default values

class Person {
  constructor() {
    this.name = "Unknown";
  }
}

const p = new Person();
console.log(p.name); // Unknown

Parameterized Constructor: Takes arguments to initialize values

class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }
}

const p = new Person("Sameer", 22);
console.log(p.name, p.age);  Sameer 22

Copy Constructor (conceptual, not native in JS)
Used to create a new object from an existing object
JavaScript doesn’t support it directly, but we can simulate it

Constructor overloading?
Same class has multiple constructors with different parameters.

class Person {
    String name;
    
     Person() {
        console.log("Sameer)
    }
    
    Person(String name) {
        this.name = name;
    }
}

==============================================================================================================================

What is method overloading vs overriding?

Overloading : same method name different paremeters.its Happen within the same class (two funtion with same name in one class ). The program decide which method is call before running (complie time) Note js not support method overloading.

class Calculator {
  add(a, b, c) {
    if (c !== undefined) {
      return a + b + c;    3 parameters
    }
    return a + b;    2 parameters
  }
}

const calc = new Calculator();

console.log(calc.add(2, 3));      5
console.log(calc.add(2, 3, 4));   9

Overriding : Child class changes parent method.(so that we Customize behavior in child class)

class Dog {
  speak() {
    console.log("Dog barks");
  }
}

class Cat extends Dog { 
  speak() {
    console.log("Cat speaks");  
  }
}

const d = new Dog();
const c = new Cat();

d.speak();  Dog barks
c.speak();  Cat speaks

==============================================================================================================================

What is the difference between class and object?

classes are the blueprient(Template) and object are there instance(single occurrence of something.).

class Student {

   constractor(name , age , roll){
      this.name = name
      this.age = age
      this.roll = rool
   }
}
const s = new Student ("Sameer" , 24 , F279)

==============================================================================================================================

What is composition vs inheritance? Which is better and why?

Inheritance = IS-A
Composition = HAS-A
Composition means building something by combining smaller parts (behaviors).One object uses or contains other objects (instead of inheriting).

const canEat = {
    eat() {
        console.log("Eating");
    }
};

const dog = {
    name: "Tommy",
    ...canEat
};

class example of composition 
class Engine {
    start() {
        console.log("Engine started");
    }
}

class Car {
    constructor() {
        this.engine = new Engine();  composition
    }

    startCar() {
        this.engine.start();
    }
}

const car = new Car();
car.startCar();

More flexible
Easier to change
Less complicated
Avoids tight coupling (objects depend less on each other)
Inheritance

One object uses or contains other objects (instead of inheriting).
class Animal {
    eat() {
        console.log("Eating");
    }
}

class Dog extends Animal {
    bark() {
        console.log("Barking");
    }
}

const d = new Dog();
d.eat();  // inherited
d.bark();

==============================================================================================================================

What is tight coupling vs loose coupling?

==============================================================================================================================

What is SOLID principles? Name them.

SOLID is a set of 5 design principles used in OOP to write clean, maintainable, and scalable code.

1. S — Single Responsibility Principle (SRP): One class = One job
A class should have only one reason to change.
Each class or module should do one thing only. If a class handles both user authentication and email sending, those are two responsibilities — split them up.

class User {   Bad
  saveToDB() {}
  showUI() {}
  calculateAge() {}
}    


class User {
  constructor(name) {
    this.name = name;
  }
}

class UserDB {
  save(user) {}
}

class UserUI {
  show(user) {}
}


2 — Open/Closed Principle (OCP)

Code should be open for extension but closed for modification
You should add new features without changing existing code.

3. L — Liskov Substitution Principle (LSP) : Child should work like parent
Child classes should be able to replace parent classes without breaking the app
If a parent class works, child class should also work correctly in its place

4. I — Interface Segregation Principle (ISP)
Don’t force a class to implement methods it doesn’t use
Split large interfaces into smaller, specific ones
Don't force a class to use methods it doesn't need. Keep interfaces small and focused.


5. D — Dependency Inversion Principle (DIP)
Depend on abstractions (interfaces), not on concrete implementations
High-level modules should not depend on low-level modules directly
Write your code against a general idea (interface), not a specific tool. That way you can swap tools later without rewriting everything.

==============================================================================================================================

Explain Single Responsibility Principle with example.

A class should have only one responsibility and only one reason to change.
❌ Wrong idea:
One class doing multiple jobs (e.g., logic + database + logging)
class User {
    constructor(name) {
        this.name = name;
    }
}

class UserRepository {
    save(user) {
        console.log("Saving user to database");
    }
}

class EmailService {
    sendEmail(user) {
        console.log("Sending email to user");
    }
}


==============================================================================================================================

What is Dependency Injection?

==============================================================================================================================

What is method overriding and why use it?

Method overriding happens when a child class provides its own implementation of a method that already exists in the parent class.
The method name stays the same, but the behavior is changed in the child class.

class Animal {
    speak() {
        console.log("Animal makes a sound");
    }
}

class Dog extends Animal {
    speak() {
        console.log("Dog barks");
    }
}

const d = new Dog();
d.speak();

==============================================================================================================================

What is static keyword?

Static methods belong to class, not object (mean we call them with out make the object of that class).

class MathHelper {
  static add(a, b) {
    return a + b;
  }
}

console.log(MathHelper.add(2, 3));  5 

 ❌ Wrong
 const obj = new MathHelper();
 obj.add(2,3); ERROR

==============================================================================================================================

What is this keyword?

Refers to the current object context. (object data)

class Person {
  constructor(name) {
    this.name = name;
  }

  show() {
    console.log(this.name);
  }
}

const p = new Person("Sameer");
p.show();  Sameer

==============================================================================================================================

What is access modifier (public, private, protected)?

1. Public: Accessible everywhere
2. Private (#): Accessible only inside the class
3. Protected (_): Accessible in class + child class (in JS it's just convention)

class Parent {
  publicVar = "Public";       everywhere
  _protectedVar = "Protected";  convention
  #privateVar = "Private";    ❌ only inside class

  showPrivate() {
    return this.#privateVar;  access inside class
  }
}

class Child extends Parent {
  show() {
    console.log(this.publicVar);      
    console.log(this._protectedVar);  

    console.log(this.#privateVar); ❌ ERROR

    console.log(this.showPrivate());  
  }
}

const obj = new Child();
obj.show();

==============================================================================================================================

What is object cloning / copying?

Object cloning (copying) means creating a duplicate of an object so that you can use it independently without affecting the original object.

Types of Copying

1. Shallow Copy

Copies only the top-level properties. Nested objects are still shared (same reference)
const obj1 = {
    name: "Sameer",
    address: {
        city: "Lahore"
    }
};

const obj2 = { ...obj1 };

obj2.name = "Ali";
obj2.address.city = "Karachi";

console.log(obj1.name); Sameer 
console.log(obj1.address.city); Karachi ❌ (shared reference)

2. Deep Copy

Copies everything recursively. No shared references
const obj1 = {
    name: "Sameer",
    address: {
        city: "Lahore"
    }
};

const obj2 = JSON.parse(JSON.stringify(obj1));

obj2.address.city = "Karachi";

console.log(obj1.address.city);  Lahore  

==============================================================================================================================

What is abstraction vs encapsulation?

Abstraction focuses on hiding complexity, while encapsulation focuses on hiding data.

Encapsulation: Protects data by restricting direct access and controlling it through methods
In one line:
Abstraction = hiding implementation
class Car {
  start() {
    this._igniteEngine();
    console.log("Car started");
  }

  // hidden/internal method (not meant to be used directly)
  _igniteEngine() {
    console.log("Engine ignition process...");
  }
}

const myCar = new Car();
myCar.start();
Encapsulation = hiding data
class BankAccount {
  #balance = 0;  private variable

  deposit(amount) {
    if (amount > 0) {
      this.#balance += amount;
    }
  }

  getBalance() {
    return this.#balance;
  }
}

const account = new BankAccount();

account.deposit(100);
console.log(account.getBalance());  100

 ❌ Not allowed
 console.log(account.#balance);  SyntaxError
 
==============================================================================================================================

Can we achieve abstraction without abstract classes? How?

==============================================================================================================================

What is interface, and why use it?

An interface is like a promise / contract.
Any class that uses me MUST implement these methods.
An interface is a contract that defines what methods a class should have, without providing the implementation.

interface Animal {
    void makeSound(); // only declaration
}
In simple words:
It tells what to do, but not how to do it.
does NOT have full code (usually)

interface Payment {
  pay(): void;
}

class JazzCash implements Payment {
  pay(): void {
    console.log("Paid using JazzCash");
  }
}

class EasyPaisa implements Payment {
  pay(): void {
    console.log("Paid using EasyPaisa");
  }
}

const p1: Payment = new JazzCash();
p1.pay();

==============================================================================================================================

What is abstract class (real use case)?
An abstract class is a class that:

cannot be created directly
is used as a base (parent) class
can have:
abstract methods (no body)
normal methods (with code)

abstract class Animal {
     abstract method (no body)
  abstract makeSound(): void;

     normal method
  sleep() {
    console.log("Sleeping...");
  }
}
const a = new Animal();  ❌ Error

Must extend it..
class Dog extends Animal {
  makeSound() {
    console.log("Bark");
  }
}

const d = new Dog();
d.makeSound();  Bark
d.sleep();      from parent

An abstract class is a class that cannot be instantiated and is used as a base class. It can contain both abstract methods (without implementation) and concrete methods (with implementation), allowing code reuse and enforcing structure.

==============================================================================================================================

What is constructor chaining?

Constructor chaining is the process of calling one constructor from another constructor to reuse initialization logic.
In class inheritance, constructor chaining happens using super().

class Animal {
  constructor(name) {
    this.name = name;
    console.log("Animal constructor");
  }
}

class Dog extends Animal {
  constructor(name, breed) {
    super(name); calls parent constructor
    this.breed = breed;
    console.log("Dog constructor");
  }
}

const d = new Dog("Tommy", "Labrador");
console.log(d);

==============================================================================================================================

Can we overload constructors? Explain.

Constructor overloading is supported in languages like Java, C++, and C# through multiple constructors with different parameter lists, but JavaScript does not support it and instead uses default parameters or conditional logic.

==============================================================================================================================

What is runtime polymorphism?

==============================================================================================================================

What is upcasting and downcasting?

==============================================================================================================================

What is the use of super keyword?

The super keyword is used in classes to refer to the parent (base) class.

It is mainly used for two purposes:

Calling the parent class constructor
Accessing parent class methods

class Animal {
  constructor(name) {
    this.name = name;
  }
}

class Dog extends Animal {
  constructor(name, breed) {
    super(name);  calls parent constructor
    this.breed = breed;
  }
}

const d = new Dog("Tommy", "Labrador");
console.log(d);

==============================================================================================================================

What is final keyword (variable, method, class)?

The final keyword is used to restrict modification: a final variable cannot be reassigned, a final method cannot be overridden, and a final class cannot be extended.

==============================================================================================================================

What problem does abstraction solve in real-world apps?

==============================================================================================================================

What is interface segregation principle?

==============================================================================================================================

Explain real-world use of polymorphism in backend systems?

class Logger {
  log(message) {}
}

class FileLogger extends Logger {
  log(message) {
    console.log("Saving to file:", message);
  }
}

class DBLogger extends Logger {
  log(message) {
    console.log("Saving to database:", message);
  }
}

==============================================================================================================================

What happens if multiple classes implement same interface?

If multiple classes implement the same interface, each class must follow the same contract, but can provide its own implementation.

 Interface = rule
 Classes = different ways to follow the rule
interface Payment {
  pay(amount: number): void;
}

class JazzCash implements Payment {
  pay(amount: number) {
    console.log("Paid using JazzCash:", amount);
  }
}

class EasyPaisa implements Payment {
  pay(amount: number) {
    console.log("Paid using EasyPaisa:", amount);
  }
}

==============================================================================================================================

What is immutability? Why is it important?

Immutability means not modifying existing data but creating new copies. It helps in writing predictable, bug-free, and maintainable code.
let arr = [1, 2, 3];

❌ mutable
arr.push(4);
✅ immutable
let newArr = [...arr, 4];

==============================================================================================================================

What design pattern have you used? (e.g., Singleton, Factory)

==============================================================================================================================

How does loose coupling improve scalability?

==============================================================================================================================
What is interface-based design?

==============================================================================================================================
Difference between aggregation vs composition
Aggregation is a weak association where objects can exist independently, while composition is a strong association where one object owns and controls the lifecycle of another.

==============================================================================================================================

What is method hiding vs overriding?
Overriding → same method, different behavior (instance)
Hiding → same static method name, child hides parent method





==============================================================================================================================

What is diamond problem in OOP?

==============================================================================================================================

What are getters and setters? Why use them?

Getters and setters are special methods in JavaScript used to read (get) and update (set) object properties in a controlled way. They are defined using the get and set keywords. Instead of being called like normal functions, they are accessed like properties. The getter automatically returns a value when a property is read, and the setter automatically sets a value when a property is assigned. This allows developers to control, validate, and manage data while keeping a clean and simple interface.

const user = {
    name: "Sameer",
    getName() {
        return this.name;
    }
};

console.log(user.getName());   must call ()
get and set
class User {
    constructor(name) {
        this._name = name;
    }

    get name() {
        return this._name;
    }

    set name(value) {
        this._name = value;
    }
}

const user = new User("Sameer");
console.log(user.name); 
etter in action (auto runs)
user.fullName = "John Doe";
automatically calls getter , auto-executes (no ())
 
Why Use Them?
 Validation
 Encapsulation
 Clean API
 Computed values

==============================================================================================================================

What is the difference between proto and prototype?

A prototype is an internal object that every JavaScript object automatically receives. It allows objects to inherit properties and methods from a parent object.

let obj = {};
console.log(obj.__proto__);

__proto__(Link point to prototype) is a hidden property of an object that points to its prototype (the parent object).

Prototype chain?

Every object has a prototype, and that prototype can also have its own prototype. This is called the prototype chain

When you try to access a property or method:

JavaScript first looks in the object itself.
If not found, it checks the object's prototype.
Then it checks the prototype’s prototype.
This continues until it reaches null.


Key Points
__proto__ points to the prototype of an object.
prototype is a property of constructor functions and classes.
The prototype is used to define methods that can be shared across all instances.
__proto__ is used internally to link objects in the prototype chain.


class Student {
  sayHi() {
    console.log("Hello World");
  }
}

const s = new Student();
s.sayHi();

Methods defined inside a class are automatically added to Student.prototype.
Instances like s access these methods through their __proto__ link.

==============================================================================================================================

What is the purpose of the instanceof operator?

The instanceof operator is used to check whether an object is created from a specific constructor or class.
It tells you if an object belongs to a particular class (or constructor function) in its prototype chain.

class Person {}

const p = new Person();

console.log(p instanceof Person);  true

==============================================================================================================================

How do you implement multiple inheritance in JavaScript?

==============================================================================================================================

What are the different types of inheritance?

1. Single Inheritance: One class inherits from one parent class.

class Animal {
  eat() {
    console.log("Eating");
  }
}

class Dog extends Animal {}

const d = new Dog();
d.eat();  inherited

2. Multilevel Inheritance:  A class inherits from a class, which itself inherits from another class.

class Animal {
  eat() {
    console.log("Eating...");
  }
}

class Dog extends Animal {
  bark() {
    console.log("Barking...");
  }
}

class Puppy extends Dog {
  weep() {
    console.log("Weeping...");
  }
}

const puppy = new Puppy();
puppy.eat();    from Animal
puppy.bark();   from Dog
puppy.weep();   own

3. Hierarchical Inheritance: Multiple classes inherit from the same parent.

 class Animal {
  eat() {
    console.log("Eating...");
  }
}

class Dog extends Animal {
  bark() {
    console.log("Barking...");
  }
}

class Cat extends Animal {
  meow() {
    console.log("Meowing...");
  }
}

const dog = new Dog();
const cat = new Cat();

dog.eat();  from Animal
cat.eat();  from Animal

4. Multiple Inheritance (using Mixins in JS): A class inherits from more than one class.
5. 
const CanEat = {
  eat() {
    console.log("Eating...");
  }
};

const CanWalk = {
  walk() {
    console.log("Walking...");
  }
};

class Person {}

Object.assign(Person.prototype, CanEat, CanWalk);

const p = new Person();
p.eat();
p.walk();

==============================================================================================================================

Error vs Exception?

-> A error is unexpected error that stop the program like divide by zero , network request fail , invalid json.
Safely way to catch the excepition is to use try catch block.

-> soemthing very wrong you usaully cannot fix in runtime.
Mistake in code.
You cannot recover with try catch block.
You must fix code.
