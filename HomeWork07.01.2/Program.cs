using System;

class Program
{
    static void Main(string[] args)
    {
        Shop shop1 = new Shop("Shop A", "123 Main St", "Grocery", "+1234567890", "shopa@example.com", 100.0);
        Shop shop2 = new Shop("Shop B", "456 Elm St", "Clothing", "+9876543210", "shopb@example.com", 80.0);

        System.Console.WriteLine("Shop 1 Area: " + shop1.Area);
        System.Console.WriteLine("Shop 2 Area: " + shop2.Area);

        shop1 += 20.0;
        shop2 -= 10.0;

        System.Console.WriteLine("Shop 1 Area: " + shop1.Area);
        System.Console.WriteLine("Shop 2 Area: " + shop2.Area);

        if (shop1 == shop2)
            Console.WriteLine("Shop 1 and Shop 2 have the same area.");
        else
            Console.WriteLine("Shop 1 and Shop 2 have different areas.");

        if (shop1 > shop2)
            Console.WriteLine("Shop 1 has a larger area than Shop 2.");
        else
            Console.WriteLine("Shop 1 has a smaller area than Shop 2.");

    }
}

class Shop
{
    private string name;
    private string address;
    private string profile;
    private string contactPhone;
    private string email;
    private double area;

    public Shop(string name, string address, string profile, string contactPhone, string email, double area)
    {
        this.name = name;
        this.address = address;
        this.profile = profile;
        this.contactPhone = contactPhone;
        this.email = email;
        this.area = area;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string Profile
    {
        get { return profile; }
        set { profile = value; }
    }
    public string ContactPhone
    {
        get { return contactPhone; }
        set { contactPhone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    public static Shop operator +(Shop shop, double increment)
    {
        shop.Area += increment;
        return shop;
    }
    public static Shop operator -(Shop shop, double increment)
    {
        shop.Area -= increment;
        return shop;
    }
    public static bool operator ==(Shop shop1, Shop shop2)
    {
        return shop1.Area == shop2.Area;
    }
    public static bool operator !=(Shop shop1, Shop shop2)
    {
        return shop1.Area != shop2.Area;
    }
    public static bool operator >(Shop shop1, Shop shop2)
    {
        return shop1.Area > shop2.Area;
    }
    public static bool operator <(Shop shop1, Shop shop2)
    {
        return shop1.Area < shop2.Area;
    }

    public override bool Equals(object obj)
    {
        if (obj is Shop otherShop)
        {
            return this.Area == otherShop.Area;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Area.GetHashCode();  
    }
}