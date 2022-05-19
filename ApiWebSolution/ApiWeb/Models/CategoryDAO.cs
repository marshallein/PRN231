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


        public void AddCategory(Category category)
        {
            try
            {
                using (var context = new MyStoreDBContext())
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                using (var context = new MyStoreDBContext())
                {
                    context.Categories.Update(category);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void DeleteCategory(int CategoryId)
        {
            try
            {
                using (var context = new MyStoreDBContext())
                {
                    context.Categories.Remove(context.Categories.Where(x => x.CategoryId == CategoryId).FirstOrDefault());
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public Category GetCategory(int CategoryId)
        {
            try
            {
                using (var context = new MyStoreDBContext())
                {
                    return context.Categories.Where(x => x.CategoryId == CategoryId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
