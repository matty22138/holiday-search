namespace HolidaySearch.Tests;

public class HolidaySearchFeatureTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ExactSearchForAHoliday_WithCustomerRequirments_ReturnsTheBestOfTheMatchingResults()
    {
        var customerRequirements = new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "AGP",
            DepartureDate = "2023-07-01",
            Duration = 7
        };
        var holidaySearch = new HolidaySearch(
            new FlightSearch(customerRequirements),
            new HotelSearch(customerRequirements));

        var result = holidaySearch.ExactSearch().First();

        Assert.That(result.TotalPrice, Is.EqualTo(826));
        Assert.That(result.Flight.Id, Is.EqualTo(2));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo("MAN"));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo("AGP"));
        Assert.That(result.Flight.Price, Is.EqualTo(245));
        Assert.That(result.Hotel.Id, Is.EqualTo(9));
        Assert.That(result.Hotel.Name, Is.EqualTo("Nh Malaga"));
        Assert.That(result.Hotel.PricePerNight, Is.EqualTo(83));
        Assert.That(result.Hotel.TotalPrice, Is.EqualTo(581));
    }
}
