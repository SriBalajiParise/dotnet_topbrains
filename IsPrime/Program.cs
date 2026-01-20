public class Solution
{
    public bool IsPrime(int n)
    {
        if(n==1){
            //Console.WriteLine("1 is neither prime nor composite number");
            return false;
        }
        else if(n>=2){
            int count=0;
            int num=n;
            for(int i=1;i<=num/2;i++){
                if(num%i==0){
                    count++;
                }

        }
        if(count==1){
            //Console.WriteLine($"{n} is a prime number");
            return true;
        }
        else{
            //Console.WriteLine($"{n} is a composite number");
            return false;
        }
        }
        else{
            //Console.WriteLine("Enter a valid number");
            return false;
        }
    }
}

class Program{
        public static void Main()
{
    Console.WriteLine("Enter the Number: ");
    int n=Convert.ToInt32(Console.ReadLine());

    Solution solutionObj=new Solution();

    solutionObj.IsPrime(n);
    Console.WriteLine(solutionObj.IsPrime(n));
    
}
    }