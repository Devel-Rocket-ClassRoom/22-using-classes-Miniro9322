using System;

class Player
{
    private string _name;
    private int _health;

    public Player()
    {
        _name = "Unknown";
        _health = 100;
    }

    public Player(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {_name}, 체력: {_health}");
    }
}