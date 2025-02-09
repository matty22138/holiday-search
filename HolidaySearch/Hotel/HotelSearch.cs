public interface IHotelSearch
{
    IEnumerable<Hotel> ExactSearch();
}

public class HotelSearch : IHotelSearch
{
    public IEnumerable<Hotel> ExactSearch()
    {
        throw new NotImplementedException();
    }
}