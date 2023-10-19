using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ArrayEx
    {
        int[] numbers = new int[5];
        //int[,] nums;

        public void Onedim()
        {
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("2nd");
            numbers = new int[8];
            numbers[1] = 123;
            
            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Array.Clear(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


        }
        public void TwoDim()
        {
            /*  nums[0, 0] = 100;
              nums[0, 1] = 200;
              nums[1, 0] = 300;
              nums[1, 1] = 400;*/

            int[,] nums = { { 100, 200 }, { 300, 400 } };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

            //Jagged Array
            public void Ja()
            {
                int[][,] arr = new int[][,]
                {
                    new int[,] {{1, 2},{3, 4} },
                    new int[,]{{100,200},{300,400 },{3000,7000 } }
                
            };
            foreach(var item in arr)
            {
                Console.WriteLine(item[1,1]);

            }
           /* 
            for (int i=0;i < arr.Length; i++)
            {
                int x = 0;
                for(int j = 0; j < arr[i].GetLength(x);j++)
                {
                    for (int k = 0; k < arr[j].Rank;k++)
                    {
                        Console.Write(arr[i][j, k] + " ");
                    }
                    Console.WriteLine();


                }
                x++;
                Console.WriteLine();

            }  */ 




            }
        }
    }

