using System;
class A
{
    int n;
    string s;
    public A()
    {
    }
    public A(int[] num) {
        Array.Sort(num);
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i] + "\n");
        }
        
    }
    //other stuff…
}
class MainClass
{
    [STAThread]
    static void Main(string[] args)
    {
        int[] v = new int[10] { 3, 4, 5, 6, 1, 7, 9, 10, 42, 9,};
        A a = new A(v);
    }
}
