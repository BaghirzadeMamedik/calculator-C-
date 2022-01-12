Console.Write("birinci reqemi daxil edin: ");
string sreqem = Console.ReadLine();

Console.Write("ikinci reqemi daxil edin: ");

string sreqem2 = Console.ReadLine();

int reqem = Convert.ToInt32(sreqem);

int reqem2 = Convert.ToInt32(sreqem2);

Console.Write("Emeli daxil edin: ");

string emel = Console.ReadLine();

decimal total;

if (emel == "+")
{
    total = reqem + reqem2;
    Console.WriteLine(total);
}
else if (emel == "-")
{
    total = reqem - reqem2;
    Console.WriteLine(total);
}
else if (emel == "*")
{
    total = reqem * reqem2;
    Console.WriteLine(total);
}
else if (emel == "/")
{
    total = reqem / reqem2;
    Console.WriteLine(total);
}
else
{
    Console.WriteLine("duzgun emeli daxil edin!!!");
}






