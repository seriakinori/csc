public abstract class ConverterBase
{
    protected abstract double Ratio {get;}

    public abstract string UnitName{get;}

    public double FromMeter(double meter) => meter / Ratio;

    public double ToMeter(double feet) => feet * Ratio;
}