namespace Anket2
{
    public partial class Form1 : Form
    {
        public List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Person person = new Person(tname.Text, tsurname.Text, temail.Text, tphone.Text, dateTimePicker1.Value);
            persons.Add(person);
            Persons.DataSource = null;
            Persons.DataSource = persons;
            tname.Clear();
            tsurname.Clear();
            temail.Clear();
            tphone.Clear();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            persons = Save_File.deserialize(file_name.Text);
            if (persons == null)
            {
                MessageBox.Show("File is not exist");
                file_name.Clear();
            }
            else if (persons.Count == 0)
            {
                MessageBox.Show("File is empty");
            }
            
            Persons.DataSource = null;
            Persons.DataSource = persons;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Save_File.save_to_json(file_name.Text, persons);
            Persons.DataSource = null;
            file_name.Clear();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Person person_selected = Persons.SelectedItem as Person;
            foreach (var item in persons)
            {
                if (item.Name == Persons.SelectedItem.ToString())
                {

                    tname.Text = item.Name;
                    tsurname.Text = item.Surname;
                    temail.Text = item.Email;
                    tphone.Text = item.Phone;
                    dateTimePicker1.Value = item.Date;

                }
            }
            persons.Remove(person_selected);
        }
    }
}