﻿namespace PIMSTests.ModelTableTests
{
    // Save this for future refactoring
    //[TestFixture]
    class crudTests<table, model>
    {
        //table myTable;
        //List<model> myList;
        //List<model> myList2;
        //ICompare<model> Comparer;

        //public void PassData(table _myTable, List<model> _myList, List<model> _myList2, ICompare<model> _Comparer)
        //{
        //    myList = _myList;
        //    myList2 = _myList2;
        //    myTable = _myTable;
        //    Comparer = _Comparer;
        //}


        //[SetUp]
        //public void SetupTest()
        //{
        //    // Establish the connection string
        //    ConnectionsManager.SQLServerConnectionString = "Data Source=CSSA-JEB\\SQLEXPRESS;Initial Catalog=" +
        //        "PIMSTest;Integrated Security=False;User Id=jwatson;Password=test;MultipleActiveResultSets=True;";

        //    // Establish a connection and close at the end of using

        //    using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
        //    {
        //        // Clear the table before any tests occur
        //        string clearQuery = "DELETE FROM insurance";
        //        QueryExecutor.ExecuteSqlNonQuery(clearQuery, myConnection);

        //        // Populate the table with known values before tests occur
        //        string populationQuery1 = "INSERT INTO insurance (insuranceId, insuranceCarrier, accountNumber, groupNumber, patientId) " +
        //            "VALUES (1, 'A', '1', '1', 1)";
        //        string populationQuery2 = "INSERT INTO insurance (insuranceId, insuranceCarrier, accountNumber, groupNumber, patientId) " +
        //            "VALUES (2, 'B', '2', '2', 2)";
        //        string populationQuery3 = "INSERT INTO insurance (insuranceId, insuranceCarrier, accountNumber, groupNumber, patientId) " +
        //            "VALUES (3, 'C', '3', '3', 3)";

        //        QueryExecutor.ExecuteSqlNonQuery(populationQuery1, myConnection);
        //        QueryExecutor.ExecuteSqlNonQuery(populationQuery2, myConnection);
        //        QueryExecutor.ExecuteSqlNonQuery(populationQuery3, myConnection);
        //    }
        //}

        //[Test]
        //public void ShouldReadList()
        //{
        //    // Read from a pre-populated test database and compare results.
        //    myTable.ReadList();

        //    int i = 0;

        //    foreach (var item in myTable.ItemList)
        //    {
        //        Comparer.Compare(item, myTable.ItemList[i]);
        //        i++;
        //    }
        //}

        //[Test]
        //public void ShouldReadListById()
        //{
        //    // Read from a pre-populated test database and compare results.
        //    myTable.ReadListById(1);
        //    Comparer.Compare(myTable.ItemList[0], myList[0]);
        //}

        //[Test]
        //public void ShouldClearTable()
        //{
        //    // clear the table and then get a count. compare count to zero.
        //    myTable.ClearTable();
        //    int recordCount = myTable.CountRows();
        //    Assert.That(recordCount, Is.EqualTo(0));
        //}

        //[Test]
        //public void ShouldClearTableById()
        //{
        //    // clear the table by id = 1. Now check for count = 2 and read
        //    // by id = 1 and check for itemlist.count = 0.
        //    myTable.ClearTableById(1);
        //    int recordCount = myTable.CountRows();
        //    myTable.ReadListById(1);
        //    int missingRecordCount = myTable.ItemList.Count;
        //    Assert.That(recordCount, Is.EqualTo(2));
        //    Assert.That(missingRecordCount, Is.EqualTo(0));
        //}

        //[Test]
        //public void ShouldWriteList()
        //{
        //    // Need to clear the table first
        //    myTable.ClearTable();

        //    // Write some records to the table then retrieve them using previously tested
        //    // read methods. Compare with original records.
        //    myTable.ItemList = myList;
        //    myTable.WriteList();
        //    myTable.ReadList();

        //    int i = 0;

        //    foreach (var item in myTable.ItemList)
        //    {
        //        Comparer.Compare(item, myTable.ItemList[i]);
        //        i++;
        //    }
        //}

        //[Test]
        //public void ShouldWriteItem()
        //{
        //    // Need to clear the table first
        //    myTable.ClearTable();

        //    // Write a record to the table then retrieve it using previously tested
        //    // read methods. Compare with original record.
        //    myTable.WriteItem(myList[0]);
        //    myTable.ReadList();
        //    Comparer.Compare(myTable.ItemList[0], myList[0]);
        //}

        //[Test]
        //public void ShouldUpdateList()
        //{
        //    myList.Clear();

        //    myTable.ItemList = myList2;
        //    myTable.UpdateList();

        //    // Now read the table back out and compare to myList
        //    myTable.ReadList();

        //    int i = 0;

        //    foreach (var item in myTable.ItemList)
        //    {
        //        Comparer.Compare(item, myList2[i]);
        //        i++;
        //    }

        //}

        //[Test]
        //public void ShouldUpdateItem()
        //{
        //    // Update the table with the updated admission (id = 1)
        //    myTable.UpdateItem(myList2[0]);

        //    // Now read the admission back out and compare it to the updatedAdmission above.
        //    myTable.ReadListById(4);
        //    Comparer.Compare(myTable.ItemList[0], myList2[0]);
        //}

        //[Test]
        //public void ShouldCountRows()
        //{
        //    // get a count of the records in the table and compare to known value (3)
        //    int recordCount = myTable.CountRows();
        //    Assert.That(recordCount, Is.EqualTo(3));
        //}

        //[TearDown]
        //public void TearDownTests()
        //{
        //    myTable = null;
        //    myList = null;
        //}
    }
}
