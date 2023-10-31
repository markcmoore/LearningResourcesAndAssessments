
# Inheritance Challenge 2 - Employees, Bosses and Trainees
1. Create a main class with a Main Method, 
2. Create a base class Employee with the properties and methods
    - string Name, 
    - string FirstName, 
    - int Salary
    - Work()    // Prints that they're working (Ex: I'm working. I am an employee. It's what we do.)
    - Pause()   // Prints that they are taking a break (Ex: I'm taking a break. I'm only human.)
    - The class should have a no args contructor that sets the Employee's firstname to be Mark, last name to be Moore, and salary to be 25000
3. Create a deriving class Boss:Employee with the additional property and method
    - string CompanyCar // what type of car they have 
    - Lead() // prints what job they have 
4. Create another deriving class Trainee:Employee with the additional properties and method 
    - int WorkingHours // how many hours per week they work
    - int SchoolHourse // how many hours per week they study  
    - Learn() // tells how many hours they work and study
5. Override the Work() method of the Trainee class so that it indicates the 
working hours of the trainee.
6. Don’t forget to create the  additional necessary constructors in each deriving class.
7. Create an object of each of the three classes (with appropriate values) and 
call the methods, Lead() of Boss and Work() of Trainee.
8. Print to the console the text from the methods and what the respective employees do.


[IDEAS FOR DEMO](https://www.thoughtco.com/the-main-mammal-characteristics-4086144)

# Bonus Challenge
## Overview
Create a mammal inheritance and polymorphism lesson.
Base Mammal Class has the 8 common characteristics (properties) of mammals
inherited classes, (Horse and Human)) refine those and add more.


## Virtual Mammal Class:
- bool HasFourChamberedHeart
- bool isPredator
- DateTime createdAt
- int furrLength
- int speedOfMovement
- static int quantity = 0;
- double lifespan //in years so 1.1 or 84.3 is valid.
- string furrColor
- string nutrition
- override ToString()
- DistanceAtTopspeed(time in seconds) // virtual function?
- GUID IdNumber = new GUID()
- getAge() //returns the seconds old the mammal is. use the TimerCallback form video 104. (22mins 24secs) 


## Things to add/override:
### Horse Class:
    - override ToString()
    - tailLength;
    - bool isHerdAnimal
    - string says()
    - int runSpeed
    - DistanceAtTopspeed(time in seconds) // accesses runSpeed to measure distance run over time.
    - will inherit IdNumber as 0 so each animal has a 
    - inherites 'quantity' so we always know how many there are in the zoo.
### Human Class
    - bool walksUpright;
    - toolsUsed[] //an array or a List<>?
    - string says()
    - int runSpeed
    - DistanceAtTopspeed(time in seconds) // accesses runSpeed to measure distance run over time.
    - inherites 'quantity' so we always know how many there are in the zoo.
        