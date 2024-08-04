namespace CustomeReservashioinCinama;

using System;
using System.Collections.Generic;

public enum TicketType { Vip, Normal }
public enum SeatLocation { Front, Middle, Back }
public enum Extra { Popcorn, Drink }

public class MovieReservation
{
    public string MovieName { get; set; }
    public DateTime ShowTime { get; set; }
    public TicketType TicketType { get; set; }
    public int TicketCount { get; set; }
    public SeatLocation SeatLocation { get; set; }
    public List<Extra> Extras { get; set; } = new List<Extra>();
    public string DiscountCode { get; set; }

    public override string ToString()
    {
        return $"Movie: {MovieName}, Time: {ShowTime}, Tickets: {TicketCount} {TicketType}, " +
               $"Seat: {SeatLocation}, Extras: {string.Join(", ", Extras)}, " +
               $"Discount: {(string.IsNullOrEmpty(DiscountCode) ? "None" : DiscountCode)}";
    }

    public decimal CalculatePrice()
    {
        decimal basePrice = TicketType == TicketType.Vip ? 15 : 10;
        decimal total = basePrice * TicketCount;
        total += Extras.Count * 5; // Each extra costs $5
        if (!string.IsNullOrEmpty(DiscountCode))
        {
            total *= 0.9m; // 10% discount
        }
        return total;
    }
}

public interface IMovieBuilder
{
    IDateBuilder ForMovie(string name);
}

public interface IDateBuilder
{
    ITicketsBuilder OnDate(DateTime date);
}

public interface ITicketsBuilder
{
    ISeatTypeBuilder NumberOfTickets(int ticketCount);
}

public interface ISeatTypeBuilder
{
    ISeatLocationBuilder SeatType(TicketType type);
}

public interface ISeatLocationBuilder
{
    IExtrasBuilder SeatLocation(SeatLocation location);
}

public interface IExtrasBuilder
{
    IExtrasBuilder AddExtra(Extra extra);
    IDiscountBuilder NoMoreExtras();
}

public interface IDiscountBuilder
{
    IFinalBuilder WithDiscountCode(string code);
    IFinalBuilder NoDiscount();
}

public interface IFinalBuilder
{
    MovieReservation Build();
}

public class MovieReservationBuilder : IMovieBuilder, IDateBuilder, ITicketsBuilder,
                                       ISeatTypeBuilder, ISeatLocationBuilder, IExtrasBuilder,
                                       IDiscountBuilder, IFinalBuilder
{
    private MovieReservation _reservation = new MovieReservation();

    public IDateBuilder ForMovie(string name)
    {
        _reservation.MovieName = name;
        return this;
    }

    public ITicketsBuilder OnDate(DateTime date)
    {
        _reservation.ShowTime = date;
        return this;
    }

    public ISeatTypeBuilder NumberOfTickets(int ticketCount)
    {
        _reservation.TicketCount = ticketCount;
        return this;
    }

    public ISeatLocationBuilder SeatType(TicketType type)
    {
        _reservation.TicketType = type;
        return this;
    }

    public IExtrasBuilder SeatLocation(SeatLocation location)
    {
        _reservation.SeatLocation = location;
        return this;
    }

    public IExtrasBuilder AddExtra(Extra extra)
    {
        _reservation.Extras.Add(extra);
        return this;
    }

    public IDiscountBuilder NoMoreExtras()
    {
        return this;
    }

    public IFinalBuilder WithDiscountCode(string code)
    {
        _reservation.DiscountCode = code;
        return this;
    }

    public IFinalBuilder NoDiscount()
    {
        return this;
    }

    public MovieReservation Build()
    {
        return _reservation;
    }
}

public static class MovieReservationFactory
{
    public static IMovieBuilder CreateReservation()
    {
        return new MovieReservationBuilder();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var reservation = MovieReservationFactory.CreateReservation()
            .ForMovie("Inception")
            .OnDate(new DateTime(2024, 8, 15, 20, 0, 0))
            .NumberOfTickets(2)
            .SeatType(TicketType.Vip)
            .SeatLocation(SeatLocation.Middle)
            .AddExtra(Extra.Popcorn)
            .AddExtra(Extra.Drink)
            .WithDiscountCode("SUMMER10")
            .Build();

        Console.WriteLine(reservation);
        Console.WriteLine($"Total Price: ${reservation.CalculatePrice()}");
    }
}
