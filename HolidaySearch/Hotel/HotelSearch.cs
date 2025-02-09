public interface IHotelSearch
{
    IEnumerable<Hotel> ExactSearch();
}

public class HotelSearch : IHotelSearch
{
    private readonly IHotelRequirements _hotelRequirements;
    private readonly IEnumerable<Hotel> _hotelInvetory;

    public HotelSearch(IHotelRequirements hotelRequirements)
    {
        _hotelRequirements = hotelRequirements;
        _hotelInvetory = new InMemoryHotels().GetAll();
    }

    public IEnumerable<Hotel> ExactSearch()
    {
        var matchingHotels = _hotelInvetory.Where((f) =>
            f.ArrivalDate == _hotelRequirements.DepartureDate &&
            f.Nights == _hotelRequirements.Duration &&
            f.LocalAirports.Contains(_hotelRequirements.TravelingTo));

        // if (!matchingFlights.Any())
        // {
        //     return Enumerable.Empty<Flight>();
        // }

        var bestHotel = matchingHotels.First();

        return new List<Hotel> {
            bestHotel
        };
    }
}