using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (animalTypeComboBox.SelectedIndex == 0)
            {
                Cat cat = new Cat("00001", new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year), "saartje", "high on catnip");
            }
            else if (animalTypeComboBox.SelectedIndex == 1)
            {
                Dog dog = new Dog("00001", new SimpleDate(25, 12, 1996), "Rex", new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));                
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
        }
    }
}
