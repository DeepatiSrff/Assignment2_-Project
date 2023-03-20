using System.Collections.Generic;

namespace LoginForm.Models
{
	public class Repository : IRepository
	{
		private Dictionary<string, Product> products;
		public Repository()
		{
			products = new Dictionary<string, Product>();
			new List<Product>
		{
			new Product { Id=001 , Name = "Flask" , Quantity = 4 , Price = 39.00M , TotalPrice = 156.00M },
			new Product { Id=002 , Name = "Flash" , Quantity = 2 , Price = 79.00M , TotalPrice = 158.00M },
			new Product { Id=003 , Name = "Direction" , Quantity = 1 , Price = 121.00M , TotalPrice = 121.00M },
			new Product { Id=004 , Name = "Web Tool" , Quantity = 5 , Price = 19.00M , TotalPrice = 95.00M },
		}.ForEach(p=>AddProduct(p));
	}

	public IEnumerable<Product> Products => products.Values;
	public Product this[string name] => products[name];
	public void AddProduct(Product product) => products[product.Name] = product;
	public void DeleteProduct(Product product) => products.Remove(product.Name);
}
}
