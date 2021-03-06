﻿using DBI;
using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PProcedures
    {
        // Locals
        Views.Procedures View;
        PatientTable MyPatientsTable;
        ProceduresTable MyProceduresTable;
        List<Patient> MyPatientsList;

        public PProcedures(Views.Procedures view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyProceduresTable = new ProceduresTable();

            View.ProceduresList.SetObjects(MyProceduresTable.ReadList());
        }

        public void RefreshProceduresList()
        {
            ProceduresTable MyProceduresTable = new ProceduresTable();
            View.ProceduresList.SetObjects(MyProceduresTable.ReadList());
        }

        public void DeleteProcedures()
        {
            if (MessageBox.Show("Are you sure you want to delete the selected procedures?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (View.ProceduresList.SelectedObjects != null)
                {
                    foreach (var item in View.ProceduresList.SelectedObjects)
                    {
                        MyProceduresTable.ClearTableByProc(((DBI.Procedures)item).patientId, ((DBI.Procedures)item).startTime, ((DBI.Procedures)item).stopTime);
                    }
                }
                else
                {
                    MessageBox.Show("No procedures available.");
                }

                RefreshProceduresList();
            }
            else
            {
                return;
            }
        }

        public void AddProcedures()
        {
            NewProcedure MyNewProcedureForm = new NewProcedure();
            if (MyNewProcedureForm.ShowDialog() == DialogResult.OK)
            {
                RefreshProceduresList();
            }
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyProceduresTable = new ProceduresTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.ProceduresList.SetObjects(MyProceduresTable.ReadListById(p.patientId));
                else
                    View.ProceduresList.UpdateObjects(MyProceduresTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}