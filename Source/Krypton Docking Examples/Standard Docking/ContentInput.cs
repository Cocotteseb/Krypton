﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Version 4.4.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Windows.Forms;

namespace StandardDocking
{
    public partial class ContentInput : UserControl
    {
        public ContentInput()
        {
            InitializeComponent();
        }

        private void kryptonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Only interested in left mouse down
            if (e.Button == MouseButtons.Left)
            {
                // If the content does not have the focus then give it focus now
                if (!ContainsFocus)
                    kryptonPanel.SelectNextControl(this, true, true, true, false);
            }
        }
    }
}
