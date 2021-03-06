﻿namespace PIMS.Views
{
    partial class Admissions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olvAdmissionsList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DischargeTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Facility = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Floor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Room = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Bed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.refreshAdmissions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvAdmissionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvAdmissionsList
            // 
            this.olvAdmissionsList.AllColumns.Add(this.PatientID);
            this.olvAdmissionsList.AllColumns.Add(this.PatientName);
            this.olvAdmissionsList.AllColumns.Add(this.AdmissionTime);
            this.olvAdmissionsList.AllColumns.Add(this.DischargeTime);
            this.olvAdmissionsList.AllColumns.Add(this.AdmissionReason);
            this.olvAdmissionsList.AllColumns.Add(this.Facility);
            this.olvAdmissionsList.AllColumns.Add(this.Floor);
            this.olvAdmissionsList.AllColumns.Add(this.Room);
            this.olvAdmissionsList.AllColumns.Add(this.Bed);
            this.olvAdmissionsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvAdmissionsList.CellEditUseWholeCell = false;
            this.olvAdmissionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.PatientName,
            this.AdmissionTime,
            this.DischargeTime,
            this.AdmissionReason,
            this.Facility,
            this.Floor,
            this.Room,
            this.Bed});
            this.olvAdmissionsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAdmissionsList.FullRowSelect = true;
            this.olvAdmissionsList.GridLines = true;
            this.olvAdmissionsList.HideSelection = false;
            this.olvAdmissionsList.Location = new System.Drawing.Point(28, 55);
            this.olvAdmissionsList.Margin = new System.Windows.Forms.Padding(2);
            this.olvAdmissionsList.Name = "olvAdmissionsList";
            this.olvAdmissionsList.ShowGroups = false;
            this.olvAdmissionsList.Size = new System.Drawing.Size(686, 309);
            this.olvAdmissionsList.TabIndex = 0;
            this.olvAdmissionsList.UseCompatibleStateImageBehavior = false;
            this.olvAdmissionsList.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "name";
            this.PatientName.Text = "Name";
            this.PatientName.Width = 168;
            // 
            // AdmissionTime
            // 
            this.AdmissionTime.AspectName = "admissionTime";
            this.AdmissionTime.Text = "Admission Time";
            this.AdmissionTime.Width = 120;
            // 
            // DischargeTime
            // 
            this.DischargeTime.AspectName = "dischargeTime";
            this.DischargeTime.Text = "Discharge Time";
            this.DischargeTime.Width = 120;
            // 
            // AdmissionReason
            // 
            this.AdmissionReason.AspectName = "admissionReason";
            this.AdmissionReason.Text = "Admission Reason";
            this.AdmissionReason.Width = 150;
            // 
            // Facility
            // 
            this.Facility.AspectName = "facility";
            this.Facility.Text = "Facility";
            // 
            // Floor
            // 
            this.Floor.AspectName = "floor";
            this.Floor.Text = "Floor";
            // 
            // Room
            // 
            this.Room.AspectName = "roomNumber";
            this.Room.Text = "Room";
            this.Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bed
            // 
            this.Bed.AspectName = "bedNumber";
            this.Bed.Text = "Bed";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatient.Location = new System.Drawing.Point(28, 26);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(97, 25);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(130, 29);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(270, 20);
            this.txtPatientSearch.TabIndex = 2;
            // 
            // refreshAdmissions
            // 
            this.refreshAdmissions.Location = new System.Drawing.Point(639, 26);
            this.refreshAdmissions.Name = "refreshAdmissions";
            this.refreshAdmissions.Size = new System.Drawing.Size(75, 23);
            this.refreshAdmissions.TabIndex = 3;
            this.refreshAdmissions.Text = "Refresh";
            this.refreshAdmissions.UseVisualStyleBackColor = true;
            this.refreshAdmissions.Click += new System.EventHandler(this.refreshAdmissions_Click);
            // 
            // Admissions
            // 
            this.AcceptButton = this.btnSearchPatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.refreshAdmissions);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.olvAdmissionsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admissions";
            this.Text = "Admissions";
            ((System.ComponentModel.ISupportInitialize)(this.olvAdmissionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvAdmissionsList;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn AdmissionTime;
        private BrightIdeasSoftware.OLVColumn DischargeTime;
        private BrightIdeasSoftware.OLVColumn AdmissionReason;
        private BrightIdeasSoftware.OLVColumn Facility;
        private BrightIdeasSoftware.OLVColumn Floor;
        private BrightIdeasSoftware.OLVColumn Room;
        private BrightIdeasSoftware.OLVColumn Bed;
        private BrightIdeasSoftware.OLVColumn PatientName;
        private System.Windows.Forms.Button refreshAdmissions;
    }
}