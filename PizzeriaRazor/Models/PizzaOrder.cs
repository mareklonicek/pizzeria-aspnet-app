namespace RazorPizzeria.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public string? PizzaName { get; set; }
        public float? PizzaPrice { get; set; }
        public DateTime PizzaDate { get; set; } = DateTime.Now;
		public bool PremiumPresentPackage { get; set; }
	}
}
