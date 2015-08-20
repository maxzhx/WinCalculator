using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num;
        char opt = '=';
        double op1, op2;
        double result;
        bool result_flag = false;
        bool point_flag = false;
        bool negative_flag = false;
        bool m_flag = false;
        int point_counter = 0;
        double memo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter); point_counter--; }
                else
                {
                    num = num * 10 - 1;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter); point_counter--; }
                else
                {
                    num = num * 10 + 1;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 2; point_counter--; }
                else
                {
                    num = num * 10 - 2;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 2; point_counter--; }
                else
                {
                    num = num * 10 + 2;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 3; point_counter--; }
                else
                {
                    num = num * 10 - 3;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 3; point_counter--; }
                else
                {
                    num = num * 10 + 3;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 4; point_counter--; }
                else
                {
                    num = num * 10 - 4;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 4; point_counter--; }
                else
                {
                    num = num * 10 + 4;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 5; point_counter--; }
                else
                {
                    num = num * 10 - 5;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 5; point_counter--; }
                else
                {
                    num = num * 10 + 5;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 6; point_counter--; }
                else
                {
                    num = num * 10 - 6;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 6; point_counter--; }
                else
                {
                    num = num * 10 + 6;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 7; point_counter--; }
                else
                {
                    num = num * 10 - 7;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 7; point_counter--; }
                else
                {
                    num = num * 10 + 7;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 8; point_counter--; }
                else
                {
                    num = num * 10 - 8;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 8; point_counter--; }
                else
                {
                    num = num * 10 + 8;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (negative_flag)
            {
                if (point_flag) { num = num - Math.Pow(10, point_counter) * 9; point_counter--; }
                else
                {
                    num = num * 10 - 9;
                }
            }
            else
            {
                if (point_flag) { num = num + Math.Pow(10, point_counter) * 9; point_counter--; }
                else
                {
                    num = num * 10 + 9;
                }
            }
            textBox1.Text = num.ToString("G");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            if (result_flag) { num = 0; result_flag = false; }
            if (point_flag) 
            {
                textBox1.Text = textBox1.Text + '0';
                point_counter--; 
            }
            else
            {
                num = num * 10 + 0;
                textBox1.Text = num.ToString("G");
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            opt = '+';
            op1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            point_flag = false;
            negative_flag = false;
            m_flag = false; 
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            opt = '-';
            op1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            point_flag = false;
            negative_flag = false;
            m_flag = false; 
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            opt = '*';
            op1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            point_flag = false;
            negative_flag = false;
            m_flag = false; 
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            opt = '/';
            op1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            point_flag = false;
            negative_flag = false;
            m_flag = false; 
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            op2 = double.Parse(textBox1.Text);
            switch (opt)
            {
                case '=': break;
                case '+': result = op1 + op2; break;
                case '-':
                    if (m_flag) { result = op2 - op1; break; }
                    else { result = op1 - op2; op1 = op2; m_flag = true; break; }
                case '*': result = op1 * op2; break;
                case '/':
                    if (m_flag) { result = op2 / op1; break; }
                    else { result = op1 / op2; op1 = op2; m_flag = true; break; }
            }
            point_flag = false;
            negative_flag = false;
            result_flag = true;
            textBox1.Text = result.ToString("G");
            num = double.Parse(textBox1.Text);
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            //int temp_int;
            if (result_flag) { }
            else
            {
                if (negative_flag) 
                {
                    if (point_flag)
                    {
                        if (textBox1.Text[textBox1.Text.Length - 1] == '.') 
                        {
                            if (textBox1.Text.Length == 3 && textBox1.Text[1] == '0') 
                            { textBox1.Text = textBox1.Text.Substring(1); negative_flag = false; }
                            point_flag = false; 
                        }
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        num = double.Parse(textBox1.Text);
                        point_counter++;
                    }
                    else
                    {
                        /*temp_int = (int)num / 10;
                        num = (double)temp_int;
                        textBox1.Text = num.ToString("G");*/
                        if (textBox1.Text.Length == 2) { textBox1.Text = "0"; negative_flag = false; }
                        else
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        num = double.Parse(textBox1.Text);
                    }
                }
                else
                {
                    if (point_flag)
                    {
                        if (textBox1.Text[textBox1.Text.Length - 1] == '.') { point_flag = false; }
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        num = double.Parse(textBox1.Text);
                        point_counter++;
                    }
                    else
                    {
                        /*temp_int = (int)num / 10;
                        num = (double)temp_int;
                        textBox1.Text = num.ToString("G");*/
                        if (textBox1.Text.Length == 1) { textBox1.Text = "0"; }
                        else
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        num = double.Parse(textBox1.Text);
                    }
                }
            }
        }

        private void botton_CE_Click(object sender, EventArgs e)
        {
            num = 0;
            point_flag = false;
            negative_flag = false;
            textBox1.Text = num.ToString("G");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            num = 0;
            op1 = 0;
            op2 = 0;
            opt = '=';
            point_flag = false;
            negative_flag = false;
            m_flag = false;
            result_flag = false;
            textBox1.Text = num.ToString("G");
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            string temp_s;
            if (negative_flag)
            { 
                negative_flag = false;
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else 
            { 
                negative_flag = true;
                temp_s = '-' + textBox1.Text;
                textBox1.Text = temp_s;
            }
            //num = 0 - num;
            
            //textBox1.Text = num.ToString("G");
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (point_flag) { }
            else
            {
                textBox1.Text = textBox1.Text + '.';
                point_flag = true;
                point_counter = -1;
            }
        }

        private void button_radical_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            num = Math.Pow(num, 0.5);
            textBox1.Text = num.ToString("G");
            point_flag = false;
            negative_flag = false;
            result_flag = true;
        }

        private void button_percentage_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            num = num / 100;
            textBox1.Text = num.ToString("G");
            point_flag = false;
            negative_flag = false;
            result_flag = true;
        }

        private void button_inverse_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            num = 1 / num;
            textBox1.Text = num.ToString("G");
            point_flag = false;
            negative_flag = false;
            result_flag = true;
        }

        private void 科学型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("科学型计算器正在开发中,更多精彩功能,敬请期待!");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发者:郑慧翔\n学号:24320102202668\n此计算器为学习交流使用,请自觉于下载24小时内删除,违者自行承担法律责任!");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) 
            {
                case '1': button1_Click(sender, e); break;
                case '2': button2_Click(sender, e); break;
                case '3': button3_Click(sender, e); break;
                case '4': button4_Click(sender, e); break;
                case '5': button5_Click(sender, e); break;
                case '6': button6_Click(sender, e); break;
                case '7': button7_Click(sender, e); break;
                case '8': button8_Click(sender, e); break;
                case '9': button9_Click(sender, e); break;
                case '0': button0_Click(sender, e); break;
                case '+': button_plus_Click(sender, e); break;
                case '-': button_minus_Click(sender, e); break;
                case '*': button_multiply_Click(sender, e); break;
                case '/': button_division_Click(sender, e); break;
                case '.': button_point_Click(sender, e); break;
                case '=': button_equal_Click(sender, e); break;
                case (char)Keys.Escape: button_clear_Click(sender, e); break;
                case (char)Keys.Back: button_backspace_Click(sender, e); break;
                case (char)Keys.Enter: button_equal_Click(sender, e); break;
            }
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            memo = 0;
            if (memo == 0) { button_MR.Text = " "; }
            else { button_MR.Text = "M"; }
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            memo = double.Parse(textBox1.Text);
            if (memo == 0) { button_MR.Text = " "; }
            else { button_MR.Text = "M"; }
        }

        private void button_Mplus_Click(object sender, EventArgs e)
        {
            memo = memo + double.Parse(textBox1.Text);
            if (memo == 0) { button_MR.Text = " "; }
            else { button_MR.Text = "M"; }
        }

        private void button_Mminus_Click(object sender, EventArgs e)
        {
            memo = memo - double.Parse(textBox1.Text);
            if (memo == 0) { button_MR.Text = " "; }
            else { button_MR.Text = "M"; }
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            if (memo == 0) { }
            else
            {
                num = memo;
                point_flag = false;
                negative_flag = false;
                result_flag = true;
                textBox1.Text = num.ToString("G");
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Clipboard.SetDataObject(textBox1.Text);
        }

    }
}
