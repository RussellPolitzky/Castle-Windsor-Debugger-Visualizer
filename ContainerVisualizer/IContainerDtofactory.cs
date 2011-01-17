using Castle.Windsor;

namespace ContainerVisualizer
{
    /// <summary>
    /// Interface for a simple service which creates
    /// about the graph nodes in a Windsor Container.
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