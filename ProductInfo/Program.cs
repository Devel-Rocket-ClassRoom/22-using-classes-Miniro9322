using System;

// README.md를 읽고 아래에 코드를 작성하세요.

ProductInfo product1 = new ProductInfo("노트북", 1500000);
product1.PrintInfo();

ProductInfo product2 = new ProductInfo("키보드", 80000, 20);
product2.PrintInfo();

product2.DiscountPercent = 30;
product2.PrintInfo();
