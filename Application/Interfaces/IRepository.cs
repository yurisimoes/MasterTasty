using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Application.Interfaces{
    public interface IRepository<T> where T : BaseEntity{
        Task<T> PostAsync(T item);
        Task<T> PutAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAsync();
        Task<bool> ExistAsync(Guid id);
        
    }
}