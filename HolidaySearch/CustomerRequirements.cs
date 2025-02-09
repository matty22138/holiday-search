public interface IFlightRequirements
{
    public string DepartingFrom { get; }
    public string TravelingTo { get; }
    public string DepartureDate { get; }
}

public class CustomerRequirements : IFlightRequirements
{
    public string DepartingFrom { get; set; }
    public string TravelingTo { get; set; }
    public string DepartureDate { get; set; }
    public int Duration { get; set; }
}