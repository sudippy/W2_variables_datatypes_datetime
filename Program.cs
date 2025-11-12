class Workshop2
{
    static void Main(string[] args)
    {
        // =================================
        // task 1: data types
        // =================================

        string userName = "Sudip Bhandari";
        int luckyNumber = 8;
        Console.WriteLine($"Hello {userName}! Your lucky number is {luckyNumber}");

        // =================================
        // task 2: circle area and perimeter
        // =================================
        double area = Circle.CalculateArea(3.0);
        Console.WriteLine("The area of circle is " + area);
        double perimeter = Circle.CalcualtePerimeter(3.0);
        Console.WriteLine("The perimeter of circle is " + perimeter);

        // =================================
        // task 3: varibales and data types
        // =================================

        byte b = 2;
        short s = 3;
        int i = 42;
        long l = 2342342L;
        float f= 2.343f;
        double d = 23.545;
        decimal deci = 234.523M;
        char c = 'A';
        bool bo = true;

        string stringNum = $"{i}";
        // or
        string stringNum2 = i.ToString();

        double stringToDouble = double.Parse(stringNum);

        Console.WriteLine($"b is of {b.GetType().Name} type and its value is {b}");
        // similarly continue printing for other variables too.

        // =================================
        // task 4: Arrays
        // =================================

        int[] favNum = { 7, 2, 3 };
        Array.Sort(favNum);
        Array.Reverse(favNum);
        for (int j = 0; j < favNum.Length; j++)
        {
            Console.WriteLine(favNum[j]);
        }
        // lets find the index of 7 after it is sorted and reverse
        Console.WriteLine("The index of 7 is " + Array.IndexOf(favNum, 7));

        // =================================
        // task 5: datetime and timespan
        // =================================

        DateTime myBirthDate = new DateTime(2000, 6, 18, 7, 10, 00);
        DateTime currentDate = new DateTime(2025, 11, 4, 8, 00, 00);
        TimeSpan difference = currentDate - myBirthDate;
        Console.WriteLine($"Current date: {currentDate} \nBirth date: {myBirthDate} \nAge: {difference.TotalDays}");

        // adding 10 days to your birthdate
        DateTime newDate = myBirthDate.AddDays(10);
        Console.WriteLine($"10 days after my birthday is {newDate}");

        // =================================
        // task 6: lists and dictionary
        // =================================
        
        // lists
        List<string> favFruits = new (){ "Apple", "Banana", "Pomegranate" };
        favFruits.Add("Orange");
        favFruits.Remove("Banana");
        foreach (string fruit in favFruits)
        {
            Console.WriteLine(fruit);
        }

        // dictionary
        Dictionary<int, string> fruits = new ()
        {
            {1, "Apple"},
            {2, "Orange"}
        };
        fruits.Add(3, "Kiwi");
        foreach (var kvp in fruits)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }


    }

}

class Circle
{
    const double PI = 3.14;

    // PI=3.15;

    public static double CalculateArea(double r)
    {
        return PI * Math.Pow(r, 2);

    }
    public static double CalcualtePerimeter(double r)
    {
        return 2 * PI * r;
    }
}


