using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonHoc
{
    
    public partial class Form1 : Form
    {
        List<Diem> diems = new List<Diem>();
        public Form1()
        {
            InitializeComponent();
            additem();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void additem()
        {
            comboBox1.Items.Add("Tin học đại cương");
            comboBox1.Items.Add("Giải tích F1");
            comboBox1.Items.Add("Tiếng Anh A0");
            comboBox1.Items.Add("Triết học Mác – Lênin");
            comboBox1.Items.Add("Vật lý F1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tin học đại cương")
            {
                textBox1.Text = "2";
            }
            if (comboBox1.Text == "Giải tích F1")
            {
                textBox1.Text = "3";
            }
            if (comboBox1.Text == "Tiếng Anh A0")
            {
                textBox1.Text = "3";
            }
            if (comboBox1.Text == "Triết học Mác – Lênin")
            {
                textBox1.Text = "2";
            }
            if (comboBox1.Text == "Vật lý F1")
            {
                textBox1.Text = "3";
            }
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.G)
            {
                addDS();
            }
        }
        private void addDS()
        {
           
            if (Convert.ToInt32(textBox2.Text) > 10)
            {
                MessageBox.Show("Điểm không hợp lệ!");
                textBox2.Focus();
            }
            if(textBox2.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập điểm!");
                textBox2.Focus();
            }
            listBox1.Items.Add(comboBox1.Text + " | " + textBox1.Text + " | " + textBox2.Text
                  );
           
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            addDS();
            diems.Add(new Diem(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)));
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                addDS();
            }
            if (e.Alt == true && e.KeyCode == Keys.T)
            {
                tinhdiem();
            }
            if (e.Alt == true && e.KeyCode == Keys.H)
                {
                    exit();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinhdiem();
        }
        private void tinhdiem()
        {
            textBox3.Text = "";
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập danh sách môn học!");
            }
            
            double tongdiem = 0;
            double tongtc = 0;

            foreach(Diem diem in diems)
            {
                tongdiem += diem.DiemMh* diem.Stc;
                tongtc += diem.Stc;
            }
            textBox4.Text = tongdiem.ToString();
            textBox3.Text = tongtc.ToString();
            textBox5.Text = (tongdiem/tongtc).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exit();
        }
        private void exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

    }
}
