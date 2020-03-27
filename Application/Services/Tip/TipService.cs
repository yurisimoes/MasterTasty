using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Interfaces.Tip;
using Core.Entities;

namespace Application.Services.Tip{
    public class TipService : ITips{

        private IRepository<TipsEntity> _repository;

        public TipService(IRepository<TipsEntity> repository){
            _repository = repository;
        }

        public async Task<TipsEntity> Get(Guid id){
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<TipsEntity>> GetAll(){
            return await _repository.GetAsync();
        }

        public async Task<TipsEntity> Post(TipsEntity tips){
            return await _repository.PostAsync(tips);
        }

        public async Task<TipsEntity> Put(TipsEntity tips){
            return await _repository.PutAsync(tips);
        }

        public async Task<bool> Delete(Guid id){
            return await _repository.DeleteAsync(id);
        }
    }
}