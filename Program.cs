using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] RanArray = new int[1000];
            int[] counter = new int[10];
            
            Random random = new Random();
            for(int i=0; i < 1000; i++)
            {
                RanArray[i] = random.Next(0, 9);
                
            }

           foreach(int value in RanArray)
            {
                Console.WriteLine(value);
            }

            counter[RanArray[i]++];

                int k = 0;

              for (int i = 0; i < 10; i++)
                {


                    for (int j = 0; j < counter[i]; j++)
                    {
                        RanArray[k++] = i;
                    }
                }
            

           

        }

        
    }
}
