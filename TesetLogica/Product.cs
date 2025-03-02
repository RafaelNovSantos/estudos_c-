namespace TesetLogica;

public class Product
{
    public int Codigo { get; set; }
    public double Preco { get; set; }

    public double CalculoValorTotal( int numeropeca, int quantidade)
    {
        double valor = 0;
        List<Product> products = new List<Product>();
        products.Add(new Product()
        {
            Codigo = 12, 
            Preco = 5.30
        });
        products.Add(new Product() { Codigo = 16, Preco = 5.10 });
        products.Add(new Product() { Codigo = 13, Preco = 15.30 });
        products.Add(new Product() { Codigo = 161, Preco = 5.20 });
        products.Add(new Product() { Codigo = 1, Preco = 15.10 });
        products.Add(new Product() { Codigo = 2, Preco = 15.10 });
        
        foreach (var itemProduct in products)
        {
            if (itemProduct.Codigo == numeropeca)
            {
               valor = itemProduct.Preco * quantidade;
            }
            
        }

        return valor;
    }
}