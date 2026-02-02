using System.Net.WebSockets;
using System.Reflection;

namespace Gushwell.Utilities;

public static class EnumDisplayExtensions
{
    private static EnumDisplayAttribute? GetFieldAttribute(Enum value)
    {
        var name = value.ToString();
        var fi = value.GetType().GetField(name!);

        if(fi != null)
        {
            var attr = fi
                .GetCustomAttributes(typeof(EnumDisplayAttribute),
                false)
                .Cast<EnumDisplayAttribute>()
                .FirstOrDefault();
            return attr;
        }
        else
        {
            return null;
        }
    }

    public static string GetDisplayName(this Enum value)
    {
        var attribute = GetFieldAttribute(value);
        return attribute?.Name ?? value.ToString();
    }
}