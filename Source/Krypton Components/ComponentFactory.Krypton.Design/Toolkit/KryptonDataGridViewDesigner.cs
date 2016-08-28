using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace ComponentFactory.Krypton.Toolkit
{
    internal class KryptonDataGridViewDesigner : ControlDesigner
    {
		#region Identity
		/// <summary>
        /// Initialize a new instance of the KryptonWrapLabelDesigner class.
		/// </summary>
        public KryptonDataGridViewDesigner()
        {
            // The resizing handles around the control need to change depending on the
            // value of the AutoSize and AutoSizeMode properties. When in AutoSize you
            // do not get the resizing handles, otherwise you do.
            AutoResizeHandles = true;
        }            
		#endregion
    }
}
