using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Core.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository{
    public class BaseRepository<T> : IRepository<T> where T: BaseEntity{

        protected readonly MyContext _context;
        private DbSet<T> _dataset;

        public BaseRepository(MyContext context ){
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<T> PostAsync(T item){
            try{
                if (item.Id == Guid.Empty){
                    item.Id = Guid.NewGuid();
                }
                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex){
                throw ex;
            }

            return item;
        }

        public async Task<T> PutAsync(T item){
            try{
                var result = await _dataset.SingleOrDefaultAsync(r => r.Id.Equals(item.Id));
                if (result == null)
                    return null;
                
                
                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;
                    
                _context.Entry(result).CurrentValues.SetValues(item);

                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex){
                throw ex;
            }

            return item;
        }

        public async Task<bool> DeleteAsync(Guid id){
            try{
                var result = await _dataset.SingleOrDefaultAsync(r => r.Id.Equals(id));
                if (result == null)
                    return false;
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public async Task<T> GetAsync(Guid id){
            try{
                return await _dataset.SingleOrDefaultAsync(r => r.Id.Equals(id));
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAsync(){
            try{
                return await _dataset.ToListAsync();
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(Guid id){
            return await _dataset.AnyAsync(e => e.Id.Equals(id));
        }
    }
}