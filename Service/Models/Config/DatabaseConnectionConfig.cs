using System.Runtime.Serialization;

namespace Service.Models
{
    /// <summary>
    /// Defines database connection configuration.
    /// </summary>
    [DataContract]
    public class DatabaseConnectionConfig
    {
        /// <summary>
        /// The type of database to be used.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
        
        /// <summary>
        /// The connection string to be used.
        /// </summary>
        [DataMember(Name = "connection")]
        public string Connection { get; set; }
        
        /// <summary>
        /// The name of the database to be used.
        /// </summary>
        [DataMember(Name = "database_name")]
        public string DatabaseName { get; set; }
    }
}