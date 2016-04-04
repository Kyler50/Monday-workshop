using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCombo();
        }

        public void setCombo()
        {
            Box1.Items.Add(Type.Home.ToString());
            Box1.Items.Add(Type.Mobile.ToString());
            Box1.Items.Add(Type.Workplace.ToString());
        }

        private void save_button(object sender, EventArgs e)
        {
            Directory.persons.Add(new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Box1.Text));
        }

        private void list_button(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Directory.persons.Count; i++)
            {
                listBox1.Items.Add(Directory.persons[i].ToString());
            }
        }
    }
}
