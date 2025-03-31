namespace BlazorBasic
{
    public class PizzaSpecials
    {

        private int PizzaID { get; set; }
        private string PizzaName { get; set; }
        private decimal PizzaBasePrice { get; set; }
        private string PizzaDescription { get; set;}
        private string PizzaImageUrl { get; set; }
        public string GetFormattedBasePrice() => PizzaBasePrice.ToString("0.00");
    }
}
