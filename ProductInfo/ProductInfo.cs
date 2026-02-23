using System;
using System.Collections.Generic;
using System.Text;

internal class ProductInfo
{
    string Name;
    int Price;
    public int DiscountPercent;
    int DiscountAmount;
    int FinalPrice;

    public ProductInfo(string name, int price)
    {
        this.Name = name;
        this.Price = price;
        this.DiscountPercent = 0;
    }

    public ProductInfo(string name, int price, int discountPercent)
    {
        this.Name = name;
        this.Price = price;
        this.DiscountPercent = discountPercent;
    }

    

    public void PrintInfo()
    {
        this.DiscountAmount = this.Price * this.DiscountPercent / 100;
        this.FinalPrice = this.Price - this.DiscountAmount;
        Console.WriteLine($"[상품 정보] {this.Name} - {this.Price}원, 할인: {this.DiscountPercent}% (-{this.DiscountAmount}), 최종가: {this.FinalPrice}원");
    }
}

