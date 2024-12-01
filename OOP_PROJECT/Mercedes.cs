using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    internal class Mercedes : Cars
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Color { set; get; }
        public double Price { set; get; }

        public void Add_Data()
        {
            File.AppendAllText("M.txt", Id + " " + Name + " " + Color + " " + Price + "*");
        }

        public string[] show_Data()
        {
            string g = File.ReadAllText("M.txt");
            return g.Split('*');
        }
    }
    }

