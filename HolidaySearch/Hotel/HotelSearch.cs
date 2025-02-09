public interface IHotelSearch
{
    IEnumerable<Hotel> Search();
}

public class HotelSearch : IHotelSearch
{
    public IEnumerable<Hotel> Search()
    {
        throw new NotImplementedException();
    }
}