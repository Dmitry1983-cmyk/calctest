﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double x;
        double y;
        int tmp;
        public Form1()
        {
            InitializeComponent();
            arrButton();
        }

        public void arrButton()
        {
            Button[,] btn = new Button[3, 3];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Location = new Point((i * 60)+10, (j * 40)+60);
                    btn[i, j].Size = new Size(60, 40);
                    btn[i, j].Text = tmp.ToString();
                    btn[i, j].Click += btnClick;
                    this.Controls.Add(btn[i, j]);
                    tmp += 1;
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            var btn= sender as Button;
            txtInput.Text += btn.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblNum.Text = "";
            x = 0;
            tmp = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calc();
            lblNum.Text = "";
        }

        private void btnTripleZero_Click(object sender, EventArgs e)
        {
            txtInput.Text += btnTripleZero.Text;
        }

        private void btnDblZero_Click(object sender, EventArgs e)
        {
            txtInput.Text += btnDblZero.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtInput.Text += btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtInput.Text += btnPoint.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(txtInput.Text!="")
            {
                x = Convert.ToDouble(txtInput.Text);
                tmp = 1;
                lblNum.Text = x.ToString() + " + ";
                txtInput.Clear();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                x = Convert.ToDouble(txtInput.Text);
                tmp = 2;
                lblNum.Text = x.ToString() + " - ";
                txtInput.Clear();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                x = Convert.ToDouble(txtInput.Text);
                tmp = 3;
                lblNum.Text = x.ToString() + " x ";
                txtInput.Clear();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                x = Convert.ToDouble(txtInput.Text);
                tmp = 4;
                lblNum.Text = x.ToString() + " / ";
                txtInput.Clear();
            }
        }

        private void Calc()
        {
            switch (tmp)
            {
                case 1:
                    y = x + float.Parse(txtInput.Text);
                    txtInput.Text = y.ToString();
                    break;
                case 2:
                    y = x - float.Parse(txtInput.Text);
                    txtInput.Text = y.ToString();
                    break;
                case 3:
                    y = x * float.Parse(txtInput.Text);
                    txtInput.Text = y.ToString();
                    break;
                case 4:
                    y = x / float.Parse(txtInput.Text);
                    txtInput.Text = y.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
