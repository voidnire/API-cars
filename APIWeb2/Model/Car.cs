namespace APIWeb2.Model
{
    public class Car
    { //Code first: primeiro cria a entidade e depois cria as tabelas
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
