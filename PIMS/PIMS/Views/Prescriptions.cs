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
    public partial class Prescriptions : Form
    {
        // Locals
        PPrescriptions Presenter;

        public ObjectListView PrescriptionsList { get { return this.olvPrescriptionsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Prescriptions()
        {
            InitializeComponent();
            Presenter = new PPrescriptions(this);
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

        private void refreshPrescription_Click(object sender, EventArgs e)
        {
            Presenter.RefreshPrescriptionsList();
        }

        private void addPrescription_Click(object sender, EventArgs e)
        {
            Presenter.AddPrescriptions();
        }

        private void deletePrescription_Click(object sender, EventArgs e)
        {
            Presenter.DeletePrescriptions();
        }
    }
}
