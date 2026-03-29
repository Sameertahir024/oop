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
console.log(acc.getBalance()); // 1500
acc.#updateBalance(100); // ❌ ERROR

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
Types of inheritence?


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
console.log(p.name, p.age); // Sameer 22

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

What is the difference between class and object?
classes are the blueprient and object are there instance.
class student {
constractor(name , age , roll){
this.name = name
this.age = age
this.roll = rool
}
}
const stu = new student ("sameer" , 24 , F279)


What is composition vs inheritance? Which is better and why?'
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
        this.engine = new Engine(); // composition
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
What is tight coupling vs loose coupling?

What is SOLID principles? Name them.
SOLID is a set of 5 design principles used in OOP to write clean, maintainable, and scalable code.
The 5 SOLID Principles
1. S — Single Responsibility Principle (SRP)
 A class should have only one reason to change
 It should do only one job
Example idea:
User class should not handle database + UI + logic together

2 — Open/Closed Principle (OCP)

Code should be open for extension but closed for modification
You should add new features without changing existing code

3. L — Liskov Substitution Principle (LSP)
4.  Child classes should be able to replace parent classes without breaking the app
If a parent class works, child class should also work correctly in its place

4. I — Interface Segregation Principle (ISP)

Don’t force a class to implement methods it doesn’t use
Split large interfaces into smaller, specific ones

5. D — Dependency Inversion Principle (DIP)

Depend on abstractions (interfaces), not on concrete implementations
High-level modules should not depend on low-level modules directly

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

What is Dependency Injection?

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

What is static keyword?
Static methods belong to class, not object (mean we call them with out make the object of that class).
class person {
static name (){
console.log("sameer)
}
}
person.name()
What is this keyword?
Refers to the current object context.
class Person {
constructor (name){
this.name = name
}
show (){
console.log(this.name)
}
}
const p= new Person("sameer")


What is access modifier (public, private, protected)?

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

console.log(obj1.name); // Sameer ✅ (independent)
console.log(obj1.address.city); // Karachi ❌ (shared reference)

Deep Copy
Copies everything recursively. No shared references
const obj1 = {
    name: "Sameer",
    address: {
        city: "Lahore"
    }
};

const obj2 = JSON.parse(JSON.stringify(obj1));

obj2.address.city = "Karachi";

console.log(obj1.address.city); // Lahore ✅ (independent)

What is abstraction vs encapsulation?
Abstraction focuses on hiding complexity, while encapsulation focuses on hiding data.

Abstraction: Shows only essential features and hides how something works
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
  #balance = 0; // private variable

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
console.log(account.getBalance()); // 100

// ❌ Not allowed
// console.log(account.#balance); // SyntaxError

Can we achieve abstraction without abstract classes? How?

What is interface, and why use it?
An interface is a contract that defines what methods a class should have, without providing the implementation.

In simple words:
It tells what to do, but not how to do it.

Difference between interface vs abstract class (real use case)?

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
    super(name); // calls parent constructor
    this.breed = breed;
    console.log("Dog constructor");
  }
}

const d = new Dog("Tommy", "Labrador");
console.log(d);

Can we overload constructors? Explain.
Constructor overloading is supported in languages like Java, C++, and C# through multiple constructors with different parameter lists, but JavaScript does not support it and instead uses default parameters or conditional logic.”

What is runtime polymorphism?

What is upcasting and downcasting?

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
    super(name); // calls parent constructor
    this.breed = breed;
  }
}

const d = new Dog("Tommy", "Labrador");
console.log(d);

What is final keyword (variable, method, class)?
The final keyword is used to restrict modification: a final variable cannot be reassigned, a final method cannot be overridden, and a final class cannot be extended.”

What problem does abstraction solve in real-world apps?

What is interface segregation principle?
Explain real-world use of polymorphism in backend systems
What happens if multiple classes implement same interface?
What is immutability? Why is it important?
What design pattern have you used? (e.g., Singleton, Factory)
How does loose coupling improve scalability?
What is interface-based design?
Difference between aggregation vs composition
Aggregation is a weak association where objects can exist independently, while composition is a strong association where one object owns and controls the lifecycle of another.

What is method hiding vs overriding?
Overriding → same method, different behavior (instance)
Hiding → same static method name, child hides parent method

What is diamond problem in OOP?

How does JavaScript handle OOP differently from Java?

What are getters and setters? Why use them?
Getters and setters are special methods in JavaScript used to read (get) and update (set) object properties in a controlled way. They are defined using the get and set keywords. Instead of being called like normal functions, they are accessed like properties. The getter automatically returns a value when a property is read, and the setter automatically sets a value when a property is assigned. This allows developers to control, validate, and manage data while keeping a clean and simple interface.
normal fun 
const user = {
    name: "Sameer",
    getName() {
        return this.name;
    }
};

console.log(user.getName()); // ✅ must call ()
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
// Setter in action (auto runs)
user.fullName = "John Doe";
// ✅ automatically calls getter// ✅ auto-executes (no ())
Why Use Them?
 Validation
 Encapsulation
 Clean API
 Computed values

Explain real-world backend architecture using OOP concepts
	What is a Static Method in JavaScript?
	What is the difference between proto and prototype?
	What is the purpose of the instanceof operator?
	How do you implement multiple inheritance in JavaScript?
	What are the different types of inheritance?
