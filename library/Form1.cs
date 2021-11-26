using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTestList_Click(object sender, EventArgs e)
        {
            List<string> book = new List<string>();
            BookManager bm = new BookManager();
            book = bm.bookInfoList();

            for (int i = 0; i < book.Count(); i++)
            {
                lv1.Items.Add(book[i]);
            }
        }
    }
}
