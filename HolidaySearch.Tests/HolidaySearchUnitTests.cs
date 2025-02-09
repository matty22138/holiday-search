using Moq;

namespace HolidaySearch.Tests;

public class HolidaySearchUnitTests
{
    private Mock<IFlightSearch> _mockFlightSearch;
    private Mock<IHotelSearch> _mockHotelSearch;
    private Flight _mockFlight;
    private Hotel _mockHotel;

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
            Price = 470
        };
        _mockHotel = new Hotel
        {
            Id = 12,
            Name = "MS Maestranza Hotel",
            PricePerNight = 45,
            Nights = 7,
            TotalPrice = 315
        };
    }

    [Test]
    public void ExactSearch_DefersToTheFlightSearchToGetTheBestFlight()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        holidaySearch.ExactSearch();

        _mockFlightSearch.Verify((m) => m.ExactSearch(), Times.Once);
    }

    [Test]
    public void ExactSearch_ReturnsTheBestFlightInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.ExactSearch().First();

        Assert.That(result.Flight.Id, Is.EqualTo(_mockFlight.Id));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo(_mockFlight.DepartingFrom));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo(_mockFlight.TravellingTo));
        Assert.That(result.Flight.Price, Is.EqualTo(_mockFlight.Price));
    }

    [Test]
    public void ExactSearch_DefersToTheHotelSearchToGetTheBestHotel()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        holidaySearch.ExactSearch();

        _mockHotelSearch.Verify((m) => m.ExactSearch(), Times.Once);
    }

    [Test]
    public void ExactSearch_ReturnsTheBestHotelInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.ExactSearch().First();

        Assert.That(result.Hotel.Id, Is.EqualTo(_mockHotel.Id));
        Assert.That(result.Hotel.Name, Is.EqualTo(_mockHotel.Name));
        Assert.That(result.Hotel.PricePerNight, Is.EqualTo(_mockHotel.PricePerNight));
    }

    [Test]
    public void ExactSearch_ReturnsTheTotalPriceInTheResults()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var result = holidaySearch.ExactSearch().First();

        Assert.That(result.TotalPrice, Is.EqualTo(785));
    }

    [Test]
    public void ExactSearch_WhenThereIsNoMatchingFlight_ReturnsNoHolidayInTheSearchResults()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(Enumerable.Empty<Flight>);

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(new List<Hotel>{
            _mockHotel
        });

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var results = holidaySearch.ExactSearch();

        Assert.That(results.Count, Is.Zero);
    }

    [Test]
    public void ExactSearch_WhenThereIsNoMatchingHotel_ReturnsNoHolidayInTheSearchResults()
    {
        _mockFlightSearch.Setup((m) => m.ExactSearch()).Returns(new List<Flight>{
            _mockFlight
        });

        _mockHotelSearch.Setup((m) => m.ExactSearch()).Returns(Enumerable.Empty<Hotel>());

        var holidaySearch = new HolidaySearch(
            _mockFlightSearch.Object,
            _mockHotelSearch.Object);

        var results = holidaySearch.ExactSearch();

        Assert.That(results.Count, Is.Zero);
    }
}
