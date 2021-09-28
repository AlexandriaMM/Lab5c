using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int count = 2;
    bool isPrime = true;
    
    while (count < number) {
      int remainder = number % count;
      if (remainder == 0)
      {
        isPrime = false;
      }
      count++;
    }
    
    if(isPrime == false)
    {
      Console.WriteLine("this is not a prime number");
    }

    else if (isPrime == true)
    {
      Console.WriteLine("this is a prime number");
    }
  }
}