using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class MaxInputException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have played the game 5 times !";
            }
        }
    }

    public class InvalidInputException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter a integer from 1 to 5 !";
            }
        }
    }

    public class EvenNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have not entered a  even number !";
            }
        }
    }

    public class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have not entered a  odd number !";
            }
        }
    }

    public class PrimeNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have not entered a  prime number !";
            }
        }
    }

    public class NegativeNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have not entered a  negative number !";
            }
        }
    }

    public class ZeroNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "You have not entered a  zero number !";
            }
        }
    }
    class Program
    {
        public static bool IsPrime(int number)
        {
            for(int i =2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                while(i <= 5)
                {
                    if(i == 5)
                    {
                        
                        throw new MaxInputException();
                    }
                    try
                    {
                        Console.WriteLine("Enter the number 1 from to 5");
                        string input = Console.ReadLine();
                        int n;
                        int number = Convert.ToInt32(input);
                        bool isNumeric = int.TryParse(input, out n);

                        if (!isNumeric)
                        {
                            throw new InvalidInputException();
                        }
                        else if(number < 1 || number > 5)
                        {
                            throw new InvalidInputException();
                        }

                        int InputExpected;
                        if(number == 1)
                        {
                            try
                            {
                                Console.WriteLine("Please enter a even Number !");
                                InputExpected = Convert.ToInt32(Console.ReadLine());
                                if (InputExpected%2 != 0)
                                {
                                    throw new EvenNumberException();
                                }
                                else
                                {
                                    Console.WriteLine("Success ! You have entered a even number");
                                }
                            }
                            catch(EvenNumberException one)
                            {
                                Console.WriteLine(one.Message);
                            }
                        }
                        if (number == 2)
                        {
                            try
                            {
                                Console.WriteLine("Please enter a odd Number !");
                                InputExpected = Convert.ToInt32(Console.ReadLine());
                                if (InputExpected % 2 == 0)
                                {
                                    throw new OddNumberException();
                                }
                                else
                                {
                                    Console.WriteLine("Success ! You have entered a odd number");
                                }
                            }
                            catch (OddNumberException one)
                            {
                                Console.WriteLine(one.Message);
                            }
                        }
                        if (number == 3)
                        {
                            try
                            {
                                Console.WriteLine("Please enter a prime Number !");
                                InputExpected = Convert.ToInt32(Console.ReadLine());
                                if (IsPrime(InputExpected) == false)
                                {
                                    throw new PrimeNumberException();
                                }
                                else
                                {
                                    Console.WriteLine("Success ! You have entered a prime number");
                                }
                            }
                            catch (PrimeNumberException one)
                            {
                                Console.WriteLine(one.Message);
                            }
                        }
                        if (number == 4)
                        {
                            try
                            {
                                Console.WriteLine("Please enter negative Number !");
                                InputExpected = Convert.ToInt32(Console.ReadLine());
                                if (InputExpected >= 0)
                                {
                                    throw new NegativeNumberException();
                                }
                                else
                                {
                                    Console.WriteLine("Success ! You have entered a negative number");
                                }
                            }
                            catch (NegativeNumberException one)
                            {
                                Console.WriteLine(one.Message);
                            }
                        }
                        if (number == 5)
                        {
                            try
                            {
                                Console.WriteLine("Please enter zero !");
                                InputExpected = Convert.ToInt32(Console.ReadLine());
                                if (InputExpected == 0)
                                {
                                    throw new ZeroNumberException();
                                }
                                else
                                {
                                    Console.WriteLine("Success ! You have entered a negative number");
                                }
                            }
                            catch (ZeroNumberException one)
                            {
                                Console.WriteLine(one.Message);
                            }
                        }
                    }
                    catch(InvalidInputException one)
                    {
                        Console.WriteLine(one.Message);
                    }
                    i += 1;
                }
            }
            catch(MaxInputException one)
            {
                Console.WriteLine(one.Message);
            }
            Console.ReadKey();
        }
    }
}
