using System.Runtime.Serialization.Formatters.Binary;
using Castle.Core;
using Castle.Windsor;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ContainerVisualizer
{
    /// <summary>
    /// 
    /// </summary>
    public class WindsorContrainerObjectSource : VisualizerObjectSource
    {
        /// <summary>
        /// 
        /// </summary>
        private IContainerDtofactory _containerDtofactory;


        /// <summary>
        /// Initializes a new instance of the <see cref="WindsorContrainerObjectSource"/> class.
        /// </summary>
        public WindsorContrainerObjectSource()
        {
            _containerDtofactory = new ContainerDtofactory();
        }


        /// <summary>
        /// </summary>
        /// <param name="target">Object being visualized.</param>
        /// <param name="outgoingData">Outgoing data stream.</param>
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            WindsorContainerData dto = _containerDtofactory.CreateDtoFor(
                target as WindsorContainer
                );

            var formatter = new BinaryFormatter();
            formatter.Serialize(outgoingData, dto);
        }
    }
}