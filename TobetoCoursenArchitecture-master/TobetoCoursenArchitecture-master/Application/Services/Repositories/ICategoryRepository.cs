using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistance.Repositories;

namespace Application.Services.Repositories
{
    //Senkron ve asenkron içerik için iki tane interface tanımlıyoruz
    public interface ICategoryRepository : IRepository<Category,int> , IAsyncRepository<Category,int>
    {
        //Sadece kategoriye özel durumlar buraya yazılır.
    }
}
