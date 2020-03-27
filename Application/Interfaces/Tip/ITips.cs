using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Application.Interfaces.Tip{
    public interface ITips{
        Task<TipsEntity> Get(Guid id);
        Task<IEnumerable<TipsEntity>> GetAll();
        Task<TipsEntity> Post(TipsEntity tips);
        Task<TipsEntity> Put(TipsEntity tips);
        Task<bool> Delete(Guid id);
    }
}