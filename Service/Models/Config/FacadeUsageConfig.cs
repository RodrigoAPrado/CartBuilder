using System.Runtime.Serialization;

namespace Service.Models
{
    /// <summary>
    /// Defines which facades to use.
    /// </summary>
    [DataContract]
    public class FacadeUsageConfig
    {
        /// <summary>
        /// Defines the type of facade to use (e.g. Default).
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}