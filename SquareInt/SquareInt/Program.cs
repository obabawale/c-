 // Fig. 6.3: SquareInt.cs
 // Demonstrates a programmer-defined Square method.
 using System;
 using System.Drawing;
 using System.Collections;
 using System.ComponentModel;
 using System.Windows.Forms;
 using System.Data;

namespace SquareInt
{
    public class SquareInt : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;

        private System.ComponentModel.Container components = null;

        public SquareInt()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after
            // InitializeComponent call
            //
        }

        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        private void InitializeComponent()
        {
            this.calculateButton =
                new System.Windows.Forms.Button();
            this.outputLabel =
                new System.Windows.Forms.Label();

            //
            // calculateButton
            //
            this.calculateButton.Location =
            new System.Drawing.Point(24, 24);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size =
            new System.Drawing.Size(112, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Squares";
            this.calculateButton.Click +=
            new System.EventHandler(this.calculateButton_Click);

            //
            // outputLabel
            //
            this.outputLabel.Location =
            new System.Drawing.Point(10, 50);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size =
            new System.Drawing.Size(152, 160);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text =
            "";

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 205);
            this.Controls.AddRange(
            new System.Windows.Forms.Control[] {
            this.outputLabel,
            this.calculateButton
            }
            );
            this.Name = "SquareInt";
            this.Text = "SquareInt";
            this.ResumeLayout(false);
        }

        // Visual Studio .NET generated code
        
        [STAThread]
        static void Main()
        {
            Application.Run(new SquareInt());
        }

        // Square method definition
        int Square(int y)
        {
            return y * y; // return square of y
        } // end method Square

        private void calculateButton_Click(object sender,
        System.EventArgs e)
        {
            outputLabel.Text = "";

            // loop 10 times
            for (int counter = 1; counter <= 10; counter++)
            {
                // calculate square of counter and store in result
                int result = Square(counter);

                // append result to outputLabel
                outputLabel.Text += "The square of " + counter +
                " is " + result + "\n";
            }

        } // end method calculateButton_Click

    } // end of class SquareInt
}