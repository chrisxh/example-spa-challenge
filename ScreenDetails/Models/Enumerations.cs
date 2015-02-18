using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScreenDetails.Models
{
    /// <summary>
    /// Status Enumerations
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Field status is visibile
        /// </summary>
        Visible = 0,
        /// <summary>
        /// Field status is Hidden
        /// </summary>
        Hidden=1,
        /// <summary>
        /// Field status is disabled
        /// </summary>
        Disabled=2
    }
}