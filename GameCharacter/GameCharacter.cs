using System;
using System.Collections.Generic;
using System.Text;


class GameCharacter
{
    string Name;
    int Level;
    int MaxHp;
    int CurrentHp;
    int AttackPower;
    bool IsAlive;

    public GameCharacter(string name, int level)
    {
        this.Name = name;
        this.Level = level;
        this.MaxHp = this.Level * 100;
        this.CurrentHp = this.MaxHp;
        this.AttackPower = this.Level * 10;
        this.IsAlive = this.CurrentHp > 0;
    }

    public void Attack(GameCharacter target)
    {
        Console.WriteLine($"{this.Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다.");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        this.CurrentHp = this.CurrentHp - damage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{this.Name}] Lv.{this.Level} - HP: {this.CurrentHp}/{this.MaxHp}, 공격력: {this.AttackPower}");
    }
}

