namespace FooBarQixTest;

public class FooBarQix
{
    private Dictionary<int, string> _figures = new Dictionary<int, string>()
    {
        [3] = "Foo",
        [5] = "Bar",
        [7] = "Qix"
    };
        
        
    public string Generate(int number)
    {
        var figure = "";
        
        if (number.IsDivisibleBy(3))
        {
            figure = "Foo";
        }
        
        if (number % 5 == 0)
        {
            figure +="Bar";
        }

        if (number % 7 == 0)
        {
            figure +="Qix";
        }
        
        return string.IsNullOrEmpty(figure) ? number.ToString() : figure;
    }

}

public static class IntegerExtension
{
    public static bool IsDivisibleBy(this int number)
    {
        return number % 3 == 0;
    }
}