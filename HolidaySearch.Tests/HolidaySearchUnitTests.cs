using Moq;

namespace HolidaySearch.Tests;

public class HolidaySearchUnitTests
{
    private Mock<IFlightSearch> _mockFlightSearch;
    private Mock<IHotelSearch> _mockHotelSearch;

    [SetUp]
    public void Setup()
    {
        _mockFlightSearch = new Mock<IFlightSearch>();
        _mockHotelSearch = new Mock<IHotelSearch>();
    }

    [Test]
    public void Search_WithCustomerRequirments_DefersToTheFlightSearchToGetTheBestFlight()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
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

        holidaySearch.Search();

        _mockFlightSearch.Verify((m) => m.Search(), Times.Once);
    }

    [Test]
    public void Search_WithCustomerRequirments_ReturnsTheBestFlightInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
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

        var result = holidaySearch.Search().First();

        Assert.That(result.Flight.Id, Is.EqualTo(1));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo("MAN"));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo("TFS"));
        Assert.That(result.Flight.Price, Is.EqualTo("£470.00"));
    }

    [Test]
    public void Search_WithCustomerRequirments_DefersToTheHotelSearchToGetTheBestHotel()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            new Flight {
                Id = 1,
                DepartingFrom = "MAN",
                TravellingTo = "TFS",
                Price = "£470.00"
            }
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            new Hotel {
                Id = 12,
                Name = "MS Maestranza Hotel",
                Price = "£45.00"
            }
        });

        var holidaySearch = new HolidaySearch(new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "TFS",
            DepartureDate = "2023/07/01",
            Duration = 7
        }, _mockFlightSearch.Object);

        holidaySearch.Search();

        _mockHotelSearch.Verify((m) => m.Search(), Times.Once);
    }
}
