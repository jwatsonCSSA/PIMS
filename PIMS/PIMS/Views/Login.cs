﻿using PIMS.Presenters;
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
    public partial class frmLogin : Form
    {
        private PLogin Presenter;

        /// <summary>
        /// Initialize the presenter, passing the view in as a dependency.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            Presenter = new PLogin(this);
        }

        #region Properties
        public string ServerName { get { return this.txtServer.Text; } set { this.txtServer.Text = value; } }
        public string DatabaseName { get { return this.txtDatabase.Text; } set { this.txtDatabase.Text = value; } }
        public string Username { get { return this.txtUsername.Text; } set { this.txtUsername.Text = value; } }
        public string Password { get { return this.txtPassword.Text; } set { this.txtPassword.Text = value; } }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Raise a LoginClick event for the presenter to handle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Presenter.Login();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
