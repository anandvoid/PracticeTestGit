using System;
using System.Collections.Generic;
using System.Text;


namespace CodeBase
{
    
    class FizZBuzz
    {
        //Declaring a String Builder object to append the values with line character at the end
        public StringBuilder FzString = new StringBuilder();

        public void FzProcess(int Value)
        {
              {
                //Loops and checks if the number is divisible by 3 or 5 or both 
                //starting from 0 till the user supplied Value
                

                for (int i = 0; i <= Value; i++)
                {
                   
                    if ((i % 3) == 0 && (i % 5) == 0)
                    {
                    //Adding FizzBuzz text to String Builder when the Value is divisible by 3 & 5.
                       FzString.Append("FizzBuzz");
                    //Appending end of line to the String Builder
                       FzString.AppendLine();
                        
                    }
                    else
                    {
                        if ((i % 3) == 0)
                        {
                            //Adding Fizz text to String Builder when the Value is divisible by 3.
                            FzString.Append("Fizz");
                            //Appending end of line to the String Builder
                            FzString.AppendLine();
                        }
                        else
                        if ((i % 5) == 0)
                        {
                            //Adding Buzz text to String Builder when the Value is divisible by 5.
                            FzString.Append("Buzz");
                            //Appending end of line to the String Builder
                            FzString.AppendLine();
                        }
                        else
                        {
                            //Adding number text to String Builder when the Value is not divisible by 3 or 5 and 3 & 5.
                            FzString.Append(i.ToString());
                            //Appending end of line to the String Builder
                            FzString.AppendLine();
                           

                        }
                    }
                }
            }
        }
    }
}
