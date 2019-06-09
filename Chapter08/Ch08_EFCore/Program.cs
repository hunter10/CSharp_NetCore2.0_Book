
using static System.Console;
using Packt.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore.Storage;

namespace Ch08_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            using(var db = new Northwind())
            {
                // 트랜젝션 처리
                using(IDbContextTransaction t = db.Database.BeginTransaction())
                {
                    WriteLine($"Transaction started with this isolation level: {t.GetDbTransaction().IsolationLevel}");
                

                // 로그처리
                //var loggerFactory = db.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(new ConsoleLogProvider());

                WriteLine("List of categories and the number of products:");

                IQueryable<Category> cats =
                    db.Categories.Include(c => c.Products);

                foreach(Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }

                WriteLine("List of products that cost more than a given price with most expensive first.");
                string input;
                decimal price;

                do{
                    Write("Enter a product price:");
                    input = ReadLine();
                }while(!decimal.TryParse(input, out price));

                IQueryable<Product> prods = db.Products
                .Where(product => product.UnitPrice > price)
                .OrderByDescending(product => product.UnitPrice);

                foreach(Product item in prods)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }



                /* 
                var newProduct = new Product{
                    CategoryID = 6,
                    ProductName = "Bob's burger",
                    UnitPrice = 500M
                };
                
                // 새 product를 추가한다.
                db.Products.Add(newProduct);

                // 변경사항을 데이터베이스에 저장한다.
                db.SaveChanges();

                //foreach(var item in db.Products)
                //{
                //    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                //}

                
                /*
                // 엔티티 업데이트
                Product updateProduct = db.Products.First(
                    p => p.ProductName.StartsWith("Bob")
                );
                updateProduct.UnitPrice += 20M;
                db.SaveChanges();
                foreach(var item in db.Products)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }
                */


                /*
                // 엔티티 삭제
                Product deleteProduct = db.Products.First(
                    p => p.ProductName.StartsWith("Bob")
                );
                db.Products.Remove(deleteProduct);
                db.SaveChanges();
                foreach(var item in db.Products)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }
                //*/



                foreach(var item in db.Products)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }

                t.Commit();
                }
            }
   
        }
    }
}
