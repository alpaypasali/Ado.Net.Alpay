using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultantTableAdapter.Update(alpay_ADONETDataSet.Consultant);
            birthdayTableAdapter.Update(alpay_ADONETDataSet.Birthday);
            studentTableAdapter.Update(alpay_ADONETDataSet.Student);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Birthday' table. You can move, or remove it, as needed.
            this.birthdayTableAdapter.Fill(this.alpay_ADONETDataSet.Birthday);
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Consultant' table. You can move, or remove it, as needed.
            this.consultantTableAdapter.Fill(this.alpay_ADONETDataSet.Consultant);
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.alpay_ADONETDataSet.Student);
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.alpay_ADONETDataSet.Student);
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Consultant' table. You can move, or remove it, as needed.
            this.consultantTableAdapter.Fill(this.alpay_ADONETDataSet.Consultant);
            // TODO: This line of code loads data into the 'alpay_ADONETDataSet.Birthday' table. You can move, or remove it, as needed.
            this.birthdayTableAdapter.Fill(this.alpay_ADONETDataSet.Birthday);

        }
    }
}
