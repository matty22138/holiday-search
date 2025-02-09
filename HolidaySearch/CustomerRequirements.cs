public interface IFlightRequirements
{
    public string DepartingFrom { get; }
    public string TravelingTo { get; }
    public string DepartureDate { get; }
}

public interface IHotelRequirements
{
    public string TravelingTo { get; set; }
    public string DepartureDate { get; set; }
    public int Duration { get; set; }
}

public class CustomerRequirements : IFlightRequirements, IHotelRequirements
{
    public string DepartingFrom { get; set; }
    public string TravelingTo { get; set; }
    public string DepartureDate { get; set; }
    public int Duration { get; set; }
}