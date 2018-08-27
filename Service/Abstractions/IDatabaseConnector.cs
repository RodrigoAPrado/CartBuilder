using Service.Models;
using Service.Models.Database;

namespace Service.Abstractions
 {
     /// <summary>
     /// Define a database connector.
     /// </summary>
     public interface IDatabaseConnector
     {
         /// <summary>
         /// Queries in the database and returns result.
         /// </summary>
         /// <param name="input">Input for query.</param>
         /// <returns>Query results.</returns>
         QueryResult<IProduct> Search(SearchInput input);
     }
 }