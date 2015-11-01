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
	/// Layout area for the application button.
	/// </summary>
    internal class ViewLayoutRibbonAppButton : ViewLayoutDocker
    {
        #region Static Fields
        private static readonly int APPBUTTON_WIDTH = 39;
        private static readonly int APPBUTTON_GAP = 4;
        private static bool _usageShown = false;
        private static string _monitorId = "CFPLKS";
        private static string _licenseParameters = @"<LicenseParameters><RSAKeyValue><Modulus>2QVQ7gvGIKeN0Z/2gJzEnCnoE0pub4Lc61wiPi83+zhE1jjeeiA9D/mLpM3/u+k5DOqllaUKc6bK1jy1t0FCeBzEoH8YEmsxKVXtUUFLq52jYPPEc/gHysxhq3gA1yotOsOfXfhpWhSRJVtcPW4LpFfe3ljwcou8B0q+7yQkfVk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue><DesignSignature>XhiqhrSS4tTJlHf7xRQlgvt/0EBmS4Z1mD7QckhItcdN1G4Pqt7T4yUEk9Cb7EB6aaL0Dz1pibk6kgbcEDtuUzHshJba0jVxQztRN5uO+O3NCFFUe8V08MMGiIhUvUlMTabpsPWO3Zt2GJtp6SscjT+7YKZ6QLa8PvI2pVZrLKI=</DesignSignature><RuntimeSignature>DagPmrsazrCol/DNay/fdGDFLdun4DrZezFnGDxdeRTMr7Nxyag9lsy7REfgXMY6jvSYmpGa1QnItJdVzLbywH605EfPG+5EiQ6Ts3If6cQuNe/Xy42OhFqiKUsdo7v+l3ug3yJuuoqyVUfAUtK508bg0QuUXDwALkHvJWkf2u0=</RuntimeSignature></LicenseParameters>";
        #endregion

        #region Instance Fields
        private KryptonRibbon _ribbon;
        private KryptonForm _ownerForm;
        private ViewLayoutRibbonSeparator _separator;
        private ViewDrawRibbonAppButton _appButton;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutRibbonAppButton class.
		/// </summary>
        /// <param name="ribbon">Owning control instance.</param>
        /// <param name="bottomHalf">Scroller orientation.</param>
        public ViewLayoutRibbonAppButton(KryptonRibbon ribbon,
                                         bool bottomHalf)
        {
            Debug.Assert(ribbon != null);
            _ribbon = ribbon;

            _appButton = new ViewDrawRibbonAppButton(ribbon, bottomHalf);
            _separator = new ViewLayoutRibbonSeparator(APPBUTTON_GAP, true);

            // Dock it against the appropriate edge
            Add(_appButton, (bottomHalf ? ViewDockStyle.Top : ViewDockStyle.Bottom));

            // Place a separator between edge of control and start of the app button
            Add(_separator, ViewDockStyle.Left);

            // Use filler placeholder to force size to that required
            Add(new ViewLayoutRibbonSeparator(APPBUTTON_WIDTH, APPBUTTON_GAP, true), ViewDockStyle.Fill);
        }

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewLayoutRibbonAppButton:" + Id;
		}
		#endregion

        #region OwnerForm
        /// <summary>
        /// Gets and sets the owning form instance.
        /// </summary>
        public KryptonForm OwnerForm
        {
            get { return _ownerForm; }
            set { _ownerForm = value; }
        }
        #endregion

        #region Visible
        /// <summary>
        /// Gets and sets the visible state of the element.
        /// </summary>
        public override bool Visible
        {
            get 
            {
                if (_ownerForm == null)
                    return base.Visible;
                else
                    return (_ribbon.Visible && base.Visible);
            }

            set { base.Visible = value; }
        }
        #endregion

        #region AppButton
        /// <summary>
        /// Gets the view element that represents the button.
        /// </summary>
        public ViewDrawRibbonAppButton AppButton
        {
            get { return _appButton; }
        }
        #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            UpdateSeparatorSize();
            return base.GetPreferredSize(context);
        }

        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            UpdateSeparatorSize();
            base.Layout(context);
        }
        #endregion

        #region Implementation
        private void UpdateSeparatorSize()
        {
            Size separatorSize = new Size(APPBUTTON_GAP, APPBUTTON_GAP);

            // Do we need to add on extra sizing to the separator?
            if (_ownerForm != null)
            {
                // Get the actual owning window border settings
                Padding borders = _ownerForm.RealWindowBorders;

                // Add the left border side to the sizing
                separatorSize.Width += borders.Left;
            }

            _separator.SeparatorSize = separatorSize;
        }
        #endregion
    }
}
