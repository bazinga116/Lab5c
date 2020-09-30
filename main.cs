using System;

class MainClass {
  public static void Main (string[] args) {
    
            int number,intention,min=0;
            Console.WriteLine("Enter a number to determine prime probability.");

            number=int.Parse(Console.ReadLine());
            min=number/2;
            for(intention=2;intention<=min;intention++)
            {
            if (number%intention==0)
            {
              Console.WriteLine("This number is not a prime number");
              break;
            }

            else
            {
              Console.WriteLine("This number is a prime number"); 
              
            }
            }
          

            









           
           
    
 






  }
}