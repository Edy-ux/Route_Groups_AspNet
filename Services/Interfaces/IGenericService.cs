using Route_Groups_AspNet.Models;
using System.Collections.Generic;

namespace Route_Groups_AspNet.Services.Interfaces;

public interface IGenericService<TEntity> where TEntity : class
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<IEnumerable<TEntity>> GetAsync();

}
