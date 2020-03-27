using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Interfaces.Food;
using Core.Entities;

namespace Application.Services.Food{
    public class FoodService : IFood{

        private IRepository<FoodEntity> _repository;

        public FoodService(IRepository<FoodEntity> repository){
            _repository = repository;
        }
        
        public async Task<FoodEntity> Get(Guid id){
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<FoodEntity>> GetAll(){
            return await _repository.GetAsync();
        }

        public async Task<FoodEntity> Post(FoodEntity tips){
            return await _repository.PostAsync(tips);
        }

        public async Task<FoodEntity> Put(FoodEntity tips){
            return await _repository.PutAsync(tips);
        }

        public async Task<bool> Delete(Guid id){
            return await _repository.DeleteAsync(id);
        }
    }
}