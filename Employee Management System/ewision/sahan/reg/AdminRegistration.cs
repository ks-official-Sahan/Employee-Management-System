using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Employee_Management_System
{
    public partial class admin_reg : Form
    {
        private IMongoCollection<BsonDocument> userCollection;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public admin_reg()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            InitializeMongoDB();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("your-mongodb-connection-string");
            var database = client.GetDatabase("your-database-name");
            userCollection = database.GetCollection<BsonDocument>("users");
        }

        private void admin_reg_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var user = new BsonDocument
            {
                { "title", Title.SelectedItem != null ? Title.SelectedItem.ToString() : "Mr." },
                { "firstName", first.Text },
                { "lastName", last.Text },
                { "position", position.SelectedItem!= null ? position.SelectedItem.ToString() : "Mr." },
                { "name", name.Text },
                { "phone", phone.Text },
                { "email", email.Text },
                { "password", password.Text },
            };

            userCollection.InsertOne(user);
            MessageBox.Show("User registered successfully!");
        }
    }
}
