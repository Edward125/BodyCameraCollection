using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BodyCameraCollection
{
    public partial class frmCheckPwd : Form
    {
        public frmCheckPwd()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "0";
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtPwd.Text + "*";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Length > 0)
                txtPwd.Text = txtPwd.Text.Substring(0, txtPwd.Text.Length - 1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Trim() == "2018")
            {
                p.CheckPwd = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.SelectAll();
                txtPwd.Focus();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            p.CheckPwd = false;
            this.Close();
        }
    }
}
