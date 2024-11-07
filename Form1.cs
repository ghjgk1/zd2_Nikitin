using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace zd2
{
    public partial class Form1 : Form
    {

        PhoneBook myPhoneBook = new PhoneBook();

        Contact contact = new Contact();

        bool bb = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            // Очищаем ListBox контактов
            phoneBookListBox.Items.Clear();

            if (bb == true)
            {
                // Загружаем контакты из файла
                PhoneBookLoader.Load(myPhoneBook, $"{filenameTextBox.Text}.csv");
            }


            // Выводим контакты
            foreach (var contact in myPhoneBook.phoneBooks)
            {
                phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
            }

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            //если не поле не пустое
            if (nameTextBox.Text != "")
            {
                //ищем контакт по имени
                contact = myPhoneBook.FindByName($"{nameTextBox.Text}");

                //если контакт есть
                if (contact != null)
                {
                    // Очищаем ListBox контактов
                    phoneBookListBox.Items.Clear();
                    // Выводим контакт
                    phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                }
                //сообщение об ошибке
                else MessageBox.Show("Контакт не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //сообщение об ошибке
            else MessageBox.Show("Поле не запонено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            //если не поле не пустое
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (myPhoneBook.correctLetter(textBox1.Text) && myPhoneBook.correctLetter(textBox2.Text) && myPhoneBook.correctPhone(textBox3.Text))
                {
                    //Добавляем контакт
                    myPhoneBook.addContact(textBox1.Text, textBox2.Text, textBox3.Text);

                    // Очищаем ListBox контактов
                    phoneBookListBox.Items.Clear();

                    // Выводим контакты
                    foreach (var contact in myPhoneBook.phoneBooks)
                    {
                        phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                    }
                    PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
                }
                //сообщение об ошибке
                else MessageBox.Show("Данные введены не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //сообщение об ошибке
            else MessageBox.Show("Поле не запонено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                //удаляем контакт по имени
                myPhoneBook.Remove(nameTextBox.Text);

                // Очищаем ListBox контактов
                phoneBookListBox.Items.Clear();
                // Выводим контакты
                foreach (var contact in myPhoneBook.phoneBooks)
                {
                    phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                }
                PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
            }
            //сообщение об ошибке
            else MessageBox.Show("Поле не запонено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = phoneBookListBox.SelectedIndex;
            // -1 означает, что ничего не выбрано
            if (selectedIndex != -1)
            {
                //если не поле не пустое
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    //если все введено правильно
                    if (myPhoneBook.correctLetter(textBox1.Text) && myPhoneBook.correctLetter(textBox2.Text) && myPhoneBook.correctPhone(textBox3.Text))
                    {

                        var selectedItem = phoneBookListBox.Items[selectedIndex];
                        string[] data = selectedItem.ToString().Split(' ');

                        //Редактируем контакт
                        myPhoneBook.Replace(new Contact($"{data[0]} {data[1]}", data[2]), textBox1.Text, textBox2.Text, textBox3.Text);

                        // Очищаем ListBox контактов
                        phoneBookListBox.Items.Clear();

                        // Выводим контакты
                        foreach (var contact in myPhoneBook.phoneBooks)
                        {
                            phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                        }

                        PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
                    }
                    //сообщение об ошибке
                    else MessageBox.Show("Данные введены не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //сообщение об ошибке
                else MessageBox.Show("Поле не запонено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Сначала выберите элемент списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void phoneBookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = phoneBookListBox.SelectedIndex;
            // -1 означает, что ничего не выбрано
            if (selectedIndex != -1)
            {
                var selectedItem = phoneBookListBox.Items[selectedIndex];
                string[] data = selectedItem.ToString().Split(' ');
                //заносим данные для редактирования
                textBox1.Text = data[0];
                textBox2.Text = data[1];
                textBox3.Text = data[2];
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //сохраняем данные в файл
            PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //закрываем программу
            this.Close();
        }
    }
}
