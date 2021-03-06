﻿using DBI.Tables;
using DBI.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBI
{
    public class EmergencyContactTable
    {
        public const string theTable = "emergencyContact";

        /// <summary>
        /// Delete all records from the table.
        /// </summary>
        public void ClearTable()
        {
            if (CountRows() == 0)
                return;

            string myCommand = "DELETE FROM " + theTable;
            QueryExecutor.ExecuteSqlNonQuery(myCommand);

            myCommand = "DBCC CHECKIDENT('" + theTable + "', RESEED, 0)";
            QueryExecutor.ExecuteSqlNonQuery(myCommand);
        }

        /// <summary>
        /// Delete any records with the EmergencyContactId specified.
        /// </summary>
        /// <param name="EmergencyContactId"></param>
        public void ClearTableById(int EmergencyContactId)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "DELETE FROM " + theTable +
                    " WHERE " +
                    "emergencyContactId = @emergencyContactId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@emergencyContactId", EmergencyContactId);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Get a count of all records in the table.
        /// </summary>
        /// <returns></returns>
        public int CountRows()
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "SELECT COUNT(*) FROM " + theTable;
                return QueryExecutor.ExecuteSqlQueryScalar(myQuery, myConnection);
            } // using
        } // CountRows

        /// <summary>
        /// Read all records from the table and save them in the ItemList
        /// as EmergencyContact objects.
        /// </summary>
        public List<EmergencyContact> ReadList()
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            string myQuery = "SELECT * FROM " + theTable;
            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int emergencyContactId = Convert.ToInt32(dr["emergencyContactId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string nameMiddle = dr["nameMiddle"].ToString();
                    string phone = dr["phone"].ToString();
                    string areaCode = dr["areaCode"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    EmergencyContact newEmergencyContact = new EmergencyContact();
                    newEmergencyContact.emergencyContactId = emergencyContactId;
                    newEmergencyContact.nameLast= nameLast;
                    newEmergencyContact.nameFirst = nameFirst;
                    newEmergencyContact.nameMiddle = nameMiddle;
                    newEmergencyContact.phone = phone;
                    newEmergencyContact.areaCode = areaCode;
                    newEmergencyContact.patientId = patientId;

                    // Need to add the patient name to the object
                    AddPatientName(newEmergencyContact);

                    contacts.Add(newEmergencyContact);
                } // for
            } // if

            return contacts;
        } // ReadList

        /// <summary>
        /// Read a sinlge record from the table and save the record in the
        /// ItemList as an EmergencyContact object.
        /// </summary>
        public List<EmergencyContact> ReadListById(int inputEmergencyContactId)
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            string myQuery = "SELECT * FROM " + theTable + " WHERE emergencyContactId = " + "'" + inputEmergencyContactId + "'";

            DataSet dsObject = QueryExecutor.ExecuteSqlQuery(myQuery);

            if (dsObject != null && dsObject.Tables[0].Rows.Count > 0)
            {
                DataTable dtObject = dsObject.Tables[0];    // get the DataTable reference once

                foreach (DataRow dr in dtObject.Rows)
                {
                    // extract all fields of the current row
                    int emergencyContactId = Convert.ToInt32(dr["emergencyContactId"]);
                    string nameLast = dr["nameLast"].ToString();
                    string nameFirst = dr["nameFirst"].ToString();
                    string nameMiddle = dr["nameMiddle"].ToString();
                    string phone = dr["phone"].ToString();
                    string areaCode = dr["areaCode"].ToString();
                    int patientId = Convert.ToInt32(dr["patientId"]);

                    // fill the ItemList
                    EmergencyContact newEmergencyContact = new EmergencyContact();
                    newEmergencyContact.emergencyContactId = emergencyContactId;
                    newEmergencyContact.nameLast = nameLast;
                    newEmergencyContact.nameFirst = nameFirst;
                    newEmergencyContact.nameMiddle = nameMiddle;
                    newEmergencyContact.phone = phone;
                    newEmergencyContact.areaCode = areaCode;
                    newEmergencyContact.patientId = patientId;

                    // Need to add the patient name to the object
                    AddPatientName(newEmergencyContact);

                    contacts.Add(newEmergencyContact);
                } // for
            } // if

            return contacts;
        } // ReadList

        /// <summary>
        /// Given a single EmergencyContact object, update the record correspnoding
        /// to the object's EmergencyContact id with any discrepancies in the EmergencyContact
        /// object.
        /// </summary>
        /// <param name="updatedEmergencyContact"></param>
        public void UpdateItem(EmergencyContact updatedEmergencyContact)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "UPDATE " + theTable +
                    " SET " +
                    "nameLast = @nameLast, " +
                    "nameFirst = @nameFirst, " +
                    "nameMiddle = @nameMiddle, " +
                    "phone = @phone, " +
                    "areaCode = @areaCode, " +
                    "patientId = @patientId " +
                    "WHERE " +
                    "emergencyContactId = @emergencyContactId";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@nameLast", updatedEmergencyContact.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", updatedEmergencyContact.nameFirst);
                myCommand.Parameters.AddWithValue("@nameMiddle", updatedEmergencyContact.nameMiddle);
                myCommand.Parameters.AddWithValue("@phone", updatedEmergencyContact.phone);
                myCommand.Parameters.AddWithValue("@areaCode", updatedEmergencyContact.areaCode);
                myCommand.Parameters.AddWithValue("@patientId", updatedEmergencyContact.patientId);
                myCommand.Parameters.AddWithValue("@emergencyContactId", updatedEmergencyContact.emergencyContactId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // UpdateItem

        /// <summary>
        /// Given a list of EmergencyContact objects, update their properties to the database
        /// by EmergencyContact id.
        /// </summary>
        public void UpdateList(List<EmergencyContact> contacts)
        {
            foreach (var EmergencyContact in contacts)
            {
                UpdateItem(EmergencyContact);
            }
        }

        /// <summary>
        /// Insert a single EmergencyContact record into the database.
        /// </summary>
        public void WriteItem(EmergencyContact newEmergencyContact)
        {
            using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
            {
                string myQuery = "INSERT INTO " + theTable +
                    "(nameLast, nameFirst, nameMiddle, phone, areaCode, patientId) " +
                    "VALUES (@nameLast, @nameFirst, @nameMiddle, @phone, @areaCode, @patientId)";

                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                myCommand.Parameters.AddWithValue("@emergencyContactId", newEmergencyContact.emergencyContactId);
                myCommand.Parameters.AddWithValue("@nameLast", newEmergencyContact.nameLast);
                myCommand.Parameters.AddWithValue("@nameFirst", newEmergencyContact.nameFirst);
                myCommand.Parameters.AddWithValue("@nameMiddle", newEmergencyContact.nameMiddle);
                myCommand.Parameters.AddWithValue("@phone", newEmergencyContact.phone);
                myCommand.Parameters.AddWithValue("@areaCode", newEmergencyContact.areaCode);
                myCommand.Parameters.AddWithValue("@patientId", newEmergencyContact.patientId);

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            } // using
        } // WriteItem

        /// <summary>
        /// Insert a list of EmergencyContact records into the database.
        /// </summary>
        public void WriteList(List<EmergencyContact> contacts)
        {
            foreach (var EmergencyContact in contacts)
            {
                WriteItem(EmergencyContact);
            } // foreach
        } // writelist

        /// <summary>
        /// Need to add the patient name to the object.
        /// </summary>
        /// <param name="newObject"></param>
        private void AddPatientName(dynamic newObject)
        {
            PatientTable MyPatientTable = new PatientTable();
            List<Patient> MyPatientsList = MyPatientTable.ReadListById(newObject.patientId);

            if (MyPatientsList.Count > 0)
            {
                newObject.name = MyPatientsList[0].nameFirst + " " + MyPatientsList[0].nameLast;
            }
        }
    }
}