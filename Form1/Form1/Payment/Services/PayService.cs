using Form1.Payment.Model;

namespace Form1.Payment.Services
{
    public class PayService
    {
        public void AddItemToListView(string? food, ListView lv)
        {
            Pay pay = new Pay()
            {
                NameProduct = food
            };

            pay.AddItemToListView(lv);
        }
    }
}
