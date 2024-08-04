namespace CoffeBuyilder
{
    // Enums برای نوع میز
    public enum TableType
    {
        Indoor,
        Terrace,
        VIP
    }

    // اینترفیس‌ها برای جداسازی مسئولیت‌ها
    public interface IReservationBuilder
    {
        IDateBuilder ForDate(DateTime date);
    }

    public interface IDateBuilder
    {
        IGuestBuilder ForGuests(int numberOfGuests);
    }

    public interface IGuestBuilder
    {
        INameBuilder UnderName(string name);
    }

    public interface INameBuilder
    {
        IPhoneBuilder WithPhoneNumber(string phoneNumber);
    }

    public interface IPhoneBuilder
    {
        ITableBuilder TableType(TableType type);
    }

    public interface ITableBuilder
    {
        IFinalBuilder WithSpecialRequest(string request);
    }

    public interface IFinalBuilder
    {
        Reservation Build();
    }

    // کلاس اصلی Reservation
    public class Reservation
    {
        public DateTime Date { get; set; }
        public int NumberOfGuests { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public TableType TableType { get; set; }
        public string SpecialRequest { get; set; }
    }

    // کلاس Builder اصلی
    public class ReservationBuilder : IReservationBuilder, IDateBuilder, IGuestBuilder,
                                      INameBuilder, IPhoneBuilder, ITableBuilder, IFinalBuilder
    {
        private Reservation _reservation = new Reservation();

        public IDateBuilder ForDate(DateTime date)
        {
            _reservation.Date = date;
            return this;
        }

        public IGuestBuilder ForGuests(int numberOfGuests)
        {
            _reservation.NumberOfGuests = numberOfGuests;
            return this;
        }

        public INameBuilder UnderName(string name)
        {
            _reservation.Name = name;
            return this;
        }

        public IPhoneBuilder WithPhoneNumber(string phoneNumber)
        {
            _reservation.PhoneNumber = phoneNumber;
            return this;
        }

        public ITableBuilder TableType(TableType type)
        {
            _reservation.TableType = type;
            return this;
        }

        public IFinalBuilder WithSpecialRequest(string request)
        {
            _reservation.SpecialRequest = request;
            return this;
        }

        public Reservation Build()
        {
            return _reservation;
        }
    }

    // کلاس فکتوری برای شروع فرآیند ساخت
    public static class ReservationFactory
    {
        public static IReservationBuilder CreateReservation()
        {
            return new ReservationBuilder();
        }
    }

    // نمونه استفاده
    class Program
    {
        static void Main(string[] args)
        {
            var reservation = ReservationFactory.CreateReservation()
                
                .ForDate(new DateTime(2024, 8, 15, 19, 30, 0))
                .ForGuests(4)
                .UnderName("علی محمدی")
                .WithPhoneNumber("09123456789")
                .TableType(TableType.Terrace)
                .WithSpecialRequest("کیک تولد برای جشن تولد")
                .Build();

            Console.WriteLine($"Reservation for {reservation.Name} on {reservation.Date}");
            Console.WriteLine($"Guests: {reservation.NumberOfGuests}, Table: {reservation.TableType}");
            Console.WriteLine($"Phone: {reservation.PhoneNumber}");
            Console.WriteLine($"Special Request: {reservation.SpecialRequest}");
        }
    }
}
