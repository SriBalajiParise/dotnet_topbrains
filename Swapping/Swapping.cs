using System;

namespace Swapping;

public class Swapping
{
    public void SwapRef(ref int a , ref int b)
    {
        a=a + b;
        b= a-b;
        a= a - b;
    }

    public void SwapOut(int a,int b, out int num1, out int num2){
        num1= a + b;
        num2= num1 - b;
        num1= num1 - num2;

    }

}
