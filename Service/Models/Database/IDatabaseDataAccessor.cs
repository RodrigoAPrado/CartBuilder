namespace Service.Models.Database
{
    public interface IDatabaseDataAccessor<T>
    {
        T Data { get; set; }    
    }
}