using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class HospitalityFaker : IHospitalityFaker
{
    public async Task<IEnumerable<HospitalityModel>> GenerateHospitalityAsync(int quantity, string language)
    {
        var faker = new Faker<HospitalityModel>(language).StrictMode(true)
       .RuleFor(x => x.GuestName, f => f.Name.FullName())
       .RuleFor(x => x.RoomNumber, f => f.Random.Number(100, 999).ToString())
       .RuleFor(x => x.ReservationCode, f => f.Random.AlphaNumeric(8).ToUpper())
       .RuleFor(x => x.CheckInDate, f => f.Date.Soon(10))
       .RuleFor(x => x.CheckOutDate, (f, x) => x.CheckInDate.AddDays(f.Random.Number(1, 10)))
       .RuleFor(x => x.RoomRate, f => f.Finance.Amount(80, 500))
       .RuleFor(x => x.PaymentMethod, f => f.PickRandom("Credit Card", "Cash", "Online", "Voucher"))
       .RuleFor(x => x.ServicePackage, f => f.PickRandom("Basic", "Standard", "Premium", "All-Inclusive"))
       .RuleFor(x => x.HotelBranch, f => f.Company.CompanyName())
       .RuleFor(x => x.Status, f => f.PickRandom("Confirmed", "Checked-In", "Checked-Out", "Cancelled"))
       .RuleFor(x => x.IsVIP, f => f.Random.Bool(0.2f))
       .RuleFor(x => x.CountryOfOrigin, f => f.Address.Country())
       .RuleFor(x => x.ContactEmail, f => f.Internet.Email())
       .RuleFor(x => x.BookingDate, f => f.Date.Past(1))
       .RuleFor(x => x.NightsStayed, (f, x) => (x.CheckOutDate - x.CheckInDate).Days);

        return await Task.FromResult(faker.Generate(quantity));
    }
}
