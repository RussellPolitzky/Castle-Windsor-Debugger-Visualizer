using System.Collections.Generic;
using Castle.Core;
using Castle.Windsor;

namespace ContainerVisualizer
{
    /// <summary>
    /// 
    /// </summary>
    public class ContainerDtofactory : IContainerDtofactory
    {
        /// <summary>
        /// Creates the dto for.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public WindsorContainerData CreateDtoFor(WindsorContainer container)
        {
            IList<RegistrationDto> registrations = new List<RegistrationDto>();

            if (container != null)
            {
                foreach (var node in container.Kernel.GraphNodes)
                {
                    var componentModel = (ComponentModel)node;

                    registrations.Add(new RegistrationDto
                                          {
                                              InterfaceName = componentModel.Service.ToString(), 
                                              Implementationname = componentModel.Implementation.ToString(),
                                              Name = componentModel.Name
                                          } );
                }
            }

            var dto = new WindsorContainerData { Registrations = registrations };

            return dto;
        }
    }
}