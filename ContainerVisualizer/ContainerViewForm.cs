using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ContainerVisualizer
{
    public partial class ContainerViewForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private IList<DisplayRegistration> _displayRegistrations;


        /// <summary>
        /// 
        /// </summary>
        private readonly WindsorContainerData _windsorContainerData;


        /// <summary>
        /// 
        /// </summary>
        private string _filterString;


        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerViewForm"/> class.
        /// </summary>
        /// <param name="windsorContainerData">The windsor container data.</param>
        public ContainerViewForm(WindsorContainerData windsorContainerData) : this()
        {
            _windsorContainerData = windsorContainerData;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerViewForm"/> class.
        /// </summary>
        public ContainerViewForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the Load event of the ContainerViewForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ContainerViewForm_Load(object sender, EventArgs e)
        {
            Bind();
        }


        

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            filetStringTextBox.Text = string.Empty;
            _filterString = filetStringTextBox.Text;
            Bind();
        }


        /// <summary>
        /// Handles the TextChanged event of the filetStringTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _filterString = filetStringTextBox.Text;
            Bind();
        }


        #region helper methods and classes

        /// <summary>
        /// Binds this instance.
        /// </summary>
        private void Bind()
        {
            IList<DisplayRegistration> displayRegistrations = _windsorContainerData.Registrations
                .Select(registration => new DisplayRegistration
                                             {
                                                 InterfaceName = registration.InterfaceName,
                                                 ImplementationName = registration.ImplementationName,
                                                 Name = registration.Name
                                             })
                .OrderBy(reg => reg.InterfaceName + reg.ImplementationName + reg.Name)
                .ToList();

            if (!string.IsNullOrEmpty(_filterString))
            {
                displayRegistrations = 
                    displayRegistrations
                    .Where(dr => containsIgnoringCase(dr.ImplementationName, _filterString) ||
                                 containsIgnoringCase(dr.InterfaceName, _filterString) ||
                                 containsIgnoringCase(dr.Name, _filterString))
                    .ToList();
            }

            displayRegistrationBindingSource.ResetBindings(true);
            displayRegistrationBindingSource.DataSource = displayRegistrations;
        }

        #endregion

        private bool containsIgnoringCase(string stringToTest, string testString)
        {
            return stringToTest.ToUpper().Contains(testString.ToUpper());
        }

    }
}
