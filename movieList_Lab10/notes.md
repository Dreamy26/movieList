# Lab10 Movie List

## Notes

## Task: List movies by category

## What will the aplication do?
- The application stores a list of 10 movies and displays them by category.
- The user can enter any of the following categories to display the films in the list that
match the category: animated, drama, horror, scif
- After the list is displayed, the user is asked if he or she wants to continue. If no, the
program ends.

## Classes

## User steps
1. User sees a list of 10 movies displayed by category.
2. User inputs one of the following categories: animated, drama, horror, scifi
3. User sees "Would you like to continue? If no, the program ends."


## Requirements

1. Prompt user to enter a movie by type of movie
2. Use a list
3. Use two private fields: title and category
4. Use a constructor that accepts: Title & Category as parameters
5. Validate input (Dont accept blanks for questions)

## Additional Requirements 
- Answer Lab Summary when submitting to LMS

## Extended Exercises:
- Standardize the category codes by displaying a menu of categories and
having the user select the category by number rather than entering the name.
- Display the movies for the selected category in alphabetical order.

## CSharp SoSharp

## Resources

[cSharpCorner](https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/)
- Before you use the List class in your code, you must import the System.Collections.Generic namespace using the following line. 
- using System.Collections.Generic;


## Questions
- how do to make a list in c#
- how do to make an object in c#

## mentor questions
1. class
- A class is a user-defined blueprint or prototype from which objects are created
2. Constructor
- Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read
3. Properties
- Properties expose fields. Fields should (almost always) be kept private to a class and accessed via get and set properties. Properties provide a level of abstraction allowing you to change the fields while not affecting the external way they are accessed by the things that use your class.
4. Fields
- Fields are variables inside a class. To access a field an object of the class needs to be created by using a dot syntax (.).

5. Private
- The private keyword is a member access modifier. Also, part of the private protected access modifiier. Private access is the least permissive access level. Private members are accessible only within the body of the class or the struct in which they are declared.

6. Parameters
- Parameters act as variables inside the method. They are specified after the method name, inside the parentheses. parmeters are unlimited, just separate them with a comma.

7. Object Initializers 
- Object initializers let you assign values to any accessible fields or properties of an object "at creation time" without having to invoke a constructor

public class Cat
{
    // Auto-implemented properties.
    public int Age { get; set; }
    public string Name { get; set; }

    public Cat()
    {
    }

    public Cat(string name)
    {
        this.Name = name;
    }
}

