using EF_DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;


DbContextInitilalizer.Build();

using (var _context =new AppDbContext(DbContextInitilalizer.OptionsBuilder.Options))
{
    var products = await _context.Products.ToListAsync();

	foreach (var item in products)
	{
		Console.WriteLine($"{item.Id} : {item.Name} : {item.Price}");
	}

} 