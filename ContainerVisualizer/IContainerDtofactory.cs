using Castle.Windsor;

namespace ContainerVisualizer
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContainerDtofactory
    {
        /// <summary>
        /// Creates the dto for.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        WindsorContainerData CreateDtoFor(WindsorContainer container);
    }
}