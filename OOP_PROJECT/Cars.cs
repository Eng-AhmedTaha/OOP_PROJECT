using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    internal interface Cars
    {
        int Id { set; get; }
        string Name { set; get; }
        string  Color { set; get; }
        double Price { set; get; }

        void Add_Data();
        string[] show_Data();
    }
}
