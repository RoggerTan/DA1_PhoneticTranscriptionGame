using System.Threading.Tasks;

namespace echo_main.BS_layer.DBFunc
{
    interface IDbFunction<TId, TEntity>
    {
        Task Create(TEntity obj);
        Task<TEntity> Read(TId id);
        Task Update(TId id, TEntity obj);
        Task Delete(TId id);
    }
}
