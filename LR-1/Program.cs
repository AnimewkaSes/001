using System;
using System.Linq;
class Program
{
    

static void Main(string[] args)
{
 bool showMenu = true;
    while (showMenu)
    {
        showMenu = MainMenu();
        Console.ReadKey();
    }
}

private static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Методы:");
    Console.WriteLine("1) Объединение");
    Console.WriteLine("2) Пересечение");
    Console.WriteLine("3) Деление ");
    Console.WriteLine("4) Выход");
    Console.Write("\r\nВыберите метод: ");
 
    switch (Console.ReadLine())
    {
        case "1":
           unification();
            return true;
        case "2":
          intersection();
            return true;
        case "3":
          Division();
            return true;    
        case "4":
            return false;
        default:
            return true;
    }
}

private static void unification()// объединение
{
   
    Console.Clear();
    Console.Write("Введите количество элементов массива: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] a = new int [3];
     int[] b = new int [3]; 
    Console.WriteLine("Введите множество А: " );
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
   
    Console.WriteLine("Введите множество В: " );
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
    
     Console.WriteLine("Массив А: ");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(" "+a[i]); 
    
    }
    Console.WriteLine("Массив B: ");
    for (int i = 0; i < b.Length; i++)
    {
        Console.WriteLine(" "+b[i]); 
    
    }

    IEnumerable<int> queru = from numbers in a.Union(b) select numbers;
    Console.WriteLine("Обединение множества А и В: ");
    foreach (var mas in queru)
    {
        Console.WriteLine(mas);
    }
}


private static void intersection()// пересечение
{
     Console.Clear();
    Console.Write("Введите количество элементов массива: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] a = new int [3];
     int[] b = new int [3]; 
    Console.WriteLine("Введите множество А: " );
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
   
    Console.WriteLine("Введите множество В: " );
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
    
     Console.WriteLine("Массив А: ");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(" "+a[i]); 
    
    }
    Console.WriteLine("Массив B: ");
    for (int i = 0; i < b.Length; i++)
    {
        Console.WriteLine(" "+b[i]); 
    
    }
    IEnumerable<int> queru = from number in a.Intersect(b) select number;
    Console.WriteLine("Пересечение множества А и В");
    foreach (var str in queru)
    {
        Console.WriteLine(str);
    }

}

private static void Division(){
   Console.Clear();
    Console.Write("Введите количество элементов массива: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] a = new int [3];
     int[] b = new int [3]; 
    Console.WriteLine("Введите множество А: " );
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
   
    Console.WriteLine("Введите множество В: " );
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = Convert.ToInt32(Console.ReadLine()); 
    
    }
    
     Console.WriteLine("Массив А: ");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(" "+a[i]); 
    
    }
    Console.WriteLine("Массив B: ");
    for (int i = 0; i < b.Length; i++)
    {
        Console.WriteLine(" "+b[i]); 
    
    }
     IEnumerable<int> query = from number in a.Except(b) select number;
    Console.WriteLine("A/B");
     foreach (var str in query)
     {
        Console.WriteLine(str);
     } 
    
     IEnumerable<int> quere = from number in b.Except(a) select number;
    Console.WriteLine("B/A");
     foreach (var str in quere)
     {
        Console.WriteLine(str);
     }           

}

}

