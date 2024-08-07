using NFluent;
using NUnit.Framework;

namespace FooBarQixTest;

public class FooBarQixShould
{
    [Test]
    public void should_return_1_when_given_number_is_1()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(1);
        Check.That(actual).IsEqualTo("1");
    }

    [Test]
    public void should_return_2_when_given_number_is_2()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(2);
        Check.That(actual).IsEqualTo("2");
    }

    [Test]
    public void should_return_Foo_when_given_number_is_divisible_by_3()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(9);
        Check.That(actual).IsEqualTo("Foo");
    }

    [Test]
    public void should_return_Bar_when_given_number_is_divisible_by_5()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(25);
        Check.That(actual).IsEqualTo("Bar");
    }

    [Test]
    public void should_return_Qix_when_given_number_is_divisible_by_7()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(49);
        Check.That(actual).IsEqualTo("Qix");
    }

    [Test]
    public void should_return_FooBar_when_given_number_is_divisible_by_3_and_5()
    {
        var fooBarQix = new FooBarQix();
        var actual = fooBarQix.Generate(15);
        Check.That(actual).IsEqualTo("FooBar");
    }
}