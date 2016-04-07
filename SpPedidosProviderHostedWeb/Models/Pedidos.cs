namespace SpPedidosProviderHostedWeb.Models
{
    public class Pedidos
    {
        public string Cliente { get; set; }
        public string Pedido { get; set; }
        public int Unidades { get; set; }
        public double Total { get; set; }
        public int idProducto { get; set; }
    }
}