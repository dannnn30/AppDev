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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace THA_W5_Daniel_O
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightPink;
            btn_addCategory.BackColor = Color.LightGreen;
            btn_removeCategory.BackColor = Color.Red;
            btn_addProduct.BackColor = Color.LightGreen;
            btn_editProduct.BackColor = Color.LightYellow;
            btn_removeProduct.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID\nProduct");
            dt.Columns.Add("Product\nName");
            dt.Columns.Add("Price");
            dt.Columns.Add("Stock");
            dt.Columns.Add("ID\nCategory");
            dataGridView_product.DataSource = dt;

            data.Columns.Add("ID\nProduct");
            data.Columns.Add("Product\nName");
            data.Columns.Add("Price");
            data.Columns.Add("Stock");
            data.Columns.Add("ID\nCategory");

            dt2.Columns.Add("ID\nCategory");
            dt2.Columns.Add("Category\nName");
            dataGridView_category.DataSource = dt2;

            dt.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dt.Rows.Add("T001", "T - Shirt Black Pink", 70000, 20, "C2");
            dt.Rows.Add("T002", "T - Shirt Obsessive", 75000, 16, "C2");
            dt.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dt.Rows.Add("J002", "Jeans Biru ", 90000, 5, "C4");
            dt.Rows.Add("C001", "Celana Pendek Coklat ", 60000, 11, "C4");
            dt.Rows.Add("C002", "Cawat Blink - blink", 1000000, 1, "C5");
            dt.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            dt2.Rows.Add("C1", "Jas");
            dt2.Rows.Add("C2", "T-Shirt");
            dt2.Rows.Add("C3", "Rok");
            dt2.Rows.Add("C4", "Celana");
            dt2.Rows.Add("C5", "Cawat");

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                combox_category.Items.Add(dt2.Rows[i][1].ToString());
                combox_product.Items.Add(dt2.Rows[i][1].ToString());    
            }
        }

        private void label_product_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kembar = false;
            if(tebox_namaCategory.Text=="")
            {
                MessageBox.Show("masukin nama category dulu brody!!", "yahhh error");
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (tebox_namaCategory.Text == dt2.Rows[i][1].ToString())
                {
                    kembar = true;
                }
            }
            if (!kembar)
            {
                int cek = dt2.Rows.Count;
                cek = Convert.ToInt32(dt2.Rows[cek - 1][0].ToString().Substring(1)) + 1;
                dt2.Rows.Add("C" + cek, tebox_namaCategory.Text);
                combox_category.Items.Add(tebox_namaCategory.Text);
                combox_product.Items.Add(tebox_namaCategory.Text);
            }
            else
            {
                MessageBox.Show("Category udah ada broww", "yahhh error pt.2");
            }
        }

        private void btn_removeCategory_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_category.SelectedRows)
            {
                dataGridView_category.Rows.Remove(row);
            }
            combox_category.Items.RemoveAt(dataGridView_category.CurrentRow.Index);
            combox_product.Items.RemoveAt(dataGridView_category.CurrentRow.Index);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            string id="";
            int cek = 1;

            if(tebox_namaProduct.Text==""||tebox_price.Text==""||tebox_stock.Text==""||combox_category.Text=="")
            {
                MessageBox.Show("error");
            }
            else
            {
                id = tebox_namaProduct.Text.ToString().Substring(0, 1).ToUpper();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].ToString().Substring(0,1).ToUpper()== id )
                    {
                        cek=cek+1;
                        MessageBox.Show(id + dt.Rows[i][1].ToString().Substring(0, 1).ToUpper());
                    }
                }
                if(cek<10)
                {
                    id = id + "0";
                }
                else if(cek<100)
                {
                    id = id + "0";
                }
                id = id + cek.ToString();

                string idcat="";
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if(combox_category.Text==dt2.Rows[i][1].ToString())
                    {
                        idcat = dt2.Rows[i][0].ToString();
                    }
                }
                dt.Rows.Add(id, tebox_namaProduct.Text, tebox_price.Text, tebox_stock.Text,idcat);
            }
        }

        private void tebox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void tebox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tebox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            combox_product.Enabled = true;
            dataGridView_product.DataSource = data;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            combox_product.Enabled=false;
            dataGridView_product.DataSource = dt;
        }

        private void combox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Clear();
            
            string cat = "";
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                if (combox_product.Text == dt2.Rows[j][1].ToString())
                {
                    cat = dt2.Rows[j][0].ToString();
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].ToString() == cat)
                {
                    data.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                }
            }
        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_product.SelectedRows)
            {
                dataGridView_product.Rows.Remove(row);
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
