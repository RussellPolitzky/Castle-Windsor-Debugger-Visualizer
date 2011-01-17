using System;
using System.Collections.Generic;

namespace ContainerVisualizer
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class WindsorContainerData
    {
        /// <summary>
        /// Gets or sets the Registrations.
        /// </summary>
        /// <value>The Registrations.</value>
        public IList<RegistrationDto> Registrations { get; set; }
    }
}