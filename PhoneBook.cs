using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class PhoneBook
    {
        public List<Contact> phoneBooks = new List<Contact>();

        //поиск контакта по имени
        public Contact FindByName(string name)
        {
            //проходим по всем контактам
            foreach (var contact in phoneBooks)
            {
                //если совпадает возвращаем найденное
                if (contact.name == name)
                {
                    return contact;
                }
            }
            //продукт не найден, возвращаем null
            return null;
        }

        public void addContact(string name, string sname, string phone )
        {
            int correct = 0;
            foreach(var contact in phoneBooks)
            {
                if (contact.phone == phone) correct++;
            }
            //если есть такой элемент
            if (correct == 0) phoneBooks.Add(new Contact($"{name} {sname}", phone));
            else
            {
                //сообщение об ошибке
                MessageBox.Show("Такой номер уже есть в книге контактов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool correctLetter(string letter)
        {
            char[] chars = letter.ToCharArray();
            if (char.IsLower(chars[0])) return false;
            foreach (char c in letter)
            {
                //если если не буквы
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public bool correctPhone(string phone)
        {
            //если номер равен 14 символов
            if (phone.Length == 14)
            {
                char[] ch = phone.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    //если первый элемент (
                    if (i == 0)
                    if (ch[0] != '(') return false;
                        else;
                    //если четвертый элемент )
                    else if (i == 4)
                        if (ch[4] != ')') return false;
                        else;
                    //если восьмой и одиннадцатый элемент -
                    else if (i == 8 || i == 11)
                        if (ch[8] != '-' || ch[11] != '-') ;
                        else;
                    //если остальные символы числа
                    else
                        if (!char.IsDigit(ch[i])) return false;
                }
            }
            else return false;
            return true;
        }

        //метод для удаления контакт по названию
        public void Remove(string name)
        {
            int indexContact = -1;
            //находим на каком месте данный контакт
            for (int i = 0; i < phoneBooks.Count; i++) 
            {
                if (phoneBooks[i].name == name)
                {
                    indexContact = i;
                    break;
                }
            }
            //если телефонная книга содержит такой контакт
            if (indexContact != -1)
                //удаляем контакт
                phoneBooks.Remove(phoneBooks[indexContact]);
            else
                //сообщение что такого контакта нет
                MessageBox.Show("Такого контакта нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //метод для редактирования контакта
        public void Replace(Contact contact, string name, string sname, string phone)
        {
            int correct = 0;
            int indexContact = -1;
            //находим на каком месте данный контакт
            for (int i = 0; i < phoneBooks.Count; i++)
            {
                if (phoneBooks[i].name == contact.name && phoneBooks[i].phone == contact.phone)
                {
                    indexContact = i;
                }
                if (phoneBooks[i].phone == phone && i != indexContact) correct++;
            }
            //если телефонная книга содержит такой контакт
            if (indexContact != -1) 
            {
                if(correct == 0)
                {
                    //редактируем контакт
                    phoneBooks[indexContact] = new Contact($"{name} {sname}", phone);
                }
                else
                    //сообщение что такого контакта нет
                    MessageBox.Show("Есть контакт с таким номером!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                //сообщение что такого контакта нет
                MessageBox.Show("Такого контакта нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
