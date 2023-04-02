using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateField(object sender, System.EventArgs e)
        {
            bool click = true;
            int posX = 0;
            int posY = 0;
            for (int i = 0; i < 9; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.Location = new Point(posX, posY);
                btn.Font = new Font("Times New Roman", 28);
                btn.Click += (ev, sendr) =>
                {
                    if (click) btn.Text = "X";
                    else btn.Text = "0";
                    click = !click;
                    btn.Enabled = false;
                    if (this.Controls[0].Text.Equals("X") && this.Controls[1].Text.Equals("X") && this.Controls[2].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[1].BackColor = Color.YellowGreen;
                        this.Controls[2].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[0].Text.Equals("X") && this.Controls[4].Text.Equals("X") && this.Controls[8].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[0].Text.Equals("X") && this.Controls[3].Text.Equals("X") && this.Controls[6].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[3].BackColor = Color.YellowGreen;
                        this.Controls[6].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[0].Text.Equals("0") && this.Controls[1].Text.Equals("0") && this.Controls[2].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[1].BackColor = Color.YellowGreen;
                        this.Controls[2].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[0].Text.Equals("0") && this.Controls[4].Text.Equals("0") && this.Controls[8].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[0].Text.Equals("0") && this.Controls[3].Text.Equals("0") && this.Controls[6].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[0].BackColor = Color.YellowGreen;
                        this.Controls[3].BackColor = Color.YellowGreen;
                        this.Controls[6].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }                    
                    else if (this.Controls[1].Text.Equals("X") && this.Controls[4].Text.Equals("X") && this.Controls[7].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[1].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[7].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }                    
                    else if (this.Controls[1].Text.Equals("0") && this.Controls[4].Text.Equals("0") && this.Controls[7].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[1].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[7].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }                   
                    else if (this.Controls[2].Text.Equals("X") && this.Controls[4].Text.Equals("X") && this.Controls[6].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[2].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[6].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[2].Text.Equals("X") && this.Controls[5].Text.Equals("X") && this.Controls[8].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[2].BackColor = Color.YellowGreen;
                        this.Controls[5].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }                    
                    else if (this.Controls[2].Text.Equals("0") && this.Controls[4].Text.Equals("0") && this.Controls[6].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[2].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[6].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[2].Text.Equals("0") && this.Controls[5].Text.Equals("0") && this.Controls[8].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[2].BackColor = Color.YellowGreen;
                        this.Controls[5].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[3].Text.Equals("X") && this.Controls[4].Text.Equals("X") && this.Controls[5].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[3].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[5].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }                    
                    else if (this.Controls[3].Text.Equals("0") && this.Controls[4].Text.Equals("0") && this.Controls[5].Text.Equals("0"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[3].BackColor = Color.YellowGreen;
                        this.Controls[4].BackColor = Color.YellowGreen;
                        this.Controls[5].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[6].Text.Equals("X") && this.Controls[7].Text.Equals("X") && this.Controls[8].Text.Equals("X"))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[6].BackColor = Color.YellowGreen;
                        this.Controls[7].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("X Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                    else if (this.Controls[6].Text.Equals("0") && this.Controls[7].Text.Equals("0") && this.Controls[8].Text.Equals("0"))
                    {
                        
                        for (int j = 0; j < 9; j++)
                        {
                            this.Controls[j].Enabled = false;
                        }
                        this.Controls[6].BackColor = Color.YellowGreen;
                        this.Controls[7].BackColor = Color.YellowGreen;
                        this.Controls[8].BackColor = Color.YellowGreen;
                        MessageBox.Show("O Wins", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Play again", "Caprion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Controls.Clear();
                            CreateField(sender, e);
                        }
                    }
                };
                this.Controls.Add(btn);
                if (posX >= 200)
                {
                    posX = 0;
                    posY += 100;
                }
                else posX += 100;
            }
        }
    }
}
