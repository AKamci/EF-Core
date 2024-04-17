using EF_CodeFirst;
using EF_CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    foreach (var item in products)
    {
        Console.WriteLine($"{item.Id} : {item.Name} : {item.Price}");
    }

}

