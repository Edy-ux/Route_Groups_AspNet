using Route_Groups_AspNet.Model;
using System.Collections.Generic;

namespace Route_Groups_AspNet.Services.Interfaces;

public interface IGenericService<TEntity> where TEntity : class
{
    TEntity InsertAsync(TEntity entity);
    IEnumerable<TEntity> GetAsync();

}
