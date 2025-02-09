public interface IFlightSearch
{
    IEnumerable<Flight> Search();
}

public class FlightSearch : IFlightSearch
{
    public IEnumerable<Flight> Search()
    {
        throw new NotImplementedException();
    }
}