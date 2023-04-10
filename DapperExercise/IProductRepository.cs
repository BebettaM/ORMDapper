using System;
namespace DapperExercise
{
	public interface IProductRepository

    {
        IEnumerable<Product> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
        public void DeleteProduct(int productID);
        public void UpdateProduct(int productID, string updateName);
    }
}

