﻿using System;
class A
{
     protected int n=1;
     public A()
     {
          n++;
          Console.WriteLine("n =" + n.ToString()); 
     }
}
class B : A
{
    public B()
    {
        n = 10;
        Console.WriteLine("n =" + n.ToString());
    }
}
class MainClass 
{ 
    [STAThread]
    static void Main(string[] args)
    {
        A a = new B();
    }
}
