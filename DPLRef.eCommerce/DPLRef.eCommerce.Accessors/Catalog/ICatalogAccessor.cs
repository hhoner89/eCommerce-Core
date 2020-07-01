using DPLRef.eCommerce.Common.Shared;
using DPLRef.eCommerce.Accessors.DataTransferObjects;

// Cencept : Accessor
// Sub System : Catalog
namespace DPLRef.eCommerce.Accessors.Catalog
{
    public interface ICatalogAccessor : IServiceContractBase
    {
        #region Core Code - DPLRef.eCommerce.Accessors.Catalog ICatalogAccessor Interfaces
        WebStoreCatalog Find(int catalogId);

        WebStoreCatalog SaveCatalog(WebStoreCatalog catalog);

        void DeleteCatalog(int id);

        WebStoreCatalog[] FindAllSellerCatalogs();

        Product[] FindAllProductsForCatalog(int catalogId);

        Product FindProduct(int id);

        Product SaveProduct(int catalogId, Product product);

        void DeleteProduct(int catalogId, int id);
        #endregion

        #region Lab 21 - LINQ Primer - ICatalogAccessor New Interfaces

        Product[] AllProductsInRange(decimal low, decimal high);

        Product[] AllProductsFromSupplier(string supplierName);

        ProductsBySupplierItem[] ProductsBySupplier();

        void UpdatePrice(int id, decimal price);        
        #endregion

    }

    #region - Lab 21 - LINQ Primer - ICatalogAccessor New Class
    public class ProductsBySupplierItem
    {
        public string Supplier { get; set; }
        public int Count { get; set; }
    }
    #endregion

}
