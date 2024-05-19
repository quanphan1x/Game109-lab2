using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai1
{
    
    public class bai1c
    {
        public int id;
        public int level;
        public string name;

        public bai1c()
        {
            id = 0;
            level = 0;
            name = "null";
        }
        public bai1c(int id, int level, string name)
        {
            this.id = id;
            this.level = level;
            this.name = name;
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Id: " + id);
        }
        public static void XuatThongTin(String attributeName, dynamic attribute)
        {
            Console.WriteLine(attributeName + " " + attribute);
        }
    }
}
