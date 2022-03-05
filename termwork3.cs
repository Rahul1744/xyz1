using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term3
{

    class Program
    {
        class MyList
        {
            string[] names;
            public MyList()
            {
                names = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    names[i] = "No Name";
                }
            }

            public string this[int pos]
            {
                get
                {
                    return names[pos];
                }
                set
                {
                    names[pos] = value;
                }
            }

            public int this[string name]
            {
                get
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (names[i].Equals(name))
                        {
                            return i + 1;
                        }
                    }
                    return -1;
                }
                set
                {
                    names[value] = name;
                }
            }
        }
        static void Main(string[] args)
        {
            MyList list = new MyList();

            list[0] = "Ajay";
            list["Ajay"] = 3;

            Console.WriteLine("Ajay is at position "+ list["Ajay"]);
            Console.WriteLine("Name at position 3 is "+ list[3]);
            Console.ReadKey();
        }
    }
}
