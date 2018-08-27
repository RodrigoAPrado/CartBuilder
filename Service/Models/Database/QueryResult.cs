using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Models.Database
{
    /// <summary>
    /// Defines the results of a query.
    /// </summary>
    /// <typeparam name="T">Type of the result.</typeparam>
    [DataContract]
    public class QueryResult<T>
    {
        private List<T> Results { get; set; }    
    }
}