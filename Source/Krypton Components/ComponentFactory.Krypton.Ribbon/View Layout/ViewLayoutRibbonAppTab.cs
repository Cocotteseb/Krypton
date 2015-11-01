// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 4.4.0.2 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Layout area for the application tab.
	/// </summary>
    internal class ViewLayoutRibbonAppTab : ViewLayoutDocker
    {
        #region Static Fields
        private static bool _usageShown = false;
        private static string _monitorId = "CFPLKS";
        private static string _licenseParameters = @"<LicenseParameters><RSAKeyValue><Modulus>2QVQ7gvGIKeN0Z/2gJzEnCnoE0pub4Lc61wiPi83+zhE1jjeeiA9D/mLpM3/u+k5DOqllaUKc6bK1jy1t0FCeBzEoH8YEmsxKVXtUUFLq52jYPPEc/gHysxhq3gA1yotOsOfXfhpWhSRJVtcPW4LpFfe3ljwcou8B0q+7yQkfVk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue><DesignSignature>XhiqhrSS4tTJlHf7xRQlgvt/0EBmS4Z1mD7QckhItcdN1G4Pqt7T4yUEk9Cb7EB6aaL0Dz1pibk6kgbcEDtuUzHshJba0jVxQztRN5uO+O3NCFFUe8V08MMGiIhUvUlMTabpsPWO3Zt2GJtp6SscjT+7YKZ6QLa8PvI2pVZrLKI=</DesignSignature><RuntimeSignature>DagPmrsazrCol/DNay/fdGDFLdun4DrZezFnGDxdeRTMr7Nxyag9lsy7REfgXMY6jvSYmpGa1QnItJdVzLbywH605EfPG+5EiQ6Ts3If6cQuNe/Xy42OhFqiKUsdo7v+l3ug3yJuuoqyVUfAUtK508bg0QuUXDwALkHvJWkf2u0=</RuntimeSignature></LicenseParameters>";
        #endregion

        #region Instance Fields
        private KryptonRibbon _ribbon;
        private ViewDrawRibbonAppTab _appTab;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutRibbonAppTab class.
		/// </summary>
        /// <param name="ribbon">Owning control instance.</param>
        public ViewLayoutRibbonAppTab(KryptonRibbon ribbon)
        {
            Debug.Assert(ribbon != null);
            _ribbon = ribbon;

            _appTab = new ViewDrawRibbonAppTab(ribbon);

            // Dock it against the appropriate edge
            Add(_appTab, ViewDockStyle.Bottom);
            Add(new ViewLayoutSeparator(1), ViewDockStyle.Left);
        }

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewLayoutRibbonAppTab:" + Id;
		}
		#endregion

        #region AppTab
        /// <summary>
        /// Gets the view element that represents the button.
        /// </summary>
        public ViewDrawRibbonAppTab AppTab
        {
            get { return _appTab; }
        }
        #endregion
    }
}
