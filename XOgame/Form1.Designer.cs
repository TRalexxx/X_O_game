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
            //
            // Second field
            //
            btnTwo = new Button();
            btnTwo.Size = new Size(100, 100);
            btnTwo.Location = new Point(101, 0);
            btnTwo.Font = new Font("Times New Roman", 28);
            //
            // Third field
            //
            btnThree = new Button();
            btnThree.Size = new Size(100, 100);
            btnThree.Location = new Point(201, 0);
            btnThree.Font = new Font("Times New Roman", 28);
            //
            // Fourth field
            //
            btnFour = new Button();
            btnFour.Size = new Size(100, 100);
            btnFour.Location = new Point(0, 101);
            btnFour.Font = new Font("Times New Roman", 28);
            //
            // Fifth field
            //
            btnFive = new Button();
            btnFive.Size = new Size(100, 100);
            btnFive.Location = new Point(101, 101);
            btnFive.Font = new Font("Times New Roman", 28);
            //
            // Sixth field
            //
            btnSix = new Button();
            btnSix.Size = new Size(100, 100);
            btnSix.Location = new Point(201, 101);
            btnSix.Font = new Font("Times New Roman", 28);
            //
            // Seventh field
            //
            btnSeven = new Button();
            btnSeven.Size = new Size(100, 100);
            btnSeven.Location = new Point(0, 201);
            btnSeven.Font = new Font("Times New Roman", 28);
            //
            // Eighth field
            //
            btnEight = new Button();
            btnEight.Size = new Size(100, 100);
            btnEight.Location = new Point(101, 201);
            btnEight.Font = new Font("Times New Roman", 28);
            //
            // Ninth field
            //
            btnNine = new Button();
            btnNine.Size = new Size(100, 100);
            btnNine.Location = new Point(201, 201);
            btnNine.Font = new Font("Times New Roman", 28);

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

