using System;



struct Number : IComparable
{
     private int value;
   
   public Number(int value)
    {
        this.value = value;
    }

    public int Value
    {
        get { return value; }
    }


    public int CompareTo(object obj2)
    {
        Number num2 = (Number)obj2;
        if (value < num2.value)
            return (-1);
        else if (value > num2.value)
            return (1);
        else
            return (0);
    }
}



class MainClass
{

    static string a;

    public static void Main()
    {

        //int f = 126;
        //char ff = Convert.ToChar(f);
        //Console.WriteLine((int)'f');
        //Console.WriteLine((char) 102);


        // 3 farklı varyasyon
        //int[] X0 = new int[3] { 1, 2, 3 };
        //int[] Y0=  { 11, 12, 13 };
        //int[] Z0= new int[] {20,21,22,23,24 };

        //int[] sayilarim = new int[] {3,5,7,9,11,13,15,17 };

        //Console.WriteLine("Dizi Degiskenleri");
        //foreach (var item in sayilarim)
        //{
        //    Console.WriteLine(item);
        //}

       // Console.ReadLine();
      
        

        Number x = new Number(3);
        Number y = new Number(4);

         IComparable Ic = (IComparable)x;
      //  Number Ic = x;
        Console.WriteLine("x compared to y = {0}", Ic.CompareTo(y));


        Number[] sayilar =
        {
            new Number(39),
            new Number(24),
            new Number(32),
            new Number(13),
            new Number(23)
        };
        //Array.Sort(sayilar);
        //for (int i = 0; i < sayilar.Length; i++)
        //{

        //    Console.WriteLine(sayilar[i]);
        //}


    }
}