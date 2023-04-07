using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekman_Pashto_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");

        }

        private void button49_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }

        private void btnW_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
           
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnY_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnU_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btni_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnO_Click(object sender, EventArgs e)
        {
           
        }

        private void btnP_Click(object sender, EventArgs e)
        {
           
        }

        private void btnA(object sender, EventArgs e)
        {

           
        }

        private void btnS(object sender, EventArgs e)
        {
           
        }

        private void btnD(object sender, EventArgs e)
        {
           
        }

        private void btnF(object sender, EventArgs e)
        {
           
        }

        private void Alphabets(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("!");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۱");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("@");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۲");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("#");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۳");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("$");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۴");

            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{%}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۵");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{^}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۶");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{&}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۷");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("*");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۸");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{(}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۹");
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{)}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۰");
            }
           
        }

        private void btnQ_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ښ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
                
            }
            else
            {
                SendKeys.Send("ق");

            }
            
        }

        private void btnW_Click_1(object sender, EventArgs e)
        {

            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ؤ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("و");

            }
        }

        private void btnE_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ږ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ع");

            }
        }

        private void btnR_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ړ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ر");

            }
        }

        private void btnT_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ټ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ت");

            }
        }

        private void btnY_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ی");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ے");

            }
        }

        private void btnU_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ۍ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ئ");

            }
        }

        private void btni_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ې");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
                 
            }
            else
            {
                SendKeys.Send("ي");

            }
        }

        private void btnO_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ۀ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ہ");

            }
        }

        private void btnP_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("څ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("پ");

            }
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("آ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ا");

            }
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ص");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("س");

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ډ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("د");

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ٖ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ف");

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("غ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ګ");

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ځ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ح");

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ض");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ج");

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("خ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ک");

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ؒ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ل");

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ذ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ز");

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ژ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ش");

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ث");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("چ");

            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ظ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ط");

            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ب");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ب");

            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("ڼ");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("ن");

            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("م");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("م");

            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void chkShiftLeft_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkShiftRight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCapsLock_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{CAPSLOCK}");
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{+}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{_}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("[");

            }
        }

        private void btnBracket2_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("]");

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(":");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("؛");

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("'");

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(">");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("،");

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("<");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("۔");

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("؟");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("/");

            }
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            
        }

        private void ShiftR_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("~");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;

            }
            else
            {
                SendKeys.Send("`");

            }
        }

        private void btnQQ_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            
        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAltRight_Click(object sender, EventArgs e)
        {
            
        }
    }
}
