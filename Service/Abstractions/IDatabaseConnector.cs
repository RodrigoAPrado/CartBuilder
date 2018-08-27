using Service.Models;

namespace Service.Abstractions
 {
     /// <summary>
     /// Define a database connector.
     /// </summary>
     public interface IDataBaseConnector
     {
         /// <summary>
         /// Queries in the database and returns result.
         /// </summary>
         /// <param name="input">Input for query.</param>
         /// <returns>Query results.</returns>
         bool Search(SearchInput input);
     }
 }