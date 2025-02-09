public interface IHotelSearch
{
    IEnumerable<Hotel> ExactSearch();
}

public class HotelSearch : IHotelSearch
{
    // private readonly IFlightRequirements _flightRequirements;
    // private readonly IEnumerable<Flight> _flightInventory;

    public HotelSearch(IHotelRequirements hotelRequirements)
    {
        // _hotelRequirement = flightRequirements;
        // _flightInventory = new InMemoryFlights().GetAll();
    }

    public IEnumerable<Hotel> ExactSearch()
    {
        throw new NotImplementedException();
    }
}