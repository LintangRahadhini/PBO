﻿
class processor
{
    public string merk;
    public string tipe;
}

class Intel : processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class CoreI3 : Intel
{
    public CoreI3()
    {
        tipe = "Core i3";
    }
}

class CoreI5 : Intel
{
    public CoreI5()
    {
        tipe = "Core i5";
    }
}

class CoreI7 : Intel
{
    public CoreI7()
    {
        tipe = "Core i7";
    }
}

class AMD : processor
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "RAYZEN";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        tipe = "ATHLON";
    }
}

class Vga
{
    public string merk;
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class amd : Vga
{
    public amd()
    {
        merk = "AMD";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public processor Processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }

    public void BermainGame()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.Processor = new CoreI5();
        //laptop1.Ngoding();
        //Console.WriteLine(laptop1.vga + " " + laptop1.Processor.merk + " " + laptop1.Processor.tipe);

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new amd();
        laptop2.Processor = new CoreI7();
        //laptop2.LaptopDimatikan();
        //laptop2.LaptopDinyalakan();
        
        Predator predator = new Predator();
        predator.vga = new amd();
        predator.Processor = new CoreI7();
        //predator.BermainGame();

        ACER acer = new Predator();
        acer.BermainGame();

    }
}