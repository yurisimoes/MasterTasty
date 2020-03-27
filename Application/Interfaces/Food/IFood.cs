using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Application.Interfaces.Food{
    public interface IFood{
        Task<FoodEntity> Get(Guid id);
        Task<IEnumerable<FoodEntity>> GetAll();
        Task<FoodEntity> Post(FoodEntity tips);
        Task<FoodEntity> Put(FoodEntity tips);
        Task<bool> Delete(Guid id);
    }
}