public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    private readonly IFlightRequirements _flightRequirements;
    private readonly IEnumerable<Flight> _flightInventory;

    public FlightSearch(IFlightRequirements flightRequirements)
    {
        _flightRequirements = flightRequirements;
        _flightInventory = new InMemoryFlights().GetAll();
    }

    public IEnumerable<Flight> ExactSearch()
    {
        var matchingFlights = _flightInventory.Where((f) =>
            f.DepartingFrom == _flightRequirements.DepartingFrom &&
            f.TravellingTo == _flightRequirements.TravelingTo &&
            f.DepartureDate == _flightRequirements.DepartureDate);

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