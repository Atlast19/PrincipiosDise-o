// See https://aka.ms/new-console-template for more information

namespace KISS 
{
    class program 
    {
        public static void Main(String[] args) 
        {

        }
        public class RestaurantBill
        {
            private decimal total = 0;
            private decimal Precentage = 0.10m;
            public decimal CalculateTotal(decimal[] prices, decimal? tipePercentage)
            {

                foreach (var i in prices)
                {
                    total += i;
                }

                total += total * (tipePercentage.HasValue ? tipePercentage.Value / 100 : Precentage);

                return total;
            }
        }
    }
}
