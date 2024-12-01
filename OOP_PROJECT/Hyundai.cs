using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_PROJECT
{
    internal class Hyundai : Cars
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Color { set; get; }
        public double Price { set; get; }

        public void Add_Data()
        {
            File.AppendAllText("H.txt", Id + " " + Name + " " + Color + " " + Price + "*");
        }

        public string[] show_Data()
        {
       string d = File.ReadAllText("H.txt");
            return d.Split('*');
        }
    }
}
