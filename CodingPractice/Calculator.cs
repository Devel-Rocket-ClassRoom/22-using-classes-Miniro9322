class Calculator
{
    // 일반 메서드
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 식 본문 메서드 (Expression-bodied method)
    public int Multiply(int a, int b) => a * b;
}