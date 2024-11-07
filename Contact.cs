using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class Contact
    {
        //свойство имя
        public string name { get; set; }

        //свойство номер телефона
        public string phone { get; set; }


        // конструктор по умолчванию
        public Contact()
        {
        }

        // конструктор присваивания
        public Contact(string Name, string Phone)
        {
            name = Name;
            phone = Phone;
        }

    }
}
