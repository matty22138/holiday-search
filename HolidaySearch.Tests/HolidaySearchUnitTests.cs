using Moq;

namespace HolidaySearch.Tests;

public class HolidaySearchUnitTests
{
    private Mock<IFlightSearch> _mockFlightSearch;
    private Mock<IHotelSearch> _mockHotelSearch;
    private Flight _mockFlight;
    private Hotel _mockHotel;
    private CustomerRequirements _customerRequirements;

    [SetUp]
    public void Setup()
    {
        _mockFlightSearch = new Mock<IFlightSearch>();
        _mockHotelSearch = new Mock<IHotelSearch>();
        _mockFlight = new Flight
        {
            Id = 1,
            DepartingFrom = "MAN",
            TravellingTo = "TFS",
            Price = "£470.00"
        };
        _mockHotel = new Hotel
        {
            Id = 12,
            Name = "MS Maestranza Hotel",
            PricePerNight = "£45.00",
            Nights = 7,
            TotalPrice = "£315.00"
        };
        _customerRequirements = new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "TFS",
            DepartureDate = "2023/07/01",
            Duration = 7
        };
    }

    [Test]
    public void Search_WithCustomerRequirments_DefersToTheFlightSearchToGetTheBestFlight()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _customerRequirements,
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        holidaySearch.Search();

        _mockFlightSearch.Verify((m) => m.Search(), Times.Once);
    }

    [Test]
    public void Search_WithCustomerRequirments_ReturnsTheBestFlightInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _customerRequirements,
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.Search().First();

        Assert.That(result.Flight.Id, Is.EqualTo(_mockFlight.Id));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo(_mockFlight.DepartingFrom));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo(_mockFlight.TravellingTo));
        Assert.That(result.Flight.Price, Is.EqualTo(_mockFlight.Price));
    }

    [Test]
    public void Search_WithCustomerRequirments_DefersToTheHotelSearchToGetTheBestHotel()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _customerRequirements,
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        holidaySearch.Search();

        _mockHotelSearch.Verify((m) => m.Search(), Times.Once);
    }

    [Test]
    public void Search_WithCustomerRequirments_ReturnsTheBestHotelInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _customerRequirements,
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.Search().First();

        Assert.That(result.Hotel.Id, Is.EqualTo(_mockHotel.Id));
        Assert.That(result.Hotel.Name, Is.EqualTo(_mockHotel.Name));
        Assert.That(result.Hotel.PricePerNight, Is.EqualTo(_mockHotel.PricePerNight));
    }

    [Test]
    public void Search_WithCustomerRequirments_ReturnsTheTotalPriceInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.Search()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.Search()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _customerRequirements,
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.Search().First();

        Assert.That(result.TotalPrice, Is.EqualTo("£785.00"));
    }
}
