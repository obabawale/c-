// Fig. 6.8: RefOutTest.cs
// Demonstrating ref and out parameters.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class RefOutTest : System.Windows.Forms.Form
{
    private System.Windows.Forms.Button showOutputButton;
    private System.Windows.Forms.Label outputLabel;

    // Visual Studio .NET generated code

    // main entry point for application
    [STAThread]
    static void Main()
    {
        Application.Run(new RefOutTest());
    }

    // x passed by reference and method modifies
    // original variable's value
    void SquareRef(ref int x)
    {
        x = x * x;
    }

    // x passed as out parameter and method initializes
    // and modifies original variable's value
    void SquareOut(out int x)
    {
        x = 6;
        x = x * x;
    }

    // x passed by value and method cannot modify
    // original variable's value
    void Square(int x)
    {
        x = x * x;
    }

    private void showOutputButton_Click(object sender,
    System.EventArgs e)
    {
        int y = 5; // create new int and initialize to 5
        int z; // declare z, but do not initialize it

        // display original values of y and z
        outputLabel.Text = "Original value of y: " + y + "\n";
        outputLabel.Text +=
        "Original value of z: uninitialized\n\n";

        // pass y and z by reference
        SquareRef(ref y);
        SquareOut(out z);

        // display values of y and z after modified by methods
        // SquareRef and SquareOut
        outputLabel.Text +=
        "Value of y after SquareRef: " + y + "\n";
        outputLabel.Text +=
        "Value of z after SqaureOut: " + z + "\n\n";

        // pass y and z by value
        Square(y);
        Square(z);

        // display unchanged values of y and z
        outputLabel.Text += "Value of y after Square: " + y + "\n";
        outputLabel.Text += "Value of z after Square: " + z + "\n";


    } // end method showOutputButton_Click
}