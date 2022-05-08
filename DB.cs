using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackHost.DBs
{
    public class Vahed:BaseModel
    {
        public string? ShomareVahed { get; set; }
        public int VaziateForoosh { get; set; }
        public long? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public string? Code { get; set; }
        public int VaziateSanad{ get; set; }
        public string? NameBahreBardar { get; set; }
        public string? FamilyBahreBardar { get; set; }
        public string? SematBahreBardar { get; set; }
        [ForeignKey("DastgaheMoarrefiKonnande")]
        public Organization Organization { get; set; }
        public long? DastgaheMoarrefiKonnande { get; set; }
        public string? GharardadShomare { get; set; }
        public DateTime? GharardadTarikh { get; set; }
        public string? GharardadModdat { get; set; }
        public string? GharardadEjare { get; set; }
        public int Ejare98 { get; set; }
        public int Ejare99 { get; set; }
        public int MablaghNamayandegi { get; set; }
        public int ArzesheKarshenasi { get; set; }
        public int ElamBeDarayi { get; set; }
        [ForeignKey("NahveForoosh")]
        public SellMethod SellMethod { get; set; }
        public long? NahveForoosh { get; set; }
        public string? ShomareVagozari { get; set; }
        public DateTime? TarikhVagozari { get; set; }
        public string? ShomareNamayandegi { get; set; }
        public DateTime? TarikhNamayandegi { get; set; }
        public int VaziateVahed { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }


        public List<Document> Gharardad { set; get; }
        public List<Document> HeyatNamayandegi { set; get; }
        public List<Document> Estelam { set; get; }
        public List<Document> Karshenasi { set; get; }
        public List<Document> EjareName { set; get; }
        public List<Document> MadrakGhabli { set; get; }
        public List<Document> MadrakFeli { set; get; }
        public List<Document> Korooki { set; get; }
        public List<Document> Sanad { set; get; }
        public List<Document> SayerMostanadat { set; get; }
    }
    public class Document
    {
        public string Title{ get; set; }
        public string Url{ get; set; }
    }
    [SafeToGetAll]
    [Index(nameof(Title), IsUnique = true)]
    public class City: BaseModelWithTitle
    {

    }
    [SafeToGetAll]
    [Index(nameof(Title), IsUnique = true)]
    public class Organization : BaseModelWithTitle
    {

    } 
    [SafeToGetAll]
    [Index(nameof(Title), IsUnique = true)]
    public class SellMethod : BaseModelWithTitle
    {

    }

    public class DB : BaseWebSiteDBContext
    {
        public DbSet<Vahed> Vaheds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<SellMethod> SellMethods { get; set; }
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vahed>().Property(e => e.Gharardad).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.HeyatNamayandegi).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.Estelam).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.Karshenasi).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.EjareName).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.MadrakGhabli).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.MadrakFeli).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.Korooki).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.Sanad).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
            modelBuilder.Entity<Vahed>().Property(e => e.SayerMostanadat).HasConversion(v => JsonConvert.SerializeObject(v), v => JsonConvert.DeserializeObject<List<Document>>(v));
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
