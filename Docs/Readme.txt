Introduction:
-------------


This simple container visualizer shows all registered, interfaces in a container 
as well as their implementations and the names against which they're registered.

The visualizer also allows the user to filter the set of registered components
shown by name.


Installation:
-------------

Build the projects and copy all output in the xxx directory to the 
"...\ContainerVisualizer\ContainerVisualizer\bin\Debug" directory
to Visual Studio's debugger visualizer directory:

  $UserDirectory$\Documents\Visual Studio 2010\Visualizers\


Useage:
-------

* Set a brekpoint at a line of interest having a reference to the 
container.

* Run the appliction/test with debuggin on.
* Hover over the reference to the container.
* Click on the down arrow to the right of the magnifying glass and 
click on 'Castle Windsor Container Registration Visualizer'

The debugger visualizer dialog appears

* Type a seach string ingot the 'Search For:' text field
to narrow the results shown.




  