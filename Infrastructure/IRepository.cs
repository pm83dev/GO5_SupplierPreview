using GO5_SupplierPreview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO5_SupplierPreview.Infrastructure
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
    }
}
