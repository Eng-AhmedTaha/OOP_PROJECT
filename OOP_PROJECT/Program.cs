using OOP_PROJECT;
using System.Diagnostics;
using System.Xml.Linq;
String s;
do
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("********* Menu OF Cars ************* " +
                        "\n 1- add Car TO Mercedes " +
                        " \n 2- add Car TO Lamborghini " +
                        "\n 3- add Car TO Hyundai" +
                        "\n 4- show Car From Mercedes " +
                        "\n 5- show Car From Lamborghini" +
                        " \n 6- show Car From Hyundai " +
                        "\n 7- search by id ");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("Enter Number of Choice From Menue  :");
    Console.WriteLine("---------------------------------------------");

    int ch = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    string name = "car";
    int id = 1;
    double price = 546164;
    string color = "Red";

    if (ch == 1 || ch == 2 || ch == 3)
    {
        Console.WriteLine("Enter Name OF Cars ");
        name = Console.ReadLine();

        Console.WriteLine("Enter Color OF Cars ");
        color = Console.ReadLine();

        Console.WriteLine("Enter Id OF Cars ");
        id = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter Price OF Cars ");
        price = Double.Parse(Console.ReadLine());

    }
    Console.Clear();

    switch (ch)
    {
        case 1:
            Mercedes mercedes = new Mercedes();
            mercedes.Name = name;
            mercedes.Price = price;
            mercedes.Id = id;
            mercedes.Color = color;
            mercedes.Add_Data();
            Console.WriteLine("Done Add");

            break;

        case 2:
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Name = name;
            lamborghini.Price = price;
            lamborghini.Id = id;
            lamborghini.Color = color;
            lamborghini.Add_Data();
            Console.WriteLine("Done Add");
            break;

        case 3:
            Hyundai hyundai = new Hyundai();
            hyundai.Name = name;
            hyundai.Price = price;
            hyundai.Id = id;
            hyundai.Color = color;
            hyundai.Add_Data();
            Console.WriteLine("Done Add");
            break;

        case 4:
            Mercedes mercedess = new Mercedes();
            string[] arr = mercedess.show_Data();
            for (int i = 0; i < arr.Length; i++)
            {
                var data = arr[i].Split(' ');
                if (data.Length < 4)
                {
                    Console.WriteLine("Invalid data format in entry: " + arr[i]);
                    continue;
                }
                Console.WriteLine("id is : " + data[0] + " " +
                                     "and name Cars is : " + data[1] +
                                    " price is :" + data[3] +
                                    "and color is " + data[2]);

            }
            break;

        case 5:
            Lamborghini lamborghinii = new Lamborghini();
            string[] arrr = lamborghinii.show_Data();
            for (int i = 0; i < arrr.Length; i++)
            {

                var data = arrr[i].Split(" ");  
                if (data.Length < 4)
                {
                    Console.WriteLine("Invalid data format in entry: " + arrr[i]);
                    continue;
                }

                Console.WriteLine("id is : " + data[0] + " " +
                    "and name Cars is : " + data[1] +
                   " price is :" + data[3] +
                   "and color is " + data[2]);
            }

            break;

        case 6:
            Hyundai hyundaii = new Hyundai();
            string[] arra = hyundaii.show_Data();
            for (int i = 0; i < arra.Length; i++)
            {
                var data = arra[i].Split(" ");
                if (data.Length < 4)
                {
                    Console.WriteLine("Invalid data format in entry: " + arra[i]);
                    continue;
                }

                Console.WriteLine("id is : " + data[0] + " " +
                    "and name Cars is : " + data[1] +
                   " price is :" + data[3] +
                   "and color is " + data[2]);
            }

            break;

        case 7 :
            Console.WriteLine("enter id ");
            int new_id = Int32.Parse(Console.ReadLine());
            Mercedes mercedesss = new Mercedes();
      Lamborghini lamborghiniii = new Lamborghini();
      Hyundai hyundaiii = new Hyundai();

            var o1 =  mercedesss.show_Data();
            var o2 = lamborghiniii.show_Data();
            var o3 = hyundaiii.show_Data();
           for(int i = 0;i<o1.Length;i++)
            {
                if(o1[i].Contains(new_id.ToString()))
                {
                    Console.WriteLine(o1[i]);
                }

            }

            for (int i = 0; i < o2.Length; i++)
            {
                if (o2[i].Contains(new_id.ToString()))
                    {
                    Console.WriteLine(o2[i]);   
                    }
            }
            for (int i = 0; i < o3.Length; i++)
            {
                if (o3[i].Contains(new_id.ToString()))
                {
                    Console.WriteLine(o3[i]);
                }
            }
            break;

        default:
            Console.WriteLine("Error");
            break;

    }
    Console.WriteLine("to show menu enter y  ");
    s = Console.ReadLine();
} while (s == "y");
