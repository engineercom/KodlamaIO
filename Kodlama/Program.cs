using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;

namespace Kodlama;

internal class Program
{
    static void Main(string[] args)
    {
        //List Category
        
        CategoryManager categoryManager = new CategoryManager(new CategoryDAL());

        List<Category> listOfCategories = categoryManager.GetAll();

        Console.WriteLine("List Category");
        Console.WriteLine("************************************************************************");
        foreach (Category category in listOfCategories)
        {

            Console.WriteLine(category.Id+" " +category.Name);
        }
        //Add Category
        Category categoryNew = new Category() { Id=3,Name="Back End Developer"};
        categoryManager.Create(categoryNew);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Added List Category");
        Console.WriteLine("************************************************************************");
        foreach (Category category in listOfCategories)
        {

            Console.WriteLine(category.Id + " " + category.Name);
        }

        Console.WriteLine("************************************************************************");
        Console.WriteLine("Delete Category");
        Console.WriteLine("************************************************************************");
        categoryManager.Delete(1);
        foreach (Category category in listOfCategories)
        {

            Console.WriteLine(category.Id + " " + category.Name);
        }
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Update Category");
        Console.WriteLine("************************************************************************");
        Category categoryUpdate = new Category() { Id = 2, Name = "Full Stack" };
        categoryManager.Update(categoryUpdate);
        foreach (Category category in listOfCategories)
        {

            Console.WriteLine(category.Id + " " + category.Name);
        }

    }
}