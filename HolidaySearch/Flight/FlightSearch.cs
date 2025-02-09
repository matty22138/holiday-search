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
        var matchingFlights = _flightInventory.Where((f) =>
            f.DepartingFrom == _customerRequirements.DepartingFrom &&
            f.TravellingTo == _customerRequirements.TravelingTo &&
            f.DepartureDate == _customerRequirements.DepartureDate);

        if (!matchingFlights.Any())
        {
            return Enumerable.Empty<Flight>();
        }

        var bestFlight = matchingFlights.First();

        return new List<Flight> {
            bestFlight
        };
    }
}