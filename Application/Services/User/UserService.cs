using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Interfaces.User;
using Core.Entities;

namespace Application.Services.User{
    public class UserService : IUser{

        private IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository){
            _repository = repository;
        }
        
        public async Task<UserEntity> Get(Guid id){
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll(){
            return await _repository.GetAsync();
        }

        public async Task<UserEntity> Post(UserEntity user){
            return await _repository.PostAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user){
            return await _repository.PutAsync(user);
        }

        public async Task<bool> Delete(Guid id){
            return await _repository.DeleteAsync(id);
        }
    }
}