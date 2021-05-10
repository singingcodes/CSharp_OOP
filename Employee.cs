using System;

namespace OOP
{
        // inheritance
        // parent class
        public class Employee
        {
          public string firstName;
          public string lastName;

          public virtual void printFullName()
          {
              Console.WriteLine(firstName + " " + lastName);
          }  
        }
        public class print
        {
          public void printClass ()
          {
            Console.WriteLine("This is the parent class");
          }
        }

        public class printChild : print
        {
          public new void printClass()
          {
            Console.WriteLine("This is the child class");
          }
        }
            // inheritance
            // derived class
        // public class partTimeEmployee : Employee
        // {
        //     public new void  printFullName() // the new keyword is used for method hiding
        //   {
        //       Console.WriteLine(firstName + " " + lastName + "------ part time employee");
        //   }  
        // }
        // public class contractEmployee : partTimeEmployee // multi level inheritance
        // {
        //   //   public override void printFullName() // the override keyword is used for method overriding 
        //   // {
        //   //   //   Console.WriteLine(firstName + " " + lastName + "----- contract employee");
        //   //   base.printFullName(); //you base keyword to call the base class even after overriding 
        //   // }  
        // }

        // polymorphism (many forms) in c# is a concept by which we can perform a single action in different ways
        // we can perform polymorphism in c# by method overloading and method overriding
        //if you overload a method in c#, it is the example of compile time (static) polymorphism
        //if you override a method in c#, it is the example of run time (dynamic) polymorphism
}

