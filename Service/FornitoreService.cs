using GO5_SupplierPreview.Domain;
using GO5_SupplierPreview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO5_SupplierPreview.Service
{
    public class FornitoreService
    {
        private readonly IRepository<Fornitori> _fornitoreRepo;

        public FornitoreService(IRepository<Fornitori> fornitoreRepo)
        {
            _fornitoreRepo = fornitoreRepo;
        }

        public async Task<IEnumerable<Fornitori>> GetAllFornitori()
        {
            return await _fornitoreRepo.GetAll();
        }
    }
}
