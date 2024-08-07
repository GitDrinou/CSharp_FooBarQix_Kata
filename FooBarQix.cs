namespace FooBarQixTest;

public class FooBarQix
{
    private Dictionary<int, string> _values = new Dictionary<int, string>()
    {
        [3] = "Foo",
        [5] = "Bar",
        [7] = "Qix"
    };
        
        
    public string Generate(int number)
    {
        var valueToDisplay = "";

        foreach ((int modulo, string value) in _values)
        {
            if (number.IsDivisibleBy(modulo))
            {
                valueToDisplay += value;
            }
        }
        
        return string.IsNullOrEmpty(valueToDisplay) ? number.ToString() : valueToDisplay;
    }

}

public static class IntegerExtension
{
    public static bool IsDivisibleBy(this int number, int modulo)
    {
        return number % modulo == 0;
    }
}