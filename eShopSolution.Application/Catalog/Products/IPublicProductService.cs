using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Catalog.Products;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
