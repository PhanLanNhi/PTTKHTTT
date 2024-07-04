using Form1.MonAn.Model;

namespace Form1.MonAn.Services
{
    public class FoodService
    {
        public FoodService() { }

        public void ShowListFood(DataGridView dgv)
        {
            Food food = new Food();
            food.ShowListFood(dgv);
        }

        public string AddFood(string? id, string? name, string? price, string? dateup)
        {
            Food food = new Food()
            {
                idFood = id,
                nameFood = name,
                priceFood = price,
                dateUpdate = dateup
            };
            return food.AddFood();
        }

        public string UpdateFood(string? id, string? name, string? price, string? dateup)
        {
            Food food = new Food()
            {
                idFood = id,
                nameFood = name,
                priceFood = price,
                dateUpdate = dateup
            };
            return food.UpdateFood();
        }

        public string DeleteFood(string? id)
        {
            Food food = new Food()
            {
                idFood = id
            };
            return food.DeleteFood();
        }
    }
}
