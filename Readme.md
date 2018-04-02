# Lab05 Phil Werner

## Build A Zoo
A program to show how Class inheritence works. There is a base Animal
Class that the Mammal, Reptile and Avian classes inherit from. Those
Classes both have additional classes that inherit from them. See the below
diagram for a more in depth inheritence flow.

## OOP Principles
1. Inheritence - Classes derive properties from the base class or other classes
above it in the heirarchy. If the class ```Animal``` has a property of ```NumberOfLegs```,
the class ```Mammal``` "inherits" that property from it.

2. Abatraction - Sometimes a class will have properties or methods that there is not
yet enough information for it yet. So you can then create a Abstract class that cannot
be instantiated, because of the lack of information. These abstract classes can also
have abstract properties or methods, which need to be overrided at or before the first
Concrete class.

3. Polymorphism - This occurs during override, it is the concept that multiple classes
can have the same property or method, but it might be different for all the different
derived classes.

4. Encapsulation - The grouping of properties and methods within a single object/class.
This gives us the ability to create private properties within our classes. 

## Tools Used
Microsoft Visual Studio Community Version 15.5.7

C#

ASP.Net

xUnit

## Getting Started

Clone this repository to your local machine.
```
$ git clone 
```
Once downloaded, cd into the ```Lab05-OOP-Principles``` directory.
```
$ cd Lab05-OOP-Principles
```
The cd into ```BuildAZoo``` directory.
```
$ cd BuildAZoo
```
The cd into the second ```BuildAZoo``` directory.
```
$ cd BuildAZoo
```
Then run .NET build.
```
$ dotnet build
```
Once that is complete, run the program.
```
$ dotnet run
```

## Diagram Of Inheritence

![Build A Zoo Diagram](https://github.com/philipwerner/Lab05-OOP-Principles/blob/lab05-phil/OOP_Examples/BuildAZoo.jpg)
