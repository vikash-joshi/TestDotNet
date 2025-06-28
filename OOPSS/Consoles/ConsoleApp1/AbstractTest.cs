interface ITest
{
     void Test2();
}

public abstract class AbstractTest : ITest
{
     public abstract int AbstractPropertyStat { get; set; } = 100;

    public AbstractTest(int AbstractProperty)
    {
        this.AbstractProperty = AbstractProperty;
    }
    public abstract void Test();
    public static void CheckStaticInAbs()
    {
        System.Console.WriteLine("Static method in AbstractTest called.{0}" + AbstractPropertyStat);
        // Static method in abstract class
        System.Console.WriteLine("Static method in AbstractTest called.");
    }

    public abstract static void CheckStaticwithAbskeyword();
}

public class ConcreteTest : AbstractTest
{
    public override int AbstractProperty { get; set; } = 200;

    public ConcreteTest(int AbstractProperty) : base(AbstractProperty)
    {
        this.AbstractProperty = AbstractProperty;
    }

    public override void Test()
    {
        System.Console.WriteLine($"ConcreteTest implementation of Test. AbstractProperty: {AbstractProperty}");
    }

    public override static void CheckStaticwithAbskeyword()
    {
        System.Console.WriteLine("Static method in ConcreteTest called.");
    }
}
