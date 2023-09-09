using System;

class MainClass 
{
  public static void Main (string[] args) 
  
  {
    //PART 1
    //Creates and populates the variables needed for the program to run
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();

    Console.WriteLine("What is your age?");
    int age = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("What is you gender?");
    char gender = Convert.ToChar(Console.ReadLine());

    //Calls the printThat method with NO PARAMETERS
    printThat();
            
    //Calls the printThis method with the three created variables in the required order specified in the method signature i.e. string-int-char (see below)
    printThis(name, age, gender);

    //Once the methods have completed doing what they need to do, they return control back to the main method
    Console.ReadKey();
    Console.WriteLine("This is back in the main method");

    //PART 2
    //This creates and populates two int variables which will be used in the next method
    int num1, num2;

    Console.WriteLine("Enter number 1:");
    num1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter number 2:");
    num2 = Convert.ToInt16(Console.ReadLine());

    //This calls the calculateAdd method PASSING the two ints specified in the method signature (see below)
    calculateAdd(num1, num2);
    Console.ReadKey();

    int num3, num4;

    Console.WriteLine("Enter number 3:");
    num3 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter number 4:");
    num4 = Convert.ToInt16(Console.ReadLine());
    //This method will subtract one number from another and then RETURN the result to the main method

    int subtractionResult = calculateSubtract(num3, num4);
    Console.WriteLine("The result of this subtraction calculation is " + subtractionResult);
    Console.ReadKey();
    }

    //This method simply prints one statement
    static void printThat()
    {
       Console.WriteLine("This is the print that method");
    }

    //This method prints the three parameters passed to it through  the method call
    static void printThis(string name, int age, char gender)
    {
      Console.WriteLine("This is the print this method");
      Console.WriteLine("Your name is " + name + ". Your age is " + age + ". Your gender is " + gender);
    }

    //This method adds together the two ints passed to it and prints it out.
    static void calculateAdd(int num1, int num2)
    {
      int additionResult =  num1+num2;
      Console.WriteLine("The result of this addition is " + additionResult);
    }  
        

    //This method will subtract one number from another and RETURN the result to the calling method in the main method.
    static int calculateSubtract (int num3, int num4)
    {
      int subResult = num3 - num4;

      return subResult;
    }

    static double calculation (int num1, int num2, char calculationType) 
    {
      double result;

      //INSERT CODE HERE WHICH IMPLEMENTS A CALCULATOR METHOD

      return result;
    }
  
}
