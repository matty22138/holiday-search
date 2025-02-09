using Moq;

namespace HolidaySearch.Tests;

public class FlightSearchUnitTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void ExactSearch_WithCustomerRequirments_ReturnsTheExactMatchingFlight()
    {
        var holidaySearch = new FlightSearch(new CustomerRequirements()
        {
            DepartingFrom = "LGW",
            TravelingTo = "AGP",
            DepartureDate = "2023-07-01",
            Duration = 7
        });

        var result = holidaySearch.ExactSearch().First();

        Assert.That(result.Id, Is.EqualTo(10));
        Assert.That(result.DepartingFrom, Is.EqualTo("LGW"));
        Assert.That(result.TravellingTo, Is.EqualTo("AGP"));
        Assert.That(result.Price, Is.EqualTo(225));
    }
}
