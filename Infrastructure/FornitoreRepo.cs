using GO5_SupplierPreview.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GO5_SupplierPreview.Infrastructure
{
    public class FornitoreRepo : IRepository<Fornitori>
    {
        private readonly DbContext _dbContext;

        public FornitoreRepo(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<Fornitori>> GetAll()
        {
            return await _dbContext.Set<Fornitori>().ToListAsync();    

        }
    }
}
