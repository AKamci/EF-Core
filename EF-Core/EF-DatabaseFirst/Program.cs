using EF_DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

using (var _context =new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

	foreach (var item in products)
	{
		Console.WriteLine($"{item.Id} : {item.Name} : {item.Price}");
	}

}