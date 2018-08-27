namespace Service.Models.Database
{
    /// <summary>
    /// Defines a product in the database.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Name of the product.
        /// </summary>
        string Name { get; set; }
    }
}