using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> numberList = new List<int>();

        numberList.Add(13);
        numberList.Add(7);
        numberList.Add(39);
        numberList.Add(4);
        numberList.Add(22);
        numberList.Add(6);


        Console.Write("danh sach cac so nguyen la: ");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.Write(" " + numberList[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        int tong = 0;
        for (int i = 0; i < numberList.Count; i++)
        {
            tong += numberList[i];
        }
        Console.WriteLine("tong cac so nguyen la: " + tong);

        Console.WriteLine();
        int tongnt = 0;
        for (int y = 0; y <= numberList.Count; y++)
        {
            if (numberList[y] < 2)
            {
                continue;
            }
            else
            {
                for (int x = 2; x <= Math.Sqrt(numberList[y]); x++)
                {
                    if (numberList[y] % x == 0)
                    {
                        continue;
                    }
                    else
                    {
                        tongnt += numberList[y];
                    }
                }
            }
        }
        Console.WriteLine("tong cac so nguyen to la: " + tongnt);

        Console.WriteLine();
        int tongchan = 0;
        for (int i = 0; i < numberList.Count; i++)
        {
            if (numberList[i] % 2 == 0)
            {
                tongchan += numberList[i];
            }
            i++;
        }
        Console.WriteLine("tong cac so chan o vi tri le la: " + tongchan);

        Console.ReadLine();
    }
}