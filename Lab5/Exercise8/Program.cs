using System;

class A
{
       int X;
       public abstract void f(int n);
       private virtual void g(unsigned n)
       {
            X = n as int;
       }
       public string ToString()
       {
            return X.ToString();
       }
}


