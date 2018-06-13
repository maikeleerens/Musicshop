﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circustrein.Models;

namespace Circustrein
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<Animal> AnimalList;
        public Form()
        {
            InitializeComponent();
            AnimalList = new List<Animal>();
            combo_animalSize.DataSource = Enum.GetValues(typeof(Models.Size));
        }

        private void btn_addAnimal_Click(object sender, EventArgs e)
        {
            for (int i=0; i<Convert.ToInt32(num_amount.Value); i++)
            {
                AnimalList.Add(new Animal(cb_iscarnivore.Checked, (Models.Size)combo_animalSize.SelectedItem));
            }
            lb_selectedAnimals.Items.Clear();

            foreach (Animal animal in AnimalList)
            {
                lb_selectedAnimals.Items.Add(animal);
            }
        }
    }
}