#region Header
//+ <source name="DetectTemperatureEventArgs.cs" language="C#" begin="17-Feb-2021">
//+ <author href="mailto:j3d@tiletoons.com">J3d</author>
//+ <copyright year="2021">
//+ <holder web="https://tiletoons.com">Tiletoons!</holder>
//+ </copyright>
//+ <legalnotice>All rights reserved.</legalnotice>
//+ </source>
#endregion

#region References
using System;
#endregion

namespace Thermota.Core
{
    /// <summary>
    /// Provides data for the <see cref="Probe.DetectTemperature"/> event.
    /// </summary>
    public class DetectTemperatureEventArgs : EventArgs
    {
        #region Fields
        private int temperature;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the detected temperature.
        /// </summary>
        /// <value>
        /// The detected temperature in degrees Celsius.
        /// </value>
        public int Temperature
        {
            get { return temperature; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DetectTemperatureEventArgs"/> class with the specified
        /// temperature.
        /// </summary>
        /// <param name="temperature">
        /// The detected temperature in degrees Celsius.
        /// </param>
        public DetectTemperatureEventArgs(int temperature)
        {
            this.temperature = temperature;
        }
        #endregion
    }
}
