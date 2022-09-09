using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class PizzaService
    {
        static List<pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<pizza>
                {
                    new pizza { Id = 1, Name = "Classic Italian", Price=20.00M, Size=PizzaSize.Large, IsGlutenFree = false },
                    new pizza { Id = 2, Name = "Veggie", Price=15.00M, Size=PizzaSize.Small,IsGlutenFree = true }
                };
        }

        public static List<pizza> GetAll() => Pizzas;

        public static pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }
    }
}
