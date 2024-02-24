
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistance.Repositories;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IRepository<Brand, Guid>, IAsyncRepository<Brand, Guid>
    {

    }
}
