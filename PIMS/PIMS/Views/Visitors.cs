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
    public partial class Visitors : Form
    {
        // Locals
        PVisitors Presenter;

        public ObjectListView VisitorsList { get { return this.olvVisitorsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Visitors()
        {
            InitializeComponent();
            Presenter = new PVisitors(this);
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

        private void refreshVisitors_Click(object sender, EventArgs e)
        {
            Presenter.RefreshVisitorsList();
        }

        private void deleteVisitor_Click(object sender, EventArgs e)
        {
            Presenter.DeleteVisitors();
        }

        private void addVisitor_Click(object sender, EventArgs e)
        {
            Presenter.AddVisitors();
        }
    }
}
