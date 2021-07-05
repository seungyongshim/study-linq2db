namespace Sample.Tests.Model
{
    using LinqToDB.Mapping;

    [Table(Name = "Products")]
    public record Product
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column, NotNull]
        public string Name { get; set; }
    }
}
