using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XOgame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 301);
            this.Text = "X 0 Game";
            this.ResumeLayout(false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;



            bool click = true;
            List<Button> buttons = new List<Button>();
            buttons.Add(btnOne); 
            buttons.Add(btnTwo);
            buttons.Add(btnThree);
            buttons.Add(btnFour);
            buttons.Add(btnFive);
            buttons.Add(btnSix);
            buttons.Add(btnSeven);
            buttons.Add(btnEight);
            buttons.Add(btnNine);
            //
            // First field
            //
            buttons[0] = new Button();
            buttons[0].Size = new Size(100, 100);
            buttons[0].Location = new Point(0, 0);
            buttons[0].Font = new Font("Times New Roman", 28);
            buttons[0].Click += (e, sender) =>
            {
                if (click) buttons[0].Text = "X";
                else buttons[0].Text = "0";
                click = !click;
                buttons[0].Enabled = false;
                if (buttons[0].Text.Equals("X") && buttons[1].Text.Equals("X") && buttons[2].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("X") && buttons[3].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[1].Text.Equals("0") && buttons[2].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                } 
                else if(buttons[0].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                } 
                else if(buttons[0].Text.Equals("0") && buttons[3].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
            };
            //
            // Second field
            //
            buttons[1] = new Button();
            buttons[1].Size = new Size(100, 100);
            buttons[1].Location = new Point(101, 0);
            buttons[1].Font = new Font("Times New Roman", 28);
            buttons[1].Click += (e, sender) =>
            {
                if (click) buttons[1].Text = "X";
                else buttons[1].Text = "0";
                click = !click;
                buttons[1].Enabled = false;
                if (buttons[0].Text.Equals("X") && buttons[1].Text.Equals("X") && buttons[2].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                }
                else if (buttons[1].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[7].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[1].Text.Equals("0") && buttons[2].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                } 
                else if(buttons[1].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[7].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
            };
            //
            // Third field
            //
            buttons[2] = new Button();
            buttons[2].Size = new Size(100, 100);
            buttons[2].Location = new Point(201, 0);
            buttons[2].Font = new Font("Times New Roman", 28);
            buttons[2].Click += (e, sender) =>
            {
                if (click) buttons[2].Text = "X";
                else buttons[2].Text = "0";
                click = !click;
                buttons[2].Enabled = false;
                if (buttons[0].Text.Equals("X") && buttons[1].Text.Equals("X") && buttons[2].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("X") && buttons[5].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[1].Text.Equals("0") && buttons[2].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[2].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                } 
                else if (buttons[2].Text.Equals("0") && buttons[5].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
            };
            //
            // Fourth field
            //
            buttons[3] = new Button();
            buttons[3].Size = new Size(100, 100);
            buttons[3].Location = new Point(0, 101);
            buttons[3].Font = new Font("Times New Roman", 28);
            buttons[3].Click += (e, sender) =>
            {
                if (click) buttons[3].Text = "X";
                else buttons[3].Text = "0";
                click = !click;
                buttons[3].Enabled = false;
                if (buttons[0].Text.Equals("X") && buttons[3].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[5].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[3].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[5].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
            };
            //
            // Fifth field
            //
            buttons[4] = new Button();
            buttons[4].Size = new Size(100, 100);
            buttons[4].Location = new Point(101, 101);
            buttons[4].Font = new Font("Times New Roman", 28);
            buttons[4].Click += (e, sender) =>
            {
                if (click) buttons[4].Text = "X";
                else buttons[4].Text = "0";
                click = !click;
                buttons[4].Enabled = false;
                if (buttons[1].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[7].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[5].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
                else if (buttons[1].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[7].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[5].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
            };
            //
            // Sixth field
            //
            buttons[5] = new Button();
            buttons[5].Size = new Size(100, 100);
            buttons[5].Location = new Point(201, 101);
            buttons[5].Font = new Font("Times New Roman", 28);
            buttons[5].Click += (e, sender) =>
            {
                if (click) buttons[5].Text = "X";
                else buttons[5].Text = "0";
                click = !click;
                buttons[5].Enabled = false;                
                if (buttons[2].Text.Equals("X") && buttons[5].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[5].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("0") && buttons[5].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[3].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[5].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                }
            };
            //
            // Seventh field
            //
            buttons[6] = new Button();
            buttons[6].Size = new Size(100, 100);
            buttons[6].Location = new Point(0, 201);
            buttons[6].Font = new Font("Times New Roman", 28);
            buttons[6].Click += (e, sender) =>
            {
                if (click) buttons[6].Text = "X";
                else buttons[6].Text = "0";
                click = !click;
                buttons[6].Enabled = false;
                if (buttons[2].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[6].Text.Equals("X") && buttons[7].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("X") && buttons[3].Text.Equals("X") && buttons[6].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
                else if (buttons[6].Text.Equals("0") && buttons[7].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[3].Text.Equals("0") && buttons[6].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[3].BackColor = Color.YellowGreen;
                    buttons[6].BackColor = Color.YellowGreen;
                }
            };
            //
            // Eighth field
            //
            buttons[7] = new Button();
            buttons[7].Size = new Size(100, 100);
            buttons[7].Location = new Point(101, 201);
            buttons[7].Font = new Font("Times New Roman", 28);
            buttons[7].Click += (e, sender) =>
            {
                if (click) buttons[7].Text = "X";
                else buttons[7].Text = "0";
                click = !click;
                buttons[7].Enabled = false;
                if (buttons[6].Text.Equals("X") && buttons[7].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[1].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[7].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
                else if (buttons[6].Text.Equals("0") && buttons[7].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[1].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[7].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[1].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                }
            };
            //
            // Ninth field
            //
            buttons[8] = new Button();
            buttons[8].Size = new Size(100, 100);
            buttons[8].Location = new Point(201, 201);
            buttons[8].Font = new Font("Times New Roman", 28);
            buttons[8].Click += (e, sender) =>
            {
                if (click) buttons[8].Text = "X";
                else buttons[8].Text = "0";
                click = !click;
                buttons[8].Enabled = false;
                if (buttons[6].Text.Equals("X") && buttons[7].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("X") && buttons[4].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("X") && buttons[5].Text.Equals("X") && buttons[8].Text.Equals("X"))
                {
                    this.Text = "X Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[6].Text.Equals("0") && buttons[7].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[6].BackColor = Color.YellowGreen;
                    buttons[7].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[0].Text.Equals("0") && buttons[4].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[0].BackColor = Color.YellowGreen;
                    buttons[4].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
                else if (buttons[2].Text.Equals("0") && buttons[5].Text.Equals("0") && buttons[8].Text.Equals("0"))
                {
                    this.Text = "0 Wins";
                    foreach (var btn in buttons)
                    {
                        btn.Enabled = false;
                    }
                    buttons[2].BackColor = Color.YellowGreen;
                    buttons[5].BackColor = Color.YellowGreen;
                    buttons[8].BackColor = Color.YellowGreen;
                }
            };

            this.Controls.Add(buttons[0]);
            this.Controls.Add(buttons[1]);
            this.Controls.Add(buttons[2]);
            this.Controls.Add(buttons[3]);
            this.Controls.Add(buttons[4]);
            this.Controls.Add(buttons[5]);
            this.Controls.Add(buttons[6]);
            this.Controls.Add(buttons[7]);
            this.Controls.Add(buttons[8]);
        }

        Button btnOne;
        Button btnTwo;
        Button btnThree;
        Button btnFour;
        Button btnFive;
        Button btnSix;
        Button btnSeven;
        Button btnEight;
        Button btnNine;

    }
}

