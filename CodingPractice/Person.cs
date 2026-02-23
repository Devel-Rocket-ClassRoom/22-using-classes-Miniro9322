using System;
using System.Collections.Generic;
using System.Text;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
}
