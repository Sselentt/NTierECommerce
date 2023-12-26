using Microsoft.EntityFrameworkCore;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;

        public BaseRepository(ECommerceContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }


        public async Task<string> Create(T entity)
        {
            //_context.Set<T>().Add(entity);
            try
            {
                await _context.AddAsync(entity);
                 _context.SaveChangesAsync();
                return "Kayıt başarılı!";
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }

        public async Task<string> Delete(T entity)
        {
            try
            {
                entity.Status=Entities.Enums.DataStatus.Deleted;
                await _context.SaveChangesAsync();
                return "Kayıt Silindi!!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Task<string> DestroyAllData(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> DestroyData(T entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return "Veriler Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable().ToList();
        }

        public IEnumerable<T> GetAllActive()
        {
            //return _entities.AsEnumerable();
            return _entities.AsEnumerable().ToList();

        }

        public IEnumerable<T> GetAllPassive()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            var getbyid = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return getbyid;
        }

        public async Task<string> Update(T entity)//Adidas
        {
            var updated = await _entities.FirstOrDefaultAsync(x => x.Id == entity.Id);//Nike Airmax

            //_context.Entry(updated).CurrentValues.SetValues(entity);

            //_context.Entry(entity).State = EntityState.Modified;

            //_context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
