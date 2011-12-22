using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsingEntityFrameworkModel;
using System.Data;

namespace UpdatingDeletingInsertingData
{
    class UpdatingDeletingInsertingData
    {
        static void CreateNewProduct(NorthwindEntities northwindEntities, string productName, bool discontinued)
        {
            Product newProduct = new Product{
                ProductName = productName,
                Discontinued = discontinued
            };
            northwindEntities.Products.AddObject(newProduct);

            Update(northwindEntities);
        }

        static void DeleteProduct(NorthwindEntities northwindEntities, Product product)
        {
            northwindEntities.Products.DeleteObject(product);
            Update(northwindEntities);
        }

        static Product GetProductById(NorthwindEntities northwindEntities, int productId)
        {
            return northwindEntities.Products.FirstOrDefault(product => product.ProductID == productId);
        }
 
        static void Update(NorthwindEntities northwindEntities)
        {
            northwindEntities.SaveChanges();
        }

        static void Main()
        {
            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {
                //       Creating
                CreateNewProduct(northwindEntities, "newProduct", false);
                //       Updating
                //Product productToUpdate = GetProductById(northwindEntities,15);
                //if (productToUpdate != null)
                //{
                //    productToUpdate.ProductName += " changed";
                //    Update(northwindEntities);
                //}
                //        Deleting
                //Product productToDelete = GetProductById(northwindEntities, 16);
                //DeleteProduct(northwindEntities, productToDelete);
            }
        }
    }
}
