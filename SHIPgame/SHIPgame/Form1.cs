using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIPgame
{
    public partial class Form1 : Form
    {

        public class Global
        {
            public static int player = 0;
            //玩家P1=0,P2=1


            public static int but01 = 0;
            //重骰次數計算用
            public static int d01 = 0;
            public static int d02 = 0;
            public static int d03 = 0;
            public static int d04 = 0;
            public static int d05 = 0;
            //骰子圖片用
            public static int score = 0;
            //計分用
            public static int allscorep1 = 0;
            public static int allscorep2 = 0;
            //總分
            public static int bounsscorep1 = 0;
            public static int bounsscorep2 = 0;
            public static int bounsscore = 0;
            //BOUNS計分用
            public static int endtimesp1 = 0;
            public static int endtimesp2 = 0;
            //結束遊戲計數器

        }





        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "目前狀態:P1";
            Global.player = 0;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            if(Global.but01<3)
            {
                Global.but01 += 1;
            }
            if (Global.but01 == 3)
            {
                Global.but01 = 0;
                button1.Enabled = false;
            }
            //重骰次數計算
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;





            Random R = new Random();

            int x01 = R.Next(0, 6);
            int x02 = R.Next(0, 6);
            int x03 = R.Next(0, 6);
            int x04 = R.Next(0, 6);
            int x05 = R.Next(0, 6);

            if (checkBox1.Checked==false)
            { 
            listView1.Items[0].ImageIndex = x01;

            }

            if (checkBox2.Checked == false)
            {
                listView2.Items[0].ImageIndex = x02;
            }

            if (checkBox3.Checked == false)
            {
                listView3.Items[0].ImageIndex = x03;
            }

            if (checkBox4.Checked == false)
            {
                listView4.Items[0].ImageIndex = x04;
            }

            if (checkBox5.Checked == false)
            {
                listView5.Items[0].ImageIndex = x05;
            }

            Global.d01 = listView1.Items[0].ImageIndex + 1;
            Global.d02 = listView2.Items[0].ImageIndex + 1;
            Global.d03=  listView3.Items[0].ImageIndex + 1;
            Global.d04 = listView4.Items[0].ImageIndex + 1;
            Global.d05 = listView5.Items[0].ImageIndex + 1;
            //骰子圖片變化
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.but01 = 0;
            listBox1.Enabled = false;

            if(listBox1.SelectedIndex==0)
            {
                int n0 = 0;
                if(int.TryParse(label19.Text,out n0)&& Global.player==0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m0 = 0;
                if (int.TryParse(label21.Text, out m0) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if (Global.d01 == 1)
                {
                 Global.score += 1;
                }
                if (Global.d02 == 1)
                {
                    Global.score += 1;
                }
                if (Global.d03 == 1)
                {
                    Global.score += 1;
                }
                if (Global.d04 == 1)
                {
                    Global.score += 1;
                }
                if (Global.d05 == 1)
                {
                    Global.score += 1;
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label19.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                if (Global.player == 1)
                {
                    label21.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }

            }
            //ones分數計算及顯示

            if (listBox1.SelectedIndex == 1)
            {
                int n1 = 0;
                if (int.TryParse(label20.Text, out n1) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m1 = 0;
                if (int.TryParse(label22.Text, out m1) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if (Global.d01 == 2)
                {
                    Global.score += 2;
                }
                if (Global.d02 == 2)
                {
                    Global.score += 2;
                }
                if (Global.d03 == 2)
                {
                    Global.score += 2;
                }
                if (Global.d04 == 2)
                {
                    Global.score += 2;
                }
                if (Global.d05 == 2)
                {
                    Global.score += 2;
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label20.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                if (Global.player == 1)
                {
                    label22.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }
            }
                //twos分數計算及顯示

                if (listBox1.SelectedIndex == 2)
                {
                    int n2 = 0;
                    if (int.TryParse(label23.Text, out n2) && Global.player == 0)
                    {
                        MessageBox.Show("已登記過，請選擇其他計分規則");
                        return;
                    }
                    int m2 = 0;
                    if (int.TryParse(label24.Text, out m2) && Global.player == 1)
                    {
                        MessageBox.Show("已登記過，請選擇其他計分規則");
                        return;
                    }

                    if (Global.d01 == 3)
                    {
                        Global.score += 3;
                    }
                    if (Global.d02 == 3)
                    {
                        Global.score += 3;
                    }
                    if (Global.d03 == 3)
                    {
                        Global.score += 3;
                    }
                    if (Global.d04 == 3)
                    {
                        Global.score += 3;
                    }
                    if (Global.d05 == 3)
                    {
                        Global.score += 3;
                    }

                    button2.Enabled = true;

                    if (Global.player == 0)
                    {
                        label23.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                    if (Global.player == 1)
                    {
                        label24.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }
                }
                //threes分數計算及顯示

                if (listBox1.SelectedIndex == 3)
                {
                    int n3 = 0;
                    if (int.TryParse(label25.Text, out n3) && Global.player == 0)
                    {
                        MessageBox.Show("已登記過，請選擇其他計分規則");
                        return;
                    }
                    int m3 = 0;
                    if (int.TryParse(label26.Text, out m3) && Global.player == 1)
                    {
                        MessageBox.Show("已登記過，請選擇其他計分規則");
                        return;
                    }

                    if (Global.d01 == 4)
                    {
                        Global.score += 4;
                    }
                    if (Global.d02 == 4)
                    {
                        Global.score += 4;
                    }
                    if (Global.d03 == 4)
                    {
                        Global.score += 4;
                    }
                    if (Global.d04 == 4)
                    {
                        Global.score += 4;
                    }
                    if (Global.d05 == 4)
                    {
                        Global.score += 4;
                    }

                    button2.Enabled = true;

                    if (Global.player == 0)
                    {
                        label25.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                    if (Global.player == 1)
                    {
                        label26.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }
                }
            //fours分數計算及顯示

            if (listBox1.SelectedIndex == 4)
            {
                int n4 = 0;
                if (int.TryParse(label27.Text, out n4) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m4 = 0;
                if (int.TryParse(label28.Text, out m4) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if (Global.d01 == 5)
                {
                    Global.score += 5;
                }
                if (Global.d02 == 5)
                {
                    Global.score += 5;
                }
                if (Global.d03 == 5)
                {
                    Global.score += 5;
                }
                if (Global.d04 == 5)
                {
                    Global.score += 5;
                }
                if (Global.d05 == 5)
                {
                    Global.score += 5;
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label27.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                if (Global.player == 1)
                {
                    label28.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }
            }
            //fives分數計算及顯示

            if (listBox1.SelectedIndex == 5)
            {
                int n5 = 0;
                if (int.TryParse(label29.Text, out n5) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m5 = 0;
                if (int.TryParse(label30.Text, out m5) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if (Global.d01 == 6)
                {
                    Global.score += 6;
                }
                if (Global.d02 == 6)
                {
                    Global.score += 6;
                }
                if (Global.d03 == 6)
                {
                    Global.score += 6;
                }
                if (Global.d04 == 6)
                {
                    Global.score += 6;
                }
                if (Global.d05 == 6)
                {
                    Global.score += 6;
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label29.Text = Global.score.ToString();
                    Global.bounsscorep1 += Global.score;
                }
                if (Global.player == 1)
                {
                    label30.Text = Global.score.ToString();
                    Global.bounsscorep2 += Global.score;
                }
            }
            //six分數計算及顯示



            if (listBox1.SelectedIndex == 7)
            {
                int n7 = 0;
                if (int.TryParse(label33.Text, out n7) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m7 = 0;
                if (int.TryParse(label34.Text, out m7) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                for(int i=1;i<=6;i++)
                {
                    if (Global.d01==i && Global.d02==i && Global.d03==i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d01 == i && Global.d02 == i && Global.d04 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d01 == i && Global.d02 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d01 == i && Global.d03 == i && Global.d04 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d01 == i && Global.d03 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d01 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d02 == i && Global.d03 == i && Global.d04 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d02 == i && Global.d03 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d02 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }
                    if (Global.d03 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 3;
                    }

                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label33.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label34.Text = Global.score.ToString();
                }

            }
            //三條分數計算及顯示

            if (listBox1.SelectedIndex == 8)
            {
                int n8 = 0;
                if (int.TryParse(label35.Text, out n8) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m8 = 0;
                if (int.TryParse(label36.Text, out m8) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                for (int i = 1; i <= 6; i++)
                {
                    if (Global.d01 == i && Global.d02 == i && Global.d03 == i && Global.d04==i)
                    {
                        Global.score = i * 4;
                    }
                    if (Global.d01 == i && Global.d02 == i && Global.d03 == i && Global.d05 == i)
                    {
                        Global.score = i * 4;
                    }
                    if (Global.d01 == i && Global.d02 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 4;
                    }
                    if (Global.d01 == i && Global.d03 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 4;
                    }
                    if (Global.d02 == i && Global.d03 == i && Global.d04 == i && Global.d05 == i)
                    {
                        Global.score = i * 4;
                    }

                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label35.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label36.Text = Global.score.ToString();
                }

            }
            //四條分數計算及顯示

            if (listBox1.SelectedIndex == 9)
            {
                int n9 = 0;
                if (int.TryParse(label37.Text, out n9) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m9 = 0;
                if (int.TryParse(label38.Text, out m9) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if(Global.d01==1 && Global.d02 == 2 && Global.d03 == 3 && Global.d04 == 4 && Global.d05 == 5 )
                {
                    Global.score = 30;
                }
               

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label37.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label38.Text = Global.score.ToString();
                }
            }
            //小順分數計算及顯示

            if (listBox1.SelectedIndex == 10)
            {
                int n10 = 0;
                if (int.TryParse(label39.Text, out n10) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m10 = 0;
                if (int.TryParse(label40.Text, out m10) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if (Global.d01 == 2 && Global.d02 == 3 && Global.d03 == 4 && Global.d04 == 5 && Global.d05 == 6 )
                {
                    Global.score = 40;
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label39.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label40.Text = Global.score.ToString();
                }

            }
            //大順分數計算及顯示

            if (listBox1.SelectedIndex == 11)
            {
                int n11 = 0;
                if (int.TryParse(label41.Text, out n11) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m11 = 0;
                if (int.TryParse(label42.Text, out m11) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                for (int i = 1; i <= 6; i++)
                {
                    if(Global.d01==Global.d02 && Global.d04==Global.d05)
                    {
                        if(Global.d02==Global.d03)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d05 && Global.d02 == Global.d03)
                    {
                        if (Global.d03 == Global.d04)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d02 && Global.d03 == Global.d04)
                    {
                        if (Global.d04 == Global.d05)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d02 && Global.d03 == Global.d04)
                    {
                        if (Global.d04 == Global.d05)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d02 && Global.d03 == Global.d05)
                    {
                        if (Global.d02 == Global.d04)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d02 == Global.d03 && Global.d04 == Global.d05)
                    {
                        if (Global.d01 == Global.d04)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d03 && Global.d02 == Global.d04)
                    {
                        if (Global.d04 == Global.d05)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d02 == Global.d05 && Global.d03 == Global.d04)
                    {
                        if (Global.d03 == Global.d01)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d04 && Global.d02 == Global.d03)
                    {
                        if (Global.d03 == Global.d05)
                        {
                            Global.score = 50;
                        }
                    }
                    if (Global.d01 == Global.d05 && Global.d02 == Global.d04)
                    {
                        if (Global.d03 == Global.d01)
                        {
                            Global.score = 50;
                        }
                    }

                }

                    button2.Enabled = true;

                if (Global.player == 0)
                {
                    label41.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label42.Text = Global.score.ToString();
                }

            }
            //葫蘆分數計算及顯示

            if (listBox1.SelectedIndex == 12)
            {
                int n12 = 0;
                if (int.TryParse(label43.Text, out n12) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m12 = 0;
                if (int.TryParse(label44.Text, out m12) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                if(Global.d01==Global.d02)
                {
                   if( Global.d02==Global.d03)
                    {
                        if(Global.d03==Global.d04)
                        {
                            if (Global.d04 == Global.d05)
                            {
                                Global.score = 50;
                            }
                        }
                    }
                }

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label43.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label44.Text = Global.score.ToString();
                }

            }
            //壓死分數計算及顯示

            if (listBox1.SelectedIndex == 13)
            {
                int n13 = 0;
                if (int.TryParse(label45.Text, out n13) && Global.player == 0)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }
                int m13 = 0;
                if (int.TryParse(label46.Text, out m13) && Global.player == 1)
                {
                    MessageBox.Show("已登記過，請選擇其他計分規則");
                    return;
                }

                Global.score = Global.d01 + Global.d02 + Global.d03 + Global.d04 + Global.d05;

                button2.Enabled = true;

                if (Global.player == 0)
                {
                    label45.Text = Global.score.ToString();
                }
                if (Global.player == 1)
                {
                    label46.Text = Global.score.ToString();
                }

            }
            //機會分數計算及顯示

            if(Global.bounsscorep1>=63)
            {
                Global.bounsscorep1 = 0;

                Global.bounsscore = 35;

                if (Global.player == 0)
                {
                    label31.Text = Global.bounsscore.ToString();
                    Global.allscorep1 += Global.bounsscore;
                }

                MessageBox.Show("P1獲得加分!(35)");

            }
            if (Global.bounsscorep2 >= 63)
            {
                Global.bounsscorep2 = 0;

                Global.bounsscore = 35;

                if (Global.player == 0)
                {
                    label32.Text = Global.bounsscore.ToString();
                    Global.allscorep2 += Global.bounsscore;
                }

                MessageBox.Show("P2獲得加分!(35)");

            }
            //加分(35)分數計算及顯示

            if (listBox1.SelectedIndex==6)
            {
                listBox1.Enabled = true;
            }




        }




        private void button2_Click(object sender, EventArgs e)
        {
            
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

            button1.Enabled = true;
            listBox1.Enabled = false;

            



            if (Global.player==1)
            {
                
                Global.player = 0;
                label1.Text = "目前狀態:P1";
                button2.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                Global.allscorep2 += Global.score;
                label48.Text = Global.allscorep2.ToString();
                Global.score = 0;
                Global.endtimesp2 += 1;
                if (Global.endtimesp2 >= 13)
                {
                    MessageBox.Show("P2已完成，總分=" + Global.allscorep2);


                    if (Global.endtimesp1 >= 13 && Global.endtimesp2 >= 13)
                    {

                        button3.Enabled = true;

                    }
                }

                return;
            }
           
            if (Global.player == 0)
            {

                Global.player = 1;
                label1.Text = "目前狀態:P2";
                button2.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                Global.allscorep1 += Global.score;
                label47.Text = Global.allscorep1.ToString();
                Global.score = 0;
                Global.endtimesp1 += 1;
                if (Global.endtimesp1 >= 13)
                {
                    MessageBox.Show("P1已完成，總分=" + Global.allscorep1);


                    if (Global.endtimesp1 >= 13 && Global.endtimesp2 >= 13)
                    {

                        button3.Enabled = true;

                    }
                }

                return;
            }


           

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           //已廢棄
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            listBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;





            if (Global.allscorep1 > Global.allscorep2)
            {
                MessageBox.Show("P1獲勝!");
            }
            if (Global.allscorep2 > Global.allscorep1)
            {
                MessageBox.Show("P2獲勝!");
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Global.score = 0;
            //Global.allscorep1 = 0;
            //Global.allscorep2 = 0;
            //Global.bounsscore = 0;
            //Global.bounsscorep1 = 0;
            //Global.bounsscorep2 = 0;
            //Global.endtimesp1 = 0;
            //Global.endtimesp2 = 0;
            //已廢棄
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ptt.cc/bbs/BoardGame/M.1369816892.A.31C.html");
        }
    }
}
