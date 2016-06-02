using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = @"C:\Pics";
            int i = 10;
            Console.WriteLine(name + i);
            int num = 10, deno = 2;
            int result = num / deno;
            int result1 = num % deno;
            Console.WriteLine("result is: {0} and remainder {1}",result,result1);
            int a = 10;
            bool b;
            b = a == 10 ? true : false;
            Console.WriteLine(b);
            int? j = null;
            if (j == null)
            {
                Console.WriteLine(" Values typed : Nullable ");
            }
            int? TicketsOnSale = 10;
            int AvailableTickets = TicketsOnSale ?? 0; // null coalescing operator

            int AvailableTickets1 = TicketsOnSale != null ? TicketsOnSale.Value : 0; // Ternary operator 

            Console.WriteLine("\n" + AvailableTickets + AvailableTickets1);

            int z = 100;

            float q = z;

            float f = 134.876F;

            int k = (int)f;

            int l = Convert.ToInt32(f);

            string number = "1000";

            int num1 = int.Parse(number);

            string number1 = "100000GHT";

            int num2 = 0;

            bool isConversionDone = int.TryParse(number1, out num2);

            Console.WriteLine(q);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(isConversionDone);

            if (isConversionDone)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("not a valid string to convert into number");
            }


            // Arrays 

            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 1;
            EvenNumbers[1] = 5;
            EvenNumbers[2] = 5;


            Console.WriteLine(EvenNumbers[0]);

        
            // For comments demo
            //SampleClass 

            Console.WriteLine(" Please enter a number : ");

            int NumberToAdd = int.Parse(Console.ReadLine());

            if (NumberToAdd == 10)
            {
                Console.WriteLine("Successful");
            }
            else if(NumberToAdd < 100)
            {
                Console.WriteLine("Unsuccessful");
            }
            // || if first true then doesnt check 2nd. | means check both the conditions irrespectively
            if (NumberToAdd == 10 | NumberToAdd == 11)
            {
                Console.WriteLine(" Number is between 10 or 11");
            }


            switch (NumberToAdd)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Enter number is {0}", NumberToAdd);
                    break;

                case 40:
                case 50:
                    Console.WriteLine("Enter number is {0}", NumberToAdd);
                    break;
                default:
                    Console.WriteLine("Numbers are not from 10 20 or 30");
                    break;

            }

            Start:
            Console.WriteLine(" Select your coffee : 1. Small 2.Medium 3.Large - ");

            int UserChoice = int.Parse(Console.ReadLine());


            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine(" 10 $");

                    break;


                case 2:
                    Console.WriteLine(" 20 $ ");

                break;

                case 3:
                Console.WriteLine(" 30 $ ");

                break;

                default:
                Console.WriteLine("User enter choice {0} is invalid", NumberToAdd);
                break;


            }

            Console.WriteLine("Do you want to buy more coffee");

            string UserDecision = Console.ReadLine();

            switch (UserDecision)
            {
                case "Yes":     
                case "Y":
                case "y":
                    goto Start;

                case "No":
                case "N":
                case "n":
                    break;
            }







            Console.Read();
        }
    }

   /// <summary>
   /// This is sample class for demos.
   /// </summary>
    public class SampleClass
    { }
}

