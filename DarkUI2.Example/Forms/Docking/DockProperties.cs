﻿using DarkUI2.Config;
using DarkUI2.Controls;
using DarkUI2.Docking;

namespace DarkUI2.Example.Docking
{
    public partial class DockProperties : DarkToolWindow
    {
        #region Constructor Region

        public DockProperties()
        {
            InitializeComponent();

            panel1.BackColor = panel2.BackColor = panel3.BackColor = System.Drawing.Color.Transparent;

            // Build dummy dropdown data
            cmbList.Items.Add(new DarkDropdownItem("Item1"));
            cmbList.Items.Add(new DarkDropdownItem("Item2"));
            cmbList.Items.Add(new DarkDropdownItem("Item3"));
            cmbList.Items.Add(new DarkDropdownItem("Item4"));
            cmbList.Items.Add(new DarkDropdownItem("Item5"));
            cmbList.Items.Add(new DarkDropdownItem("Item6"));

            cmbList.SelectedItemChanged += delegate { System.Console.WriteLine($"Item changed to {cmbList.SelectedItem.Text}"); };
        }

        #endregion
    }
}
