using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Castle.Windsor;
using ContainerVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(ContainerVisualizer.ContainerVisualizer),
    typeof(WindsorContrainerObjectSource),
    Target = typeof(WindsorContainer),
    Description = "Castle Windsor Container Regstration Visualizer")]

namespace ContainerVisualizer
{

    /// <summary>
    /// This is debugger side code .....
    /// </summary>
    public class ContainerVisualizer : DialogDebuggerVisualizer
    {

        /// <summary>
        /// </summary>
        /// <param name="windowService">An object of type <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService"/>, which provides methods your visualizer can use to display Windows forms, controls, and dialogs.</param>
        /// <param name="objectProvider">An object of type <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider"/>. This object provides communication from the debugger side of the visualizer to the object source (<see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource"/>) on the debuggee side.</param>
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            WindsorContainerData data = DeserializeDataIn(objectProvider.GetData());
            var containerViewForm = new ContainerViewForm(data);
            windowService.ShowDialog(containerViewForm);
        }


        /// <summary>
        /// Tests the show visualizer.
        /// </summary>
        /// <param name="objectToVisualize">The object to visualize.</param>
        public static void TestShowVisualizer(object objectToVisualize)
        {
            var visualizerHost = new VisualizerDevelopmentHost(
                objectToVisualize, 
                typeof(ContainerVisualizer), 
                typeof(WindsorContrainerObjectSource)
                );
            visualizerHost.ShowVisualizer();
        }


        /// <summary>
        /// Deserializes the data in.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns></returns>
        private WindsorContainerData DeserializeDataIn(Stream stream)
        {
            var formatter = new BinaryFormatter();
            return formatter.Deserialize(stream) as WindsorContainerData;   
        }

    }
}
