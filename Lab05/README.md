# OOP-Principles

A small app intended to explore the four OOP principles + interfaces

Inheritance - The idea that a class acn inherit behavior and properties from another class. In C# there is only a single path of inheritance but we can use Interfaces to add behavior to multiple classes that have already inherited from another class.

Abstraction - The concept that a class can exist as a template for other classes to build off of. Abstract classes cannot instantiate objects but can give behavior and properties to their derived classes.

Polymorphisum - That idea that we can overide a method or proprty that has been inherited to fit the use case. A virtual method can also be overiden but comes with a default implimentation. 

Encapsulation - The practice of adding access modifiers to properties and methods that limit access to them. Public allows anybody to access the data. Private means only that class can reach the data. Protected means that class and all it's derived classes can access the data. internal means any class within the assembly can access the data. Protected internal means only derived classes that exist within the assembly can access the data.'

## Getting Started

This is a small test app using visual studio 2017. 
You will also need xunit testing. 
You will need to install and run VS2017 in order to run and use the app.

## Features

This is an example hierarchy that includes inheritance abstraction and ecapsulation. I created a Zoo based ont the D&D 5th edition monster manual. At the top is the abstract class attraction. The monster types are derived from attraction into Beast and Monstrosity. Monstrosity is further derived into the abstract Fiend. Beast has two concreate classes Plesiosaurus, and Monkey while Monstrosity has DisplacerBeast. Fiend has Dopplganger, Dragon and ShockerLizzard.

Dragon and ShockerLizzard impliment ItremorSense
DisplacerBeast and Dragin impliment IDarkvision

In the next lab we then added interfaces to our zoo.

![DnDZoo]DnDZoo.jpg

## Resources and Links

I worked with:
Amanda Iverson
Miya Lucas

I also leveraged Stack overflow and the 7.0 in a nutshell publication. 

## Licensing

The code in this project is licensed under MIT license.
