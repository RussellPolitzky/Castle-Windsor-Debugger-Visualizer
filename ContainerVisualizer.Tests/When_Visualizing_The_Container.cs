using System;
using System.IO;
using System.Text;
using System.Linq;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVisualizer.Tests
{
    /// <summary>
    /// Summary description for When_Visualizing_The_Congtainer
    /// </summary>
    [TestClass]
    public class When_Visualizing_The_Container
    {
        public When_Visualizing_The_Container()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void should_be_able_to_get_info_iro_geaph_nodes()
        {
            using (IWindsorContainer container = new WindsorContainer())
            {
                container.Register(Component.For<ITest>().ImplementedBy<Test>());

                GraphNode node = container.Kernel.GraphNodes.First();

                var componentModel = (ComponentModel) node;
                string serviceTypeName = componentModel.Service.ToString();
                string implementationType = componentModel.Implementation.ToString();

                Assert.AreEqual(serviceTypeName, "ContainerVisualizer.Tests.ITest");
                Assert.AreEqual(implementationType, "ContainerVisualizer.Tests.Test");
            }
        }

        
        [TestMethod]
        public void should_be_able_to_show_container_info_in_debugger_visualizer()
        {
            using (IWindsorContainer container = new WindsorContainer())
            {
                container.Register(
                    Component.For<ITest>().ImplementedBy<Test>().Named(typeof(Test) + "-Name"),
                    Component.For<IAmtesting>().ImplementedBy<Amtesting>().Named(typeof(Amtesting) + "-Name"),
                    Component.For<IWeTestQwert>().ImplementedBy<WeTestQwerty>().Named(typeof(WeTestQwerty) + "-Name"),
                    Component.For<IAmAComponent>().ImplementedBy<AmAComponent>().Named(typeof(AmAComponent) + "-Name"),
                    Component.For<IAmAService>().ImplementedBy<AmAService>().Named(typeof(AmAService) + "-Name")
                    );

                ContainerVisualizer.TestShowVisualizer(container);
            }
        }


        // This is a test 


        [TestMethod]
        public void should_be_able_to_build_a_container_dto()
        {
            using (IWindsorContainer container = new WindsorContainer())
            {
                container.Register(
                    Component.For<ITest>().ImplementedBy<Test>(),
                    Component.For<IAmtesting>().ImplementedBy<Amtesting>()
                    );

                IContainerDtofactory containerDtofactory = new ContainerDtofactory();

                WindsorContainerData dto = containerDtofactory.CreateDtoFor(container as WindsorContainer);

                Assert.IsNotNull(dto);
                Assert.IsNotNull(dto.Registrations);

                Assert.IsTrue(dto.Registrations.Any(reg => reg.InterfaceName.EndsWith(typeof(Test).Name)));
                Assert.IsTrue(dto.Registrations.Any(reg => reg.ImplementationName.EndsWith(typeof(Test).Name)));
            }
        }

    }
}
