﻿using BrightIdeasSoftware;
using PIMS.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Views
{
    public partial class EmergencyContacts : Form
    {
        // Locals
        PEmergencyContacts Presenter;

        public ObjectListView EmergencyContactsList { get { return this.ovlEmergencyContactsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public EmergencyContacts()
        {
            InitializeComponent();
            Presenter = new PEmergencyContacts(this);
            Initialize();
        }

        private void Initialize()
        {
            Presenter.PopulatePatientsList();
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            Presenter.SearchPatients();
        }

        private void refreshEmergencyContacts_Click(object sender, EventArgs e)
        {
            Presenter.RefreshEmergencyContactsList();
        }
    }
}
