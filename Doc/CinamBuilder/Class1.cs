using System.Net.Sockets;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CinamBuilder;

//سئله: سیستم رزرو بلیط سینما
//شما باید یک سیستم رزرو بلیط سینما طراحی کنید که به کاربران اجازه دهد بلیط‌های خود را با جزئیات مختلف رزرو کنند.
//ویژگی‌های رزرو بلیط:

//خدمات اضافی(پاپکورن، نوشیدنی)
//وظایف شما:

//طراحی کلاس‌ها و اینترفیس‌های لازم برای پیاده‌سازی این سیستم با استفاده از Fluent Interface و Builder Pattern.
//پیاده‌سازی یک Builder که امکان ساخت یک رزرو بلیط را با تمام جزئیات فراهم کند.
//ایجاد یک کلاس فکتوری برای شروع فرآیند رزرو.
//پیاده‌سازی متدی برای محاسبه قیمت نهایی بلیط بر اساس ویژگی‌های انتخاب شده.
//نمایش اطلاعات کامل رزرو پس از اتمام فرآیند.

//نمونه استفاده مورد انتظار:





// نمونه استفاده
class Program
{
    static void Main(string[] args)
    {
        var reservation = MovieReservashionFactory.CreateReservashion()
            .ForMovie("Inception")
            .OnDate(new DateTime(2024, 8, 15, 20, 0, 0))
            .NumberOfTickets(2)
            .SeatType(TicketType.Vip)
            .Build();

        Console.WriteLine(reservation);
    }
}

public enum TicketType { Vip,Normal}
public enum Directions { north , south }
public class MovieReservashion
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public TicketType TicketType { get; set; }
    public int TicketCount { get; set; }
    public Directions Directions { get; set; }
}

public interface INameMovie
{
    IForMovie ForMovie(string name);
}
public interface IForMovie
{
    IOnDate OnDate(DateTime date1);
}
public interface IOnDate
{
    ISeatType NumberOfTickets(int ticketCount);
}

public interface ISeatType
{
    ISeatLocation SeatType(TicketType type);
}
public interface ISeatLocation
{
    MovieReservashion Build();
}


public class MovieReservashionBuilder : INameMovie, IForMovie, IOnDate,ISeatType, ISeatLocation
{
    private MovieReservashion _reservation = new MovieReservashion();
    public MovieReservashion Build()
    {
        return _reservation;
    }

    public IForMovie ForMovie(string name)
    {
        _reservation.Name = name;
        return this;
    }

    public ISeatType NumberOfTickets(int ticketCount)
    {
       _reservation.TicketCount = ticketCount;
        return this;
    }


    public IOnDate OnDate(DateTime date1)
    {
        _reservation.CreatedAt = date1;
        return this;
    }

    public ISeatLocation SeatType(TicketType type)
    {
        _reservation.TicketType = type;
        return this;
    }

  
}


public static class MovieReservashionFactory
{
    public static MovieReservashionBuilder CreateReservashion()
    {
        return new MovieReservashionBuilder();
    }
}

