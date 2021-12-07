using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_tovary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.dataBase.Postavshik);

        }

        private void postavshikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavshikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.EndEdit();
            postavshikTableAdapter.Update(dataBase);
        }
    }
}
