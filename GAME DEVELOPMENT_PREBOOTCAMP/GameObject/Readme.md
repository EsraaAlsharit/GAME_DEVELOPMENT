# Assignment: GameObject
### Objectives:
- Practice Class creation.
- Practice Object instantiation.
- Experience an application where Inheritance and Polymorphism are both used.
##
Create below classes according to their specifications:

### 1. GameObject Class
### Properties:
- id - type int
- isActive - type bool
- name- type string
- components - type List<string>
Hint: List<string> components= new List<string>;  

### Public Methods: 
- CreateComponent -Takes one parameter of type string and Inserts the passed parameter name into the class's component list.
- PrintAllComponents - Prints the content of the components list
- GetComponent - Takes one parameter of type string representing the component name to check for, returns true if the component found inside the class's component list, otherwise false.
- GetName - Returns the object's name (virtual method)
- SetName - Takes one parameter of type string and sets the name property.
- SetIsActive - Takes one parameter of type bool and sets the isActive property.

### 2. Transform Class inherits GameObject Class
### Properties:
positionX : type int

positionY: type int

### Public Methods:
Translate: Increase the value of positionX and positionY by 1.

GetXPosition: Returns positionX value.

GetYPosition: Returns positionY value.

GetName(): Returns string with the word "I am a Transform".

### Main Method
Inside your main method do the following:

1. Create an instance of the GameObject class and use all the methods you implemented in the class, substitute values you see fit to make your methods work.
1. Create an instance of the Transform class, use all methods implemented as well. Make sure that GetName() method returns "I am a Transform".
**Code it all below!**
[https://dotnetfiddle.net/KRaI85](https://dotnetfiddle.net/KRaI85)


