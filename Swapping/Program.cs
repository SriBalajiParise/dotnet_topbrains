using System;
namespace Swapping;

class Program
{
        public static void Main()
    {
         int x=5;
         int y=10;

        Swapping swapObj=new Swapping();

        swapObj.SwapRef(ref x , ref y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        
        int num1 , num2;
        swapObj.SwapOut(10 ,20,out num1 , out num2);
        Console.WriteLine("num1  = " + num1);
        Console.WriteLine("num2  = " + num2);
    }
    

}