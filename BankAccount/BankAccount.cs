using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

class BankAccount
{
    private readonly string AccountNumber;
    private readonly string OwnerName;
    private int Balance;

    public BankAccount(string accountNumber, string ownerName)
    {
        this.AccountNumber = accountNumber;
        this.OwnerName = ownerName;
        this.Balance = 0;
    }

    public void Deposit(int amount)
    {
        if(amount < 0)
        {
            Console.WriteLine("입금 금액은 0보다 커야 합니다.");
        }
        else
        {
            this.Balance += amount;
            Console.WriteLine($"{amount}원 입금 완료. 잔액: {Balance}원");
        }
    }

    public void Withdraw(int amount)
    {
        if (Balance - amount < 0)
        {
            Console.WriteLine("잔액이 부족합니다.");
        }
        else
        {
            this.Balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}원");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }
}
