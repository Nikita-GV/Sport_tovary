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
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Zakypka". При необходимости она может быть перемещена или удалена.
            this.zakypkaTableAdapter.Fill(this.dataBase.Zakypka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.dataBase.Storage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Sport_tovary". При необходимости она может быть перемещена или удалена.
            this.sport_tovaryTableAdapter.Fill(this.dataBase.Sport_tovary);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.dataBase.Proizvoditel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase.Prodaga". При необходимости она может быть перемещена или удалена.
            this.prodagaTableAdapter.Fill(this.dataBase.Prodaga);
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

        private void button5_Click(object sender, EventArgs e)
        {
            prodagaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prodagaBindingSource.EndEdit();
            prodagaTableAdapter.Update(dataBase);
        }

        private void postavshikBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void prodagaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void proizvoditelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.EndEdit();
            proizvoditelTableAdapter.Update(dataBase);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sport_tovaryBindingSource.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sport_tovaryBindingSource.EndEdit();
            sport_tovaryTableAdapter.Update(dataBase);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.EndEdit();
            postavshikTableAdapter.Update(dataBase);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            sport_tovaryBindingSource.AddNew();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            sport_tovaryBindingSource.EndEdit();
            sport_tovaryTableAdapter.Update(dataBase);
        }

        private void button11_Click(object sender, EventArgs e)
        {
           storageBindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            storageBindingSource.EndEdit();
            storageTableAdapter.Update(dataBase);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            zakypkaBindingSource.AddNew();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            zakypkaBindingSource.EndEdit();
            zakypkaTableAdapter.Update(dataBase);
        }

    }
}
