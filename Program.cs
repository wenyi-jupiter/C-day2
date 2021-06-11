using System;

namespace Exercise5
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.setLength(1.1);
            box1.setWidth(2.3);
            box1.setHeight(3.2);

            Box box2 = new Box();
            box2.setLength(4);
            box2.setWidth(5);
            box2.setHeight(6);

            Box box3 = new Box();
            box3.setLength(7);
            box3.setWidth(8);
            box3.setHeight(9);
            Console.WriteLine($"Volume of Box1 : {box1.getVolume()}");
            Console.WriteLine($"Volume of Box2 : {box2.getVolume()}");
            Console.WriteLine($"Volume of Box3 : {box3.getVolume()}");


        }
    }
}
