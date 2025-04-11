using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechXpress.Models;

namespace TechXpress.BLL.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

    }
}
