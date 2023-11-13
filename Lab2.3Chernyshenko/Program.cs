double F1 = 30, D1 = 121;
double F2 = -15, D2 = 50;
double F3 = 87, D3 = 223;

Console.WriteLine("Первая точка:");
if (F1 >= 0)
    Console.Write("Северо-");
else
    Console.WriteLine("Южно-");

if (D1 >= 0)
    Console.WriteLine("Восточное полушарие");
else
    Console.WriteLine("Западное полушарие");

Console.WriteLine("Вторая точка:");
if (F2 >= 0)
    Console.WriteLine("Северо-");
else
    Console.Write("Южно-");

if (D2 >= 0)
    Console.WriteLine("Восточное полушарие");
else
    Console.WriteLine("Западное полушарие");

Console.WriteLine("Третья точка:");
if (F3 >= 0)
    Console.Write("Северо-");
else
    Console.WriteLine("Южно-");

if (D3 >= 0)
    Console.WriteLine("Восточное полушарие");
else
    Console.WriteLine("Западное полушарие");