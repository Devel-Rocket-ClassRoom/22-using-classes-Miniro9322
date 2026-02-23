using CodingPractice;
using System;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
ClassName.MemberName();

//2
Console.WriteLine(Square.GetName());

//3
MyFirstClass first = new MyFirstClass();
MyFirstClass.StaticMethod();
first.InstanceMethod();

//4
Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();

//5
Point point1 = new Point();
point1.X = 10;
point1.Y = 20;

Point point2 = point1;
point2.X = 100;

Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");

//6
PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = ps1;
ps2.X = 100;
Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

PointClass pc1 = new PointClass();
pc1.X = 10;
PointClass pc2 = pc1;
pc2.X = 100;
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");

//7
Calculator calc = new Calculator();
Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calc.Multiply(3, 5)}");

//8
Player player1 = new Player();
player1.ShowInfo();

Player player2 = new Player("용사", 150);
player2.ShowInfo();

//9
Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine($"주가: {stock.CurrentPrice}");

//10
Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;
Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");

//11
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");

//12
Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 50;

Monster monster2 = new Monster
{
    Name = "오크",
    Health = 100
};

monster1.Attack();
monster2.Attack();

//13
Character hero = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{hero.Name} - Lv.{hero.Level} {hero.Job}");

//14
Random random = new Random();

Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");
Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");

//15
Random random2 = new Random();

Console.WriteLine("주사위를 5번 굴립니다:");
for (int i = 0; i < 5; i++)
{
    int dice = random2.Next(1, 7);  // 1 ~ 6
    Console.WriteLine($"  {i + 1}번째: {dice}");
}

//16
Person2 alice = new Person2("Alice", 25);
Person2 bob = new Person2("Bob", 30);
alice.SetFriend(bob);