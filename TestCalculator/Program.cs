using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // create collection or list

            List<MyElement> my_list = new List<MyElement>();

            MyElement element1 = new MyElement();
            MyElement element2 = new MyElement();
            MyElement element3 = new MyElement();

            element1.info = "element1";
            element2.info = "element2";
            element3.info = "element3";

            my_list.Add(element2);
            my_list.Add(element3);


            // iterators
            // foreach (type_of_element var_name in list_name){

            // var_name
            //}
            foreach (MyElement current_element in my_list) {

                Console.WriteLine(current_element.info);
            }



            my_list.Remove(element2);

            Console.WriteLine("After delete");

            foreach (MyElement current_element in my_list)
            {

                Console.WriteLine(current_element.info);
            }

            my_list.Clear();

            Console.ReadKey();

        }
    }
}
