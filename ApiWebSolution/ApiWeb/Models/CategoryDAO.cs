using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiWeb.Models
{
    public class CategoryDAO
    {
        public List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            try
            {
                using (var context = new MyStoreDBContext())
                {
                    listCategories = context.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCategories;
        }

    }
}
