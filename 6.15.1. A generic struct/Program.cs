using System; 
 
struct GenStruct<T> { 
  T x; 
  T y; 
 
  public GenStruct(T a, T b) { 
    x = a; 
    y = b; 
  } 
 
  public T X { 
    get { return x; } 
    set { x = value; } 
  } 
 
  public T Y { 
    get { return y; } 
    set { y = value; } 
  } 
 
} 
 
class MainClass { 
  public static void Main() { 
    GenStruct<int> xy = new GenStruct<int>(10, 20); 
    GenStruct<double> xy2 = new GenStruct<double>(88.0, 99.0); 
 
    Console.WriteLine(xy.X + ", " + xy.Y); 
 
    Console.WriteLine(xy2.X + ", " + xy2.Y); 
  } 
}