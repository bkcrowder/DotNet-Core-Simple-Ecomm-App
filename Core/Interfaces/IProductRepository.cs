using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Retrieves product by id
        /// </summary>
        /// <param name="id">Identifier for the product</param>
        /// <returns></returns>
        Task<Product> GetProductByIdAsync(int id);

        /// <summary>
        /// Retrieves product brand by id
        /// </summary>
        /// <param name="id">Identifier for the product brand</param>
        /// <returns></returns>
        Task<ProductBrand> GetProductBrandByIdAsync(int id);

        /// <summary>
        /// Retrieves product type by id
        /// </summary>
        /// <param name="id">Identifier for the product type</param>
        /// <returns></returns>
        Task<ProductType> GetProductTypeByIdAsync(int id);

        /// <summary>
        /// Retrieves all Products
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductsAsync();

        /// <summary>
        /// Retrieves all Product Brands
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();

        /// <summary>
        /// Retrieves all Product Types
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();

        /// <summary>
        /// Add a Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Product> AddProductAsync(Product product);

        Task DeleteProductAsync(int id);

        void DeleteProductAsync(Product product);

        Product UpdateProductAsync(Product product);
    }
}