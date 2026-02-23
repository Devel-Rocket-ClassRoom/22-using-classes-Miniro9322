using System;

class Circle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
}