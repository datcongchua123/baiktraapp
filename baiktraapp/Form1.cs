using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baiktraapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            
            double sale = 0, tong = 0, phitheonam = 0, phi;
            phi = 500 * double.Parse(txtunit.Text);


            if (sale10.Checked == true)
            {
                sale = phi * 0.1;
            }
            else
            {
                if (sale50.Checked == true)
                {
                    sale = phi * 0.5;
                }
                else
                {
                    if (sale100.Checked == true)
                    {
                        sale = phi * 1;
                    }
                }
            }
            if (txtyear.Text == "2000")
            {
                phitheonam = 2000;
            }
            else if (txtyear.Text == "2001")
            {
                phitheonam = 2500;
            }
            else if (txtyear.Text == "2002")
            {
                phitheonam = 3000;
            }
            else if (txtyear.Text == "2003" && txtyear.Text == "2004")
            {
                phitheonam = 3500;
            }
            tong = phi + phitheonam - sale;



            MessageBox.Show("Student :" + txtID.Text + " ;Name " + txtname.Text + "\nKhóa học: " + txtcourse.Text
            + "\nTổng Môn:" + txtunit.Text
            + "\n Học phí: " + phitheonam
            + "\nGiảm giá" + sale
            + "\nTổng cộng" + tong);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtyear.Items.Add("2000");
            txtyear.Items.Add("2001");
            txtyear.Items.Add("2002");
            txtyear.Items.Add("2003");
            txtyear.Items.Add("2004");
        }
    }
}
