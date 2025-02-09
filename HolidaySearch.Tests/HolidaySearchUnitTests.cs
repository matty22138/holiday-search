using Moq;

namespace HolidaySearch.Tests;

public class HolidaySearchUnitTests
{
    private Mock<IFlightSearch> _mockFlightSearch;

    [SetUp]
    public void Setup()
    {
        _mockFlightSearch = new Mock<IFlightSearch>();
    }

    [Test]
    public void GetResults_WithCustomerRequirments_ReturnsTheBestFlightInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.GetResults()).Returns(new List<Flight>{
            new Flight {
                Id = 1,
                DepartingFrom = "MAN",
                TravellingTo = "TFS",
                Price = "£470.00"
            }
        });

        var holidaySearch = new HolidaySearch(new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "TFS",
            DepartureDate = "2023/07/01",
            Duration = 7
        }, _mockFlightSearch.Object);

        var result = holidaySearch.GetResults().First();

        Assert.That(result.Flight.Id, Is.EqualTo(1));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo("MAN"));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo("TFS"));
        Assert.That(result.Flight.Price, Is.EqualTo("£470.00"));
    }
}
