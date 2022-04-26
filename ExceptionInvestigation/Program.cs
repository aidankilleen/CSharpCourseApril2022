using System;

namespace ExceptionInvestigation
{
    class MyCustomException : Exception
    {
        public MyCustomException(string message)
            : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Investigation");

            int a = 100;
            int b = 0;
            int answer = -1;

            int[] list = { 1, 2, 3, 4, 5 };

            string s = "ninty nine";

            Random r = new Random();
            int r1 = r.Next(6);

            string s2 = null;

            try
            {
                switch(r1)
                {
                    case 0:
                        answer = a / b;
                        break;
                    case 1:
                        answer = list[5];
                        break;
                    case 2:
                        answer = int.Parse(s);
                        break;
                    case 3:
                        answer = s2.Length;
                        break;
                    case 4:
                        throw new MyCustomException("My Error Occurred");
                        break;
                    default:
                        answer = 42;  // no error occurred
                        break;
                }
            } catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                answer = 0;
            } catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
                answer = list[0];
            } catch (FormatException)
            {
                Console.WriteLine($"Can't convert {s} to a number");
                answer = 99;
            } catch (Exception ex)
            {
                Console.WriteLine($"Some other error occurred: { ex.Message }");
                answer = 0;
            } finally
            {
                Console.WriteLine("No matter what, this code will run");
                Console.WriteLine($"The answer is { answer }");
            }

            
            Console.WriteLine("Finished");






            /*
            try
            {
                DoSomething();
                DoSomethingElse();
            }
            catch(NetworkException ex)
            {

            }
            catch(FileExcepton ex)
            {

            }
            catch (Exception)
            {
                // some other error
            }
            */




            /*
            int r = DoSomething();
            if (r == -1)
            {
                // network error
            } else if (r == -2)
            {
                // file error
            } else if (r == -3)
            {
                // some other error
            } else if (r == 0)
            {
                // everything was fine.
            }
            r = DoSomethinElse();
            if (r == -1)
            {
                // network error
            }
            else if (r == -2)
            {
                // file error
            }
            else if (r == -3)
            {
                // some other error
            }
            else if (r == 0)
            {
                // everything was fine.
            }
            */

        }
    }
}
