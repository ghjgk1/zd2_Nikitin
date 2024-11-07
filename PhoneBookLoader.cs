using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zd2
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook, string fileName)
        {       
            //если список контактов не пустой
            if (phoneBook.phoneBooks != null)
            {
                //если есть такой файл
                if (File.Exists(fileName))
                {
                    //открыфваем файл
                    StreamReader sr = File.OpenText(fileName);
                    while (true)
                    {
                        //читаем строку файла
                        string line = sr.ReadLine();

                        //пока файл не закачится
                        if (line == null) break;
                        {
                            //заносим в список контактов
                            string[] contactFromBook = line.Split(';');
                            Contact contact = new Contact(contactFromBook[0], contactFromBook[1]);
                            phoneBook.phoneBooks.Add(contact);

                        }
                    }
                    sr.Close();
                }
                //ошибка
                else MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    
        public static void Save(PhoneBook phoneBook, string fileName) 
        {
            //открыфваем файл
            StreamWriter sw = File.CreateText(fileName);
            foreach(var contact in phoneBook.phoneBooks)
            {
                //заносим в файл
                sw.WriteLine($"{contact.name};{contact.phone}");
            }
            sw.Close();
        }

    }
}
