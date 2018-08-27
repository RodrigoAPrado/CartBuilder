using System.Runtime.Serialization;

namespace Service.Models
{
    /// <summary>
    /// Defines the input of a search from client.
    /// </summary>
    [DataContract]
    public class SearchInput
    {
        /// <summary>
        /// Search string data.
        /// </summary>
        public string Search { get; set; }
    }
}