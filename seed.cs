using BackHost.DBs;
using Microsoft.EntityFrameworkCore;

namespace BackHost
{
 public class SeedClass
 {
 public async static Task<bool> AddProvincesAndCitiesAsync(IServiceProvider _serviceProvider)
 {
 var _context = _serviceProvider.CreateScope().ServiceProvider.GetService<DB>();

 //var test =await _context.Products.Where(c => c.Labels.Any(d => d == 1)).ToListAsync();
 var e = await _context.Cities.AnyAsync(c => c.Id > 0);
 foreach (var item in new string[] {"ايلام","ايوان","آبدانان","دره شهر","دهلران"})
 {
 _context.Add(new City { Title = item });
 } 
 foreach (var item in new string[] {
 "مزايده",
"راي محاکم قضائي",
"ايين نامه فروش خانه هاي سازماني",
"مزايده",
"ماده 8",
"نامعلوم",
"ماده 8",
"دستور مقام عالي وزارت",
"قانون فروش خانه هاي سازماني",
"دستور مقام عالي وزارت"


 })
 {
 _context.Add(new SellMethod { Title = item });
 }
 return true;
 }
 }
}
