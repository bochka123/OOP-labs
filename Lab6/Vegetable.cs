using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Vegetable
    {
        public String name { get; }
        public int calorie { get; }
        public int price { get; }
        public int weight { get; }

        public Vegetable(String name, int calorie, int price, int weight)
        {
            this.name = name;
            this.calorie = calorie;
            this.price = price;
            this.weight = weight;
        }
    }
}
