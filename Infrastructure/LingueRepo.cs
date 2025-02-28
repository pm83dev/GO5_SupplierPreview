using GO5_SupplierPreview.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO5_SupplierPreview.Infrastructure
{
    public class LingueRepo : IRepository<Lingue>
    {
        private readonly DbContext _dbContext;

        public LingueRepo(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Lingue>> GetAll()
        {
            return await _dbContext.Set<Lingue>().ToListAsync();

        }
    }
}
