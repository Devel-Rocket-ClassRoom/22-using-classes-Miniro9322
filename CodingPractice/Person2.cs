using System;

class Person2
{
    private string _name;
    private int _age;

    public Person2(string name, int age)
    {
        // this로 필드와 매개변수 구분
        this._name = name;
        this._age = age;
    }

    public void SetFriend(Person2 friend)
    {
        // 현재 인스턴스를 다른 개체에 전달
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(Person2 person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}