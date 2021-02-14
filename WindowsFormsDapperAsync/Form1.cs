using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib;


namespace WindowsFormsDapperAsync
{
  
    public partial class Form1 : Form
    {
        MyClass myClass;
        public Form1()
        {
            InitializeComponent();

        }

      async  private void buttonAsync_Click(object sender, EventArgs e)
        {
            myClass = new MyClass();
            dataGridView1.DataSource = await myClass.LoadAsync();
        }

    
    }
}
