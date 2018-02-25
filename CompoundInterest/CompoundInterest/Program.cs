using System;
using System.Windows.Forms;
class Interest
    {
    static void Main( string[] args )
        {
            decimal amount, principal = ( decimal ) 1000.00;
            double rate = .05;
            string output;

            output = "Year\tAmount on deposit\n";

            for ( int year = 1; year <= 10; year++ )
                {
                     amount = principal *
                     ( decimal ) Math.Pow( 1.0 + rate, year );

                     output += year + "\t" +
                     String.Format( "{0:C}", amount ) + "\n";
                }

            MessageBox.Show( output, "Compound Interest",MessageBoxButtons.OK, MessageBoxIcon.Information );

        } // end method Main

    } // end class Interest