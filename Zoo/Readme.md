## Create A Zoo
One of the thing that make C# such a powerful language is the fact that we have object oriented programming. In object oriented programming we have classes. We can have many classes do many different things. One of the ways we are learning is to build out a Zoo which makes a hierarchy class

## Author:
Tiger Hsu

## Version:
2.0.0 

## Overview
Build out a structure of a zoo within Visual Studio and a digital diagram.
Examples are used to under-stand classes in C#.

<li> Inheritance - One of the main pillars of object oriented programming, closely matches derived
Think of a parent giving a child blue eyes and black hair. The child inherits the items from the parent.

<li> Polymorphism - Another pillar of object oriented, instead of direct inheritence can pick an choose which methods and properties 
to have. Class shapes can decide to adopt items of properties from derived classes but dont have to. Take for instance a class shape that has the values x,y,z. So the next class triangle has the ability to have a 

Class Shape.cs -> {x, y, z} / virtual 
                Class Triangle {using x,y,z} / 
                Class  Circle {useOnly y } / Override

<li> Abstraction -Pillar of Ojbect Oriented programming, classes can inherit later on but must be filled out by each class
Class Parent.cs -> {hasblueEyes, hasBlack hair} -> Child.cs {hasblueEyes, hasBlack hair} -> GreatGrandChild.cs {unkown color yet}

<li> Ecapsulation -> last pillar of Objec Oriented Programming; security apect of it
Class Person.cs {}
Public -> anyone can see person.cs 
Private -> Private Class person.cs / I dont want anyone to see me
Protected Internal -> Only certain things that can be looked at if ou have the access rights.



## Getting Started
- Fork this repo / or clone this repo
- Download Microsoft Visual Studio Community Edition 2017
- Open Visual Studio 2017
- Open this file name 
- Select run program.cs

## Example

![alt text](/Zoo/PokemonSnip.JPG)

## Architecture
This  Program uses C# and the .NET Core 2.0 platform

## Credits
Aurther Allen <br>
Kevin Farrow <br>
Brent William <br>
Philip Werner <br>
Josh Taylor <br>
Amanda Iverson <br>

## Resources
StackoverFlow
Microsoft Docs

## License
MIT License

## Change Log

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
