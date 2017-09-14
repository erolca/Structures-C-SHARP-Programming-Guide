using System;
using System;

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[5];
    int nextIndex = 0;
    

    // Define the indexer to allow client code to use [] notation.
    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }

    public int NextIndex { get => nextIndex;  }

    public void Add(T value)
    {
        if (nextIndex >= arr.Length)
            throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
        arr[nextIndex++] = value;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);
            stringCollection.Add("Merhaba Dunya");
            Console.WriteLine("{0} :  {1}", stringCollection.NextIndex, stringCollection[0]);
            stringCollection.Add("Hello World");  
            Console.WriteLine("{0} :  {1}", stringCollection.NextIndex, stringCollection[1]);
           
            // stringCollection.NextIndex = 4;

            stringCollection.Add("2");
            stringCollection.Add("3");
            stringCollection.Add("4");
            stringCollection.Add("5"); // IndexOutOfRangeException




        }
        catch(Exception ex)
        {


            Console.WriteLine(ex);

        }
    }
}
// The example displays the following output:
//       Hello, World.