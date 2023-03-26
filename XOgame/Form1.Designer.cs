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
            //
            // First field
            //
            btnOne = new Button();
            btnOne.Size = new Size(100, 100);
            btnOne.Location = new Point(0, 0);
            btnOne.Font = new Font("Times New Roman", 28);
            btnOne.Click += (e, sender) =>
            {
                if (click) btnOne.Text = "X";
                else btnOne.Text = "0";
                click = !click;
                btnOne.Enabled = false;
            };
            //
            // Second field
            //
            btnTwo = new Button();
            btnTwo.Size = new Size(100, 100);
            btnTwo.Location = new Point(101, 0);
            btnTwo.Font = new Font("Times New Roman", 28);
            btnTwo.Click += (e, sender) =>
            {
                if (click) btnTwo.Text = "X";
                else btnTwo.Text = "0";
                click = !click;
                btnTwo.Enabled = false;
            };
            //
            // Third field
            //
            btnThree = new Button();
            btnThree.Size = new Size(100, 100);
            btnThree.Location = new Point(201, 0);
            btnThree.Font = new Font("Times New Roman", 28);
            btnThree.Click += (e, sender) =>
            {
                if (click) btnThree.Text = "X";
                else btnThree.Text = "0";
                click = !click;
                btnThree.Enabled = false;
            };
            //
            // Fourth field
            //
            btnFour = new Button();
            btnFour.Size = new Size(100, 100);
            btnFour.Location = new Point(0, 101);
            btnFour.Font = new Font("Times New Roman", 28);
            btnFour.Click += (e, sender) =>
            {
                if (click) btnFour.Text = "X";
                else btnFour.Text = "0";
                click = !click;
                btnFour.Enabled = false;
            };
            //
            // Fifth field
            //
            btnFive = new Button();
            btnFive.Size = new Size(100, 100);
            btnFive.Location = new Point(101, 101);
            btnFive.Font = new Font("Times New Roman", 28);
            btnFive.Click += (e, sender) =>
            {
                if (click) btnFive.Text = "X";
                else btnFive.Text = "0";
                click = !click;
                btnFive.Enabled = false;
            };
            //
            // Sixth field
            //
            btnSix = new Button();
            btnSix.Size = new Size(100, 100);
            btnSix.Location = new Point(201, 101);
            btnSix.Font = new Font("Times New Roman", 28);
            btnSix.Click += (e, sender) =>
            {
                if (click) btnSix.Text = "X";
                else btnSix.Text = "0";
                click = !click;
                btnSix.Enabled = false;
            };
            //
            // Seventh field
            //
            btnSeven = new Button();
            btnSeven.Size = new Size(100, 100);
            btnSeven.Location = new Point(0, 201);
            btnSeven.Font = new Font("Times New Roman", 28);
            btnSeven.Click += (e, sender) =>
            {
                if (click) btnSeven.Text = "X";
                else btnSeven.Text = "0";
                click = !click;
                btnSeven.Enabled = false;
            };
            //
            // Eighth field
            //
            btnEight = new Button();
            btnEight.Size = new Size(100, 100);
            btnEight.Location = new Point(101, 201);
            btnEight.Font = new Font("Times New Roman", 28);
            btnEight.Click += (e, sender) =>
            {
                if (click) btnEight.Text = "X";
                else btnEight.Text = "0";
                click = !click;
                btnEight.Enabled = false;
            };
            //
            // Ninth field
            //
            btnNine = new Button();
            btnNine.Size = new Size(100, 100);
            btnNine.Location = new Point(201, 201);
            btnNine.Font = new Font("Times New Roman", 28);
            btnNine.Click += (e, sender) =>
            {
                if (click) btnNine.Text = "X";
                else btnNine.Text = "0";
                click = !click;
                btnNine.Enabled = false;
            };

            this.Controls.Add(btnOne);
            this.Controls.Add(btnTwo);
            this.Controls.Add(btnThree);
            this.Controls.Add(btnFour);
            this.Controls.Add(btnSeven);
            this.Controls.Add(btnEight);
            this.Controls.Add(btnNine);
            this.Controls.Add(btnFive);
            this.Controls.Add(btnSix);
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

