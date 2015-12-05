// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 4.4.1.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Workspace
{
    /// <summary>
    /// Storage for workspace context menu for pages.
    /// </summary>
    public abstract class WorkspacePageMenuBase : Storage
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the WorkspacePageMenuBase class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace.</param>
        public WorkspacePageMenuBase(KryptonWorkspace workspace)
        {
        }
        #endregion
    }
}
