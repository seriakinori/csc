static class ConverterFactory
{
    private readonly static ConverterBase[] _converters = [
        new MeterConverter(),
        new FeetConverter(),
        new YardConverter(),
        new InchConverter(),
    ];

    public static ConverterBase? GetInstance(string name)
    => 
        _converters.FirstOrDefault(x => x.IsMyUnit(name));
}
