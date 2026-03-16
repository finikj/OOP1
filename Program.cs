using System;
using System.Collections.Generic;
using ConsoleApp1;

Mammal mammal = new Mammal("Бобик", "пес", 4, 12, 2, "яблоки");

Console.WriteLine("Print():");
mammal.Print();

Console.WriteLine("Feed():");
mammal.Feed();

Console.WriteLine("Osmotr():");    
mammal.Osmotr();

Console.WriteLine("Rodit():");
mammal.Rodit(3);

Console.WriteLine("Print():");
mammal.Print();