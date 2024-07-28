using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class ProductRepo : GenericRepo<Product>, IProductRepo
    {

        public ProductRepo(DataContext context) : base(context)
        {
        }
    }
}
