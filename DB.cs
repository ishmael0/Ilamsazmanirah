using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackHost.DBs
{
    public enum NahveForoosh
    {

    }
    public enum SanadStatus
    {
        Has,
        Hasnot
    }
    public class Vahed:BaseModel
    {
        public int VahedId { get; set; }
        public string? ShomareVahed { get; set; }
        public long CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public string? Code { get; set; }
        public SanadStatus SanadStatus { get; set; }
        public string? NameBahreBardar { get; set; }
        public string? FamilyBahreBardar { get; set; }
        public string? SematBahreBardar { get; set; }
        public string? DastgaheMoarrefiKonnande { get; set; }
        public string? GharardadShomare { get; set; }
        public DateTime? GharardadTarikh { get; set; }
        public string? GharardadModdat { get; set; }
        public string? GharardadEjare { get; set; }
        public int Ejare98 { get; set; }
        public int Ejare99 { get; set; }
        public int MablaghNamayandegi { get; set; }
        public int ArzesheKarshenasi { get; set; }
        public int ElamBeDarayi { get; set; }
        public int NahveForoosh { get; set; }
        public string? ShomareVagozari { get; set; }
        public DateTime TarikhVagozari { get; set; }
        public string? ShomareNamayandegi { get; set; }
        public DateTime TarikhNamayandegi { get; set; }
        public int VaziateVahed { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }

    }
    [SafeToGetAll]
    public class City: BaseModelWithTitle
    {

    }
    public class DB : BaseWebSiteDBContext
    {
        public DbSet<Vahed> Vaheds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Category>().Property(e => e.Images).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Images>>(v));
        }
    }
    public class MAINDBContextFactory : IDesignTimeDbContextFactory<DB>
    {
        public DB CreateDbContext(string[] args)
        {
            var o = AppSettingService.GetDbContextOptionsBuilder<DB>(nameof(BackHost));
            return new DB(o.Options);
        }
    }
}
