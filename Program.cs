
using System;

class Program
{
    static void Main()
    {
        Box box = new Box();

        box.Width = 2;
        box.Height = 3;
        box.Length = 5;

        box.Show();

        Console.WriteLine("Box volume = " + box.Volume());
    }
}

class Box
{
    public float Width;
    public float Height;
    public float Length;

    public void Show()
    {
        Console.WriteLine("Width: " + Width);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Length: " + Length);
    }

    public float Volume()
    {
        return Width * Height * Length;
    }
}
