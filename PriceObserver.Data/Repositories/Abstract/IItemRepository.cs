﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PriceObserver.Model.Data;

namespace PriceObserver.Data.Repositories.Abstract
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAll();
        
        Task<Item> GetById(int id);

        Task<List<Item>> GetByUserId(long userId); 
        
        Task Add(Item item);

        Task Update(Item item);
        
        Task Delete(Item item);
    }
}