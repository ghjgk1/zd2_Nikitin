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

            // ������� ListBox ���������
            phoneBookListBox.Items.Clear();

            if (bb == true)
            {
                // ��������� �������� �� �����
                PhoneBookLoader.Load(myPhoneBook, $"{filenameTextBox.Text}.csv");
            }


            // ������� ��������
            foreach (var contact in myPhoneBook.phoneBooks)
            {
                phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
            }

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            //���� �� ���� �� ������
            if (nameTextBox.Text != "")
            {
                //���� ������� �� �����
                contact = myPhoneBook.FindByName($"{nameTextBox.Text}");

                //���� ������� ����
                if (contact != null)
                {
                    // ������� ListBox ���������
                    phoneBookListBox.Items.Clear();
                    // ������� �������
                    phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                }
                //��������� �� ������
                else MessageBox.Show("������� �� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //��������� �� ������
            else MessageBox.Show("���� �� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            //���� �� ���� �� ������
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (myPhoneBook.correctLetter(textBox1.Text) && myPhoneBook.correctLetter(textBox2.Text) && myPhoneBook.correctPhone(textBox3.Text))
                {
                    //��������� �������
                    myPhoneBook.addContact(textBox1.Text, textBox2.Text, textBox3.Text);

                    // ������� ListBox ���������
                    phoneBookListBox.Items.Clear();

                    // ������� ��������
                    foreach (var contact in myPhoneBook.phoneBooks)
                    {
                        phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                    }
                    PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
                }
                //��������� �� ������
                else MessageBox.Show("������ ������� �� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //��������� �� ������
            else MessageBox.Show("���� �� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                //������� ������� �� �����
                myPhoneBook.Remove(nameTextBox.Text);

                // ������� ListBox ���������
                phoneBookListBox.Items.Clear();
                // ������� ��������
                foreach (var contact in myPhoneBook.phoneBooks)
                {
                    phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                }
                PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
            }
            //��������� �� ������
            else MessageBox.Show("���� �� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = phoneBookListBox.SelectedIndex;
            // -1 ��������, ��� ������ �� �������
            if (selectedIndex != -1)
            {
                //���� �� ���� �� ������
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    //���� ��� ������� ���������
                    if (myPhoneBook.correctLetter(textBox1.Text) && myPhoneBook.correctLetter(textBox2.Text) && myPhoneBook.correctPhone(textBox3.Text))
                    {

                        var selectedItem = phoneBookListBox.Items[selectedIndex];
                        string[] data = selectedItem.ToString().Split(' ');

                        //����������� �������
                        myPhoneBook.Replace(new Contact($"{data[0]} {data[1]}", data[2]), textBox1.Text, textBox2.Text, textBox3.Text);

                        // ������� ListBox ���������
                        phoneBookListBox.Items.Clear();

                        // ������� ��������
                        foreach (var contact in myPhoneBook.phoneBooks)
                        {
                            phoneBookListBox.Items.Add($"{contact.name} {contact.phone}");
                        }

                        PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
                    }
                    //��������� �� ������
                    else MessageBox.Show("������ ������� �� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //��������� �� ������
                else MessageBox.Show("���� �� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("������� �������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void phoneBookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = phoneBookListBox.SelectedIndex;
            // -1 ��������, ��� ������ �� �������
            if (selectedIndex != -1)
            {
                var selectedItem = phoneBookListBox.Items[selectedIndex];
                string[] data = selectedItem.ToString().Split(' ');
                //������� ������ ��� ��������������
                textBox1.Text = data[0];
                textBox2.Text = data[1];
                textBox3.Text = data[2];
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //��������� ������ � ����
            PhoneBookLoader.Save(myPhoneBook, $"{filenameTextBox.Text}.csv");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //��������� ���������
            this.Close();
        }
    }
}
