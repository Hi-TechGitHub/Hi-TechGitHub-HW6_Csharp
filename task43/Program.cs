void Coordinats()
{
    Console.WriteLine("Введите координаты 1 точки, b1, k1");
    Console.Write("b1 = ");
    double c = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("k1 = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты 2 точки, b2, k2");
    Console.Write("b2 = ");
    double d = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    double b = Convert.ToDouble(Console.ReadLine());
    double x = (d - c) / (a - b);
    double y = a * x + c;
    Console.WriteLine($"{x}; {y}");
}
Coordinats();