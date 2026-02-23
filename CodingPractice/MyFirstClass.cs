using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class MyFirstClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("[1] 정적 메서드");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("[2] 인스턴스 메서드");
        }
    }
}
