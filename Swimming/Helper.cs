using System.Net.Mime;
using Swimming.Context;
using Swimming.Models;

namespace Swimming;

public class Helper
{
    private static MyDbContext _satellitecontext;

    public static Swim Swim { get; set; }
    public static MyDbContext GetContext()
    {
        return _satellitecontext ??= new();
    }
}