using System;

namespace OOP
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // inheritance allows you to point derived class using base class reference variable
            // multiple inheritance is not possible in dotnet/c#, but we can inherit multiple interfaces 
            // we can also do multilevel inheritance
            // polymorphism allows us to call 
            // Employee employee = new partTimeEmployee();
            // partTimeEmployee PTE = new partTimeEmployee();
            // PTE.firstName = "sarah";
            // PTE.lastName = "Dennis";
            // PTE.printFullName();
            // print parent = new print();
            // parent.printClass();
            // printChild child = new printChild();
            // child.printClass();
            // print Print = new printChild();
            // Print.printClass();
            // shape shapes = new shape();
            // rectangle rect = new rectangle();
            square sq = new square();
            sq.print();
            sq.printRectangle();
    
            


            // contractEmployee CTE = new contractEmployee();
            // CTE.firstName = "John";
            // CTE.lastName = "Paul";
            // CTE.printFullName();
        }
    }
}
