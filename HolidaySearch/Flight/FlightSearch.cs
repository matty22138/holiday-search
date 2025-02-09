public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    private readonly CustomerRequirements _customerRequirements;
    private readonly IEnumerable<Flight> _flightInventory;

    public FlightSearch(CustomerRequirements customerRequirements)
    {
        _customerRequirements = customerRequirements;
        _flightInventory = new InMemoryFlights().GetAll();
    }

    public IEnumerable<Flight> ExactSearch()
    {
        var bestFlight = _flightInventory.First((f) =>
            f.DepartingFrom == _customerRequirements.DepartingFrom &&
            f.TravellingTo == _customerRequirements.TravelingTo &&
            f.DepartureDate == _customerRequirements.DepartureDate);

        return new List<Flight> {
            bestFlight
        };
    }
}