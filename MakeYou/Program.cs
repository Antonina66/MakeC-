
internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 11;
        int num2 = 122;
    

        for (int i = num1; i <= num2; i++ )
        {
            for (int c = num1; c<i; c++)
            {
                if (i % c == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        
    }
}