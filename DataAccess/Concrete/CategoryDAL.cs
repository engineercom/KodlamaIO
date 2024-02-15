using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class CategoryDAL : IDAL<Category>
{
    List<Category> categories;
    public CategoryDAL()
    {
        Category category1 = new Category() { Id = 1, Name = "Programlama" };
        Category category2 = new Category() { Id = 2, Name = "Front End" };
        categories = new List<Category>() { category1, category2 };

    }
    public Category Create(Category category)
    {
        categories.Add(category);
        return category;
    }


    public void Delete(int id)
    {
        foreach (var item in categories)
        {
            if (item.Id == id)
            {
                categories.Remove(item);
                break;
            }

        }

    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category Update(Category category)
    {
       Category cat=  CategoryById(category.Id);
        cat.Name = category.Name;

        return cat;

    }
    Category CategoryById(int id)
    {
        return categories.Find(x=>x.Id==id);

    }
}
