﻿using System;
using System.Windows.Forms;

class sum
{
    static void Main(string[] args)
    {
        int sum = 0;
            for ( int number = 2; number <= 100; number += 2 )
            sum += number;
            MessageBox.Show( "The sum is " + sum, "Sum Even Integers from 2 to 100", MessageBoxButtons.OK, MessageBoxIcon.Information );

    } // end method Main

} // end class Sum




