using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    internal class Lamborghini : Cars
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Color { set; get; }
        public double Price { set; get; }

        public void Add_Data()
        {
            File.AppendAllText("L.txt", Id + " " + Name + " " + Color + " " + Price + "*");
        }

        public string[] show_Data()
        {
            string data = File.ReadAllText("L.txt");
            return data.Split('*');
        }
    }
}
