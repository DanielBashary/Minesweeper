using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.MinesweeperModel;
using Point = System.Drawing.Point;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent2();
        }

        public static bool gameStarted = false;
        public static List<Button> buttons;

        private void InitializeComponent2()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button35 = new Button();
            button36 = new Button();
            button37 = new Button();
            button38 = new Button();
            button39 = new Button();
            button40 = new Button();
            button41 = new Button();
            button42 = new Button();
            button43 = new Button();
            button44 = new Button();
            button45 = new Button();
            button46 = new Button();
            button47 = new Button();
            button48 = new Button();
            button49 = new Button();
            button50 = new Button();
            button51 = new Button();
            button52 = new Button();
            button53 = new Button();
            button54 = new Button();
            button55 = new Button();
            button56 = new Button();
            button57 = new Button();
            button58 = new Button();
            button59 = new Button();
            button60 = new Button();
            button61 = new Button();
            button62 = new Button();
            button63 = new Button();
            button64 = new Button();
            button65 = new Button();
            button66 = new Button();
            button67 = new Button();
            button68 = new Button();
            button69 = new Button();
            button70 = new Button();
            button71 = new Button();
            button72 = new Button();
            button73 = new Button();
            button74 = new Button();
            button75 = new Button();
            button76 = new Button();
            button77 = new Button();
            button78 = new Button();
            button79 = new Button();
            button80 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttons = new List<Button>()
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25,
                button26, button27, button28, button29, button30,
                button31, button32, button33, button34, button35,
                button36, button37, button38, button39, button40,
                button41, button42, button43, button44, button45,
                button46, button47, button48, button49, button50,
                button51, button52, button53, button54, button55,
                button56, button57, button58, button59, button60,
                button61, button62, button63, button64, button65,
                button66, button67, button68, button69, button70,
                button71, button72, button73, button74, button75,
                button76, button77, button78, button79, button80,

            };
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 54);
            button1.Name = "button1";
            button1.Size = new Size(46, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseDown += button72_MouseDown;
            // 
            // button2
            // 
            button2.Location = new Point(69, 54);
            button2.Name = "button2";
            button2.Size = new Size(46, 51);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            button2.MouseDown += button72_MouseDown;
            // 
            // button3
            // 
            button3.Location = new Point(121, 54);
            button3.Name = "button3";
            button3.Size = new Size(46, 51);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            button3.MouseDown += button72_MouseDown;
            // 
            // button4
            // 
            button4.Location = new Point(173, 54);
            button4.Name = "button4";
            button4.Size = new Size(46, 51);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            button4.MouseDown += button72_MouseDown;
            // 
            // button5
            // 
            button5.Location = new Point(225, 54);
            button5.Name = "button5";
            button5.Size = new Size(46, 51);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            button5.MouseDown += button72_MouseDown;
            // 
            // button6
            // 
            button6.Location = new Point(277, 54);
            button6.Name = "button6";
            button6.Size = new Size(46, 51);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            button6.MouseDown += button72_MouseDown;
            // 
            // button7
            // 
            button7.Location = new Point(329, 54);
            button7.Name = "button7";
            button7.Size = new Size(46, 51);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            button7.MouseDown += button72_MouseDown;
            // 
            // button8
            // 
            button8.Location = new Point(381, 54);
            button8.Name = "button8";
            button8.Size = new Size(46, 51);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            button8.MouseDown += button72_MouseDown;
            // 
            // button9
            // 
            button9.Location = new Point(17, 111);
            button9.Name = "button9";
            button9.Size = new Size(46, 51);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            button9.MouseDown += button72_MouseDown;
            // 
            // button10
            // 
            button10.Location = new Point(69, 111);
            button10.Name = "button10";
            button10.Size = new Size(46, 51);
            button10.TabIndex = 9;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button1_Click;
            button10.MouseDown += button72_MouseDown;
            // 
            // button11
            // 
            button11.Location = new Point(121, 111);
            button11.Name = "button11";
            button11.Size = new Size(46, 51);
            button11.TabIndex = 19;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button1_Click;
            button11.MouseDown += button72_MouseDown;
            // 
            // button12
            // 
            button12.Location = new Point(173, 111);
            button12.Name = "button12";
            button12.Size = new Size(46, 51);
            button12.TabIndex = 18;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button1_Click;
            button12.MouseDown += button72_MouseDown;
            // 
            // button13
            // 
            button13.Location = new Point(225, 111);
            button13.Name = "button13";
            button13.Size = new Size(46, 51);
            button13.TabIndex = 17;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button1_Click;
            button13.MouseDown += button72_MouseDown;
            // 
            // button14
            // 
            button14.Location = new Point(277, 111);
            button14.Name = "button14";
            button14.Size = new Size(46, 51);
            button14.TabIndex = 16;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button1_Click;
            button14.MouseDown += button72_MouseDown;
            // 
            // button15
            // 
            button15.Location = new Point(329, 111);
            button15.Name = "button15";
            button15.Size = new Size(46, 51);
            button15.TabIndex = 15;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button1_Click;
            button15.MouseDown += button72_MouseDown;
            // 
            // button16
            // 
            button16.Location = new Point(381, 111);
            button16.Name = "button16";
            button16.Size = new Size(46, 51);
            button16.TabIndex = 14;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button1_Click;
            button16.MouseDown += button72_MouseDown;
            // 
            // button17
            // 
            button17.Location = new Point(17, 168);
            button17.Name = "button17";
            button17.Size = new Size(46, 51);
            button17.TabIndex = 13;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button1_Click;
            button17.MouseDown += button72_MouseDown;
            // 
            // button18
            // 
            button18.Location = new Point(69, 168);
            button18.Name = "button18";
            button18.Size = new Size(46, 51);
            button18.TabIndex = 12;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button1_Click;
            button18.MouseDown += button72_MouseDown;
            // 
            // button19
            // 
            button19.Location = new Point(121, 168);
            button19.Name = "button19";
            button19.Size = new Size(46, 51);
            button19.TabIndex = 11;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button1_Click;
            button19.MouseDown += button72_MouseDown;
            // 
            // button20
            // 
            button20.Location = new Point(173, 168);
            button20.Name = "button20";
            button20.Size = new Size(46, 51);
            button20.TabIndex = 10;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button1_Click;
            button20.MouseDown += button72_MouseDown;
            // 
            // button21
            // 
            button21.Location = new Point(225, 168);
            button21.Name = "button21";
            button21.Size = new Size(46, 51);
            button21.TabIndex = 29;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button1_Click;
            button21.MouseDown += button72_MouseDown;
            // 
            // button22
            // 
            button22.Location = new Point(277, 168);
            button22.Name = "button22";
            button22.Size = new Size(46, 51);
            button22.TabIndex = 28;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button1_Click;
            button22.MouseDown += button72_MouseDown;
            // 
            // button23
            // 
            button23.Location = new Point(329, 168);
            button23.Name = "button23";
            button23.Size = new Size(46, 51);
            button23.TabIndex = 27;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button1_Click;
            button23.MouseDown += button72_MouseDown;
            // 
            // button24
            // 
            button24.Location = new Point(381, 168);
            button24.Name = "button24";
            button24.Size = new Size(46, 51);
            button24.TabIndex = 26;
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button1_Click;
            button24.MouseDown += button72_MouseDown;
            // 
            // button25
            // 
            button25.Location = new Point(17, 225);
            button25.Name = "button25";
            button25.Size = new Size(46, 51);
            button25.TabIndex = 25;
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button1_Click;
            button25.MouseDown += button72_MouseDown;
            // 
            // button26
            // 
            button26.Location = new Point(69, 225);
            button26.Name = "button26";
            button26.Size = new Size(46, 51);
            button26.TabIndex = 24;
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = true;
            button26.Click += button1_Click;
            button26.MouseDown += button72_MouseDown;
            // 
            // button27
            // 
            button27.Location = new Point(121, 225);
            button27.Name = "button27";
            button27.Size = new Size(46, 51);
            button27.TabIndex = 23;
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = true;
            button27.Click += button1_Click;
            button27.MouseDown += button72_MouseDown;
            // 
            // button28
            // 
            button28.Location = new Point(173, 225);
            button28.Name = "button28";
            button28.Size = new Size(46, 51);
            button28.TabIndex = 22;
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = true;
            button28.Click += button1_Click;
            button28.MouseDown += button72_MouseDown;
            // 
            // button29
            // 
            button29.Location = new Point(225, 225);
            button29.Name = "button29";
            button29.Size = new Size(46, 51);
            button29.TabIndex = 21;
            button29.Text = "button29";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button1_Click;
            button29.MouseDown += button72_MouseDown;
            // 
            // button30
            // 
            button30.Location = new Point(277, 225);
            button30.Name = "button30";
            button30.Size = new Size(46, 51);
            button30.TabIndex = 20;
            button30.Text = "button30";
            button30.UseVisualStyleBackColor = true;
            button30.Click += button1_Click;
            button30.MouseDown += button72_MouseDown;
            // 
            // button31
            // 
            button31.Location = new Point(329, 225);
            button31.Name = "button31";
            button31.Size = new Size(46, 51);
            button31.TabIndex = 39;
            button31.Text = "button31";
            button31.UseVisualStyleBackColor = true;
            button31.Click += button1_Click;
            button31.MouseDown += button72_MouseDown;
            // 
            // button32
            // 
            button32.Location = new Point(381, 225);
            button32.Name = "button32";
            button32.Size = new Size(46, 51);
            button32.TabIndex = 38;
            button32.Text = "button32";
            button32.UseVisualStyleBackColor = true;
            button32.Click += button1_Click;
            button32.MouseDown += button72_MouseDown;
            // 
            // button33
            // 
            button33.Location = new Point(17, 282);
            button33.Name = "button33";
            button33.Size = new Size(46, 51);
            button33.TabIndex = 37;
            button33.Text = "button33";
            button33.UseVisualStyleBackColor = true;
            button33.Click += button1_Click;
            button33.MouseDown += button72_MouseDown;
            // 
            // button34
            // 
            button34.Location = new Point(69, 282);
            button34.Name = "button34";
            button34.Size = new Size(46, 51);
            button34.TabIndex = 36;
            button34.Text = "button34";
            button34.UseVisualStyleBackColor = true;
            button34.Click += button1_Click;
            button34.MouseDown += button72_MouseDown;
            // 
            // button35
            // 
            button35.Location = new Point(121, 282);
            button35.Name = "button35";
            button35.Size = new Size(46, 51);
            button35.TabIndex = 35;
            button35.Text = "button35";
            button35.UseVisualStyleBackColor = true;
            button35.Click += button1_Click;
            button35.MouseDown += button72_MouseDown;
            // 
            // button36
            // 
            button36.Location = new Point(173, 282);
            button36.Name = "button36";
            button36.Size = new Size(46, 51);
            button36.TabIndex = 34;
            button36.Text = "button36";
            button36.UseVisualStyleBackColor = true;
            button36.Click += button1_Click;
            button36.MouseDown += button72_MouseDown;
            // 
            // button37
            // 
            button37.Location = new Point(225, 282);
            button37.Name = "button37";
            button37.Size = new Size(46, 51);
            button37.TabIndex = 33;
            button37.Text = "button37";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button1_Click;
            button37.MouseDown += button72_MouseDown;
            // 
            // button38
            // 
            button38.Location = new Point(277, 282);
            button38.Name = "button38";
            button38.Size = new Size(46, 51);
            button38.TabIndex = 32;
            button38.Text = "button38";
            button38.UseVisualStyleBackColor = true;
            button38.Click += button1_Click;
            button38.MouseDown += button72_MouseDown;
            // 
            // button39
            // 
            button39.Location = new Point(329, 282);
            button39.Name = "button39";
            button39.Size = new Size(46, 51);
            button39.TabIndex = 31;
            button39.Text = "button39";
            button39.UseVisualStyleBackColor = true;
            button39.Click += button1_Click;
            button39.MouseDown += button72_MouseDown;
            // 
            // button40
            // 
            button40.Location = new Point(381, 282);
            button40.Name = "button40";
            button40.Size = new Size(46, 51);
            button40.TabIndex = 30;
            button40.Text = "button40";
            button40.UseVisualStyleBackColor = true;
            button40.Click += button1_Click;
            button40.MouseDown += button72_MouseDown;
            // 
            // button41
            // 
            button41.Location = new Point(17, 339);
            button41.Name = "button41";
            button41.Size = new Size(46, 51);
            button41.TabIndex = 49;
            button41.Text = "button41";
            button41.UseVisualStyleBackColor = true;
            button41.Click += button1_Click;
            button41.MouseDown += button72_MouseDown;
            // 
            // button42
            // 
            button42.Location = new Point(69, 339);
            button42.Name = "button42";
            button42.Size = new Size(46, 51);
            button42.TabIndex = 48;
            button42.Text = "button42";
            button42.UseVisualStyleBackColor = true;
            button42.Click += button1_Click;
            button42.MouseDown += button72_MouseDown;
            // 
            // button43
            // 
            button43.Location = new Point(121, 339);
            button43.Name = "button43";
            button43.Size = new Size(46, 51);
            button43.TabIndex = 47;
            button43.Text = "button43";
            button43.UseVisualStyleBackColor = true;
            button43.Click += button1_Click;
            button43.MouseDown += button72_MouseDown;
            // 
            // button44
            // 
            button44.Location = new Point(173, 339);
            button44.Name = "button44";
            button44.Size = new Size(46, 51);
            button44.TabIndex = 46;
            button44.Text = "button44";
            button44.UseVisualStyleBackColor = true;
            button44.Click += button1_Click;
            button44.MouseDown += button72_MouseDown;
            // 
            // button45
            // 
            button45.Location = new Point(225, 339);
            button45.Name = "button45";
            button45.Size = new Size(46, 51);
            button45.TabIndex = 45;
            button45.Text = "button45";
            button45.UseVisualStyleBackColor = true;
            button45.Click += button1_Click;
            button45.MouseDown += button72_MouseDown;
            // 
            // button46
            // 
            button46.Location = new Point(277, 339);
            button46.Name = "button46";
            button46.Size = new Size(46, 51);
            button46.TabIndex = 44;
            button46.Text = "button46";
            button46.UseVisualStyleBackColor = true;
            button46.Click += button1_Click;
            button46.MouseDown += button72_MouseDown;
            // 
            // button47
            // 
            button47.Location = new Point(329, 339);
            button47.Name = "button47";
            button47.Size = new Size(46, 51);
            button47.TabIndex = 43;
            button47.Text = "button47";
            button47.UseVisualStyleBackColor = true;
            button47.Click += button1_Click;
            button47.MouseDown += button72_MouseDown;
            // 
            // button48
            // 
            button48.Location = new Point(381, 339);
            button48.Name = "button48";
            button48.Size = new Size(46, 51);
            button48.TabIndex = 42;
            button48.Text = "button48";
            button48.UseVisualStyleBackColor = true;
            button48.Click += button1_Click;
            button48.MouseDown += button72_MouseDown;
            // 
            // button49
            // 
            button49.Location = new Point(17, 396);
            button49.Name = "button49";
            button49.Size = new Size(46, 51);
            button49.TabIndex = 41;
            button49.Text = "button49";
            button49.UseVisualStyleBackColor = true;
            button49.Click += button1_Click;
            button49.MouseDown += button72_MouseDown;
            // 
            // button50
            // 
            button50.Location = new Point(69, 396);
            button50.Name = "button50";
            button50.Size = new Size(46, 51);
            button50.TabIndex = 40;
            button50.Text = "button50";
            button50.UseVisualStyleBackColor = true;
            button50.Click += button1_Click;
            button50.MouseDown += button72_MouseDown;
            // 
            // button51
            // 
            button51.Location = new Point(121, 396);
            button51.Name = "button51";
            button51.Size = new Size(46, 51);
            button51.TabIndex = 59;
            button51.Text = "button51";
            button51.UseVisualStyleBackColor = true;
            button51.Click += button1_Click;
            button51.MouseDown += button72_MouseDown;
            // 
            // button52
            // 
            button52.Location = new Point(173, 396);
            button52.Name = "button52";
            button52.Size = new Size(46, 51);
            button52.TabIndex = 58;
            button52.Text = "button52";
            button52.UseVisualStyleBackColor = true;
            button52.Click += button1_Click;
            button52.MouseDown += button72_MouseDown;
            // 
            // button53
            // 
            button53.Location = new Point(225, 396);
            button53.Name = "button53";
            button53.Size = new Size(46, 51);
            button53.TabIndex = 57;
            button53.Text = "button53";
            button53.UseVisualStyleBackColor = true;
            button53.Click += button1_Click;
            button53.MouseDown += button72_MouseDown;
            // 
            // button54
            // 
            button54.Location = new Point(277, 396);
            button54.Name = "button54";
            button54.Size = new Size(46, 51);
            button54.TabIndex = 56;
            button54.Text = "button54";
            button54.UseVisualStyleBackColor = true;
            button54.Click += button1_Click;
            button54.MouseDown += button72_MouseDown;
            // 
            // button55
            // 
            button55.Location = new Point(329, 396);
            button55.Name = "button55";
            button55.Size = new Size(46, 51);
            button55.TabIndex = 55;
            button55.Text = "button55";
            button55.UseVisualStyleBackColor = true;
            button55.Click += button1_Click;
            button55.MouseDown += button72_MouseDown;
            // 
            // button56
            // 
            button56.Location = new Point(381, 396);
            button56.Name = "button56";
            button56.Size = new Size(46, 51);
            button56.TabIndex = 54;
            button56.Text = "button56";
            button56.UseVisualStyleBackColor = true;
            button56.Click += button1_Click;
            button56.MouseDown += button72_MouseDown;
            // 
            // button57
            // 
            button57.Location = new Point(17, 453);
            button57.Name = "button57";
            button57.Size = new Size(46, 51);
            button57.TabIndex = 53;
            button57.Text = "button57";
            button57.UseVisualStyleBackColor = true;
            button57.Click += button1_Click;
            button57.MouseDown += button72_MouseDown;
            // 
            // button58
            // 
            button58.Location = new Point(69, 453);
            button58.Name = "button58";
            button58.Size = new Size(46, 51);
            button58.TabIndex = 52;
            button58.Text = "button58";
            button58.UseVisualStyleBackColor = true;
            button58.Click += button1_Click;
            button58.MouseDown += button72_MouseDown;
            // 
            // button59
            // 
            button59.Location = new Point(121, 453);
            button59.Name = "button59";
            button59.Size = new Size(46, 51);
            button59.TabIndex = 51;
            button59.Text = "button59";
            button59.UseVisualStyleBackColor = true;
            button59.Click += button1_Click;
            button59.MouseDown += button72_MouseDown;
            // 
            // button60
            // 
            button60.Location = new Point(173, 453);
            button60.Name = "button60";
            button60.Size = new Size(46, 51);
            button60.TabIndex = 50;
            button60.Text = "button60";
            button60.UseVisualStyleBackColor = true;
            button60.Click += button1_Click;
            button60.MouseDown += button72_MouseDown;
            // 
            // button61
            // 
            button61.Location = new Point(225, 453);
            button61.Name = "button61";
            button61.Size = new Size(46, 51);
            button61.TabIndex = 69;
            button61.Text = "button61";
            button61.UseVisualStyleBackColor = true;
            button61.Click += button1_Click;
            button61.MouseDown += button72_MouseDown;
            // 
            // button62
            // 
            button62.Location = new Point(277, 453);
            button62.Name = "button62";
            button62.Size = new Size(46, 51);
            button62.TabIndex = 68;
            button62.Text = "button62";
            button62.UseVisualStyleBackColor = true;
            button62.Click += button1_Click;
            button62.MouseDown += button72_MouseDown;
            // 
            // button63
            // 
            button63.Location = new Point(329, 453);
            button63.Name = "button63";
            button63.Size = new Size(46, 51);
            button63.TabIndex = 67;
            button63.Text = "button63";
            button63.UseVisualStyleBackColor = true;
            button63.Click += button1_Click;
            button63.MouseDown += button72_MouseDown;
            // 
            // button64
            // 
            button64.Location = new Point(381, 453);
            button64.Name = "button64";
            button64.Size = new Size(46, 51);
            button64.TabIndex = 66;
            button64.Text = "button64";
            button64.UseVisualStyleBackColor = true;
            button64.Click += button1_Click;
            button64.MouseDown += button72_MouseDown;
            // 
            // button65
            // 
            button65.Location = new Point(17, 510);
            button65.Name = "button65";
            button65.Size = new Size(46, 51);
            button65.TabIndex = 65;
            button65.Text = "button65";
            button65.UseVisualStyleBackColor = true;
            button65.Click += button1_Click;
            button65.MouseDown += button72_MouseDown;
            // 
            // button66
            // 
            button66.Location = new Point(69, 510);
            button66.Name = "button66";
            button66.Size = new Size(46, 51);
            button66.TabIndex = 64;
            button66.Text = "button66";
            button66.UseVisualStyleBackColor = true;
            button66.Click += button1_Click;
            button66.MouseDown += button72_MouseDown;
            // 
            // button67
            // 
            button67.Location = new Point(121, 510);
            button67.Name = "button67";
            button67.Size = new Size(46, 51);
            button67.TabIndex = 63;
            button67.Text = "button67";
            button67.UseVisualStyleBackColor = true;
            button67.Click += button1_Click;
            button67.MouseDown += button72_MouseDown;
            // 
            // button68
            // 
            button68.Location = new Point(173, 510);
            button68.Name = "button68";
            button68.Size = new Size(46, 51);
            button68.TabIndex = 62;
            button68.Text = "button68";
            button68.UseVisualStyleBackColor = true;
            button68.Click += button1_Click;
            button68.MouseDown += button72_MouseDown;
            // 
            // button69
            // 
            button69.Location = new Point(225, 510);
            button69.Name = "button69";
            button69.Size = new Size(46, 51);
            button69.TabIndex = 61;
            button69.Text = "button69";
            button69.UseVisualStyleBackColor = true;
            button69.Click += button1_Click;
            button69.MouseDown += button72_MouseDown;
            // 
            // button70
            // 
            button70.Location = new Point(277, 510);
            button70.Name = "button70";
            button70.Size = new Size(46, 51);
            button70.TabIndex = 60;
            button70.Text = "button70";
            button70.UseVisualStyleBackColor = true;
            button70.Click += button1_Click;
            button70.MouseDown += button72_MouseDown;
            // 
            // button71
            // 
            button71.Location = new Point(329, 510);
            button71.Name = "button71";
            button71.Size = new Size(46, 51);
            button71.TabIndex = 79;
            button71.Text = "button71";
            button71.UseVisualStyleBackColor = true;
            button71.Click += button1_Click;
            button71.MouseDown += button72_MouseDown;
            // 
            // button72
            // 
            button72.Location = new Point(381, 510);
            button72.Name = "button72";
            button72.Size = new Size(46, 51);
            button72.TabIndex = 78;
            button72.Text = "button72";
            button72.UseVisualStyleBackColor = true;
            button72.Click += button1_Click;
            button72.MouseDown += button72_MouseDown;
            // 
            // button73
            // 
            button73.Location = new Point(17, 567);
            button73.Name = "button73";
            button73.Size = new Size(46, 51);
            button73.TabIndex = 77;
            button73.Text = "button73";
            button73.UseVisualStyleBackColor = true;
            button73.Click += button1_Click;
            button73.MouseDown += button72_MouseDown;
            // 
            // button74
            // 
            button74.Location = new Point(69, 567);
            button74.Name = "button74";
            button74.Size = new Size(46, 51);
            button74.TabIndex = 76;
            button74.Text = "button74";
            button74.UseVisualStyleBackColor = true;
            button74.Click += button1_Click;
            button74.MouseDown += button72_MouseDown;
            // 
            // button75
            // 
            button75.Location = new Point(121, 567);
            button75.Name = "button75";
            button75.Size = new Size(46, 51);
            button75.TabIndex = 75;
            button75.Text = "button75";
            button75.UseVisualStyleBackColor = true;
            button75.Click += button1_Click;
            button75.MouseDown += button72_MouseDown;
            // 
            // button76
            // 
            button76.Location = new Point(173, 567);
            button76.Name = "button76";
            button76.Size = new Size(46, 51);
            button76.TabIndex = 74;
            button76.Text = "button76";
            button76.UseVisualStyleBackColor = true;
            button76.Click += button1_Click;
            button76.MouseDown += button72_MouseDown;
            // 
            // button77
            // 
            button77.Location = new Point(225, 567);
            button77.Name = "button77";
            button77.Size = new Size(46, 51);
            button77.TabIndex = 73;
            button77.Text = "button77";
            button77.UseVisualStyleBackColor = true;
            button77.Click += button1_Click;
            button77.MouseDown += button72_MouseDown;
            // 
            // button78
            // 
            button78.Location = new Point(277, 567);
            button78.Name = "button78";
            button78.Size = new Size(46, 51);
            button78.TabIndex = 72;
            button78.Text = "button78";
            button78.UseVisualStyleBackColor = true;
            button78.Click += button1_Click;
            button78.MouseDown += button72_MouseDown;
            // 
            // button79
            // 
            button79.Location = new Point(329, 567);
            button79.Name = "button79";
            button79.Size = new Size(46, 51);
            button79.TabIndex = 71;
            button79.Text = "button79";
            button79.UseVisualStyleBackColor = true;
            button79.Click += button1_Click;
            button79.MouseDown += button72_MouseDown;
            // 
            // button80
            // 
            button80.Location = new Point(381, 567);
            button80.Name = "button80";
            button80.Size = new Size(46, 51);
            button80.TabIndex = 70;
            button80.Text = "button80";
            button80.UseVisualStyleBackColor = true;
            button80.Click += button1_Click;
            button80.MouseDown += button72_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 80;
            label1.Text = "Flag Count: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(91, 9);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 81;
            label2.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(121, 9);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 82;
            label3.Text = "Bomb Count: 10";
            // 
            // Form1
            // 
            ClientSize = new Size(455, 642);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button71);
            Controls.Add(button72);
            Controls.Add(button73);
            Controls.Add(button74);
            Controls.Add(button75);
            Controls.Add(button76);
            Controls.Add(button77);
            Controls.Add(button78);
            Controls.Add(button79);
            Controls.Add(button80);
            Controls.Add(button61);
            Controls.Add(button62);
            Controls.Add(button63);
            Controls.Add(button64);
            Controls.Add(button65);
            Controls.Add(button66);
            Controls.Add(button67);
            Controls.Add(button68);
            Controls.Add(button69);
            Controls.Add(button70);
            Controls.Add(button51);
            Controls.Add(button52);
            Controls.Add(button53);
            Controls.Add(button54);
            Controls.Add(button55);
            Controls.Add(button56);
            Controls.Add(button57);
            Controls.Add(button58);
            Controls.Add(button59);
            Controls.Add(button60);
            Controls.Add(button41);
            Controls.Add(button42);
            Controls.Add(button43);
            Controls.Add(button44);
            Controls.Add(button45);
            Controls.Add(button46);
            Controls.Add(button47);
            Controls.Add(button48);
            Controls.Add(button49);
            Controls.Add(button50);
            Controls.Add(button31);
            Controls.Add(button32);
            Controls.Add(button33);
            Controls.Add(button34);
            Controls.Add(button35);
            Controls.Add(button36);
            Controls.Add(button37);
            Controls.Add(button38);
            Controls.Add(button39);
            Controls.Add(button40);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e) {}

        private void button72_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button.ToString().Length > 40)
            {
                int buttonNumber = int.Parse(button.ToString().Substring(41)) - 1;
                int x = buttonNumber % 8;
                int y = (int)Math.Floor(buttonNumber / 8.0);
                if (e.Button == MouseButtons.Left)
                {
                    if (!gameStarted)
                    {
                        gameStarted = true;
                        PlayerStart(x, y);
                        int tableSpot = 0;
                        var rowCount = pointTable.GetLength(0);
                        var colCount = pointTable.GetLength(1);

                        for (int col = 0; col < colCount; col++)
                        {
                            for (int row = 0; row < rowCount; row++)
                            {
                                if (pointTable[row, col] == MinesweeperModel.Point.Pressed)
                                {
                                    buttons[tableSpot].BackColor = Color.Aquamarine;
                                    buttons[tableSpot].Text = tableCounter[row, col].ToString();
                                }

                                tableSpot++;
                            }
                        }
                    }
                    else
                    {
                        if (PlayerMoveChecker(x, y))
                        {
                            int tableSpot = 0;
                            int pointPressed = 0;
                            var rowCount = pointTable.GetLength(0);
                            var colCount = pointTable.GetLength(1);

                            for (int col = 0; col < colCount; col++)
                            {
                                for (int row = 0; row < rowCount; row++)
                                {
                                    if (pointTable[row, col] == MinesweeperModel.Point.Pressed)
                                    {
                                        buttons[tableSpot].BackColor = Color.Aquamarine;
                                        buttons[tableSpot].Text = tableCounter[row, col].ToString();
                                        pointPressed++;
                                        if (pointPressed == 70)
                                        {
                                            foreach (var buttonWinner in buttons)
                                            {
                                                buttonWinner.BackColor = Color.DarkGreen;
                                                buttonWinner.Text = "WINNER";
                                            }
                                        }
                                    }

                                    tableSpot++;
                                }
                            }
                        }
                        else
                        {
                            Application.Restart();
                        }
                    }
                }

                if (e.Button == MouseButtons.Right)
                {
                    int flagCount = Int32.Parse(label2.Text);
                    if (flagCount > 0)
                    {
                        flagCount--;
                        label2.Text = flagCount + "";
                        button.Text = "FLAG";
                        button.BackColor = Color.Crimson;
                    }
                }
            }
        }
    }
}