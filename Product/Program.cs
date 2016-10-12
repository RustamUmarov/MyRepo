using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = new Program();
            var number1 = a.ToList("62354623458723642");
            var number2 = a.ToList("82648234723643287");
            
        }
        public List<Int16> ToList(String number) {
            List<Int16> numberList = new List<Int16>();
            for (int i = 0; i < number.Length; i++) 
            {
                var sub1 = number.Substring(0, 1);
                numberList.Add(Int16.Parse(sub1));
            }
            return numberList;
        }
    }
}
