using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {

        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameTextBox.Text);

            UpdateBinding();

        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(FirstNameInsertTextBox.Text, LastNameInsertTextBox.Text, EmailAddressInsertTextBox.Text, PhoneNumberInsertTextBox.Text);

            FirstNameInsertTextBox.Text = "";
            LastNameInsertTextBox.Text = "";
            EmailAddressInsertTextBox.Text = "";
            PhoneNumberInsertTextBox.Text = "";

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           Person selectedPerson = (Person)PeopleFoundListBox.SelectedItem;
            // FirstNameInsertTextBox.Text = selectedPerson.FirstName;
            // LastNameInsertTextBox.Text = Convert.ToString(selectedPerson.id);
            // EmailAddressInsertTextBox.Text = selectedPerson.EmailAddress;
            // PhoneNumberInsertTextBox.Text = selectedPerson.PhoneNumber;

            DataAccess db = new DataAccess();

           db.DeletePerson(selectedPerson.id, selectedPerson.FirstName, selectedPerson.LastName, selectedPerson.EmailAddress, selectedPerson.PhoneNumber);
        }
    }
}
