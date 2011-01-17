using System;

namespace ContainerVisualizer
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class RegistrationDto
    {
        /// <summary>
        /// Gets or sets the name of the interface.
        /// </summary>
        /// <value>The name of the interface.</value>
        public string InterfaceName { get; set; }

        /// <summary>
        /// Gets or sets the implementationname.
        /// </summary>
        /// <value>The implementationname.</value>
        public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}