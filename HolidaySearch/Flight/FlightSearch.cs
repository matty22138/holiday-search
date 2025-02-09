public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    public IEnumerable<Flight> ExactSearch()
    {
        throw new NotImplementedException();
    }
}