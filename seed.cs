using BackHost.DBs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BackHost
{
    public class SeedClass
    {
        public async static Task<bool> AddProvincesAndCitiesAsync(IServiceProvider _serviceProvider)
        {
            var x = _serviceProvider.CreateScope().ServiceProvider;
            var _context = x.GetService<DB>();
            var AccDB = x.GetRequiredService<AccDB>();
            var roleManager = x.GetRequiredService<RoleManager<BaseApplicationRole>>();
            var userManager = x.GetRequiredService<UserManager<BaseApplicationUser>>();
            //var test =await _context.Products.Where(c => c.Labels.Any(d => d == 1)).ToListAsync();
            var permissiondb = await AccDB.Permissions.FirstOrDefaultAsync(c => c.Title == "DB");
            var permissionCity = await AccDB.Permissions.FirstOrDefaultAsync(c => c.Title == "DB/City");
            var permissionVahed = await AccDB.Permissions.FirstOrDefaultAsync(c => c.Title == "DB/Vahed");
            var e = await _context.Cities.AnyAsync(c => c.Id > 0);
            if (e) return false;
            foreach (var item in new string[] {
"ایلام"    +"_"+"ilam" ,
"ایوان"   +"_"+"ivan" ,
"آبدانان" +"_"+"abdanan" ,
"دهلران"  +"_"+"dehloran" ,
"دره شهر" +"_"+"dareshahr" ,
"مهران"   +"_"+"mehran" ,
"ملکشاهی" +"_"+"malekshahi" ,
"سیروان"  +"_"+"sirvan" ,
"چرداول"  +"_"+"chardavol" ,
"هلیلان"   +"_"+"halilan" ,
"چوار"    +"_"+"chavar" ,
"بدره"    +"_"+"bazre"
})
            {
                var city = new City { Title = item };
                _context.Add(city);
                await _context.SaveChangesAsync();
                var user = new BaseApplicationUser()
                {
                    Avatar = "",
                    Create = DateTime.Now,
                    UserName = item.Split("_")[1],
                    FirstName = "مدیر",
                    LastName = item.Split("_")[0],
                    EmailConfirmed = true,
                    Status = Statuses.Active,
                    Email = item.Split("_")[1] + "@gmail.com"
                };
                var role = new BaseApplicationRole() { Color = "#ff0000", Create = DateTime.Now, Title = item, Name = item.Split("_")[1] };
                await roleManager.CreateAsync(role);
                await userManager.CreateAsync(user, "123456789");
                await userManager.AddToRoleAsync(user, item.Split("_")[1]);
                var p = new RolePermission()
                {
                    EntityIds = new List<long> { city.Id },
                    PermissionId = permissionCity.Id,
                    RoleId = role.Id,
                    Title = permissionCity.Title,
                    Access=new List<string> { "Get"}
                };
                AccDB.RolePermissions.Add(p);
                var p2 = new RolePermission()
                {
                    EntityIds = new List<long> { },
                    PermissionId = permissiondb.Id,
                    RoleId = role.Id,
                    Title = permissiondb.Title,
                    Access = new List<string> { "View", "Get" }
                };
                AccDB.RolePermissions.Add(p2);
                var p3 = new RolePermission()
                {
                    EntityIds = new List<long> { },
                    PermissionId = permissionVahed.Id,
                    RoleId = role.Id,
                    Title = permissionVahed.Title,
                    Access = new List<string> { "Export", "Delete", "Set", "Get", "UploadAsync", "GetSingle", "View" }
                };
                AccDB.RolePermissions.Add(p3);
                await _context.SaveChangesAsync();
                await AccDB.SaveChangesAsync();
            }
            //foreach (var item in new string[] { "ايلام", "ايوان", "آبدانان", "دره شهر", "دهلران" })
            //{
            //    _context.Add(new City { Title = item });
            //}
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
