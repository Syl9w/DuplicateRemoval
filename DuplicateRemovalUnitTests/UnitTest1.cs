using System;
using System.Collections.Generic;
using DuplicateRemoval;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicateRemovalUnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestDuplicateRemovalWithDuplicates()
    {
        //arrange
        Operations operations = new Operations();
        List<IO> expectedData = new List<IO>
            {
                new IO{UnixTimeStamp=1615560000, Voltage=1},
                new IO{UnixTimeStamp=16155600010, Voltage=0},
                new IO{UnixTimeStamp=16155600014, Voltage=1},
            };
        //act
        List<IO> testData = operations.RemoveDuplicates(new List<IO>{
                new IO{UnixTimeStamp=1615560000, Voltage=1},
                new IO{UnixTimeStamp=1615560005, Voltage=1},
                new IO{UnixTimeStamp=1615560007, Voltage=1},
                new IO{UnixTimeStamp=16155600010, Voltage=0},
                new IO{UnixTimeStamp=16155600014, Voltage=1},
            });
        //Operations.PrintSignals(testData);
        //asserts
        for (int i = 0; i < testData.Count; i++)
        {
            Assert.AreEqual(expectedData[i].UnixTimeStamp, testData[i].UnixTimeStamp);
        }

    }

    [TestMethod]
    public void TestDuplicateRemovalWithAllDuplicates()
    {
        //arrange
        Operations operations = new Operations();
        List<IO> expectedData = new List<IO>
            {
                new IO{UnixTimeStamp=1615560000, Voltage=1},

            };
        //act
        List<IO> testData = operations.RemoveDuplicates(new List<IO>{
                new IO{UnixTimeStamp=1615560000, Voltage=1},
                new IO{UnixTimeStamp=1615560005, Voltage=1},
                new IO{UnixTimeStamp=1615560007, Voltage=1},
                new IO{UnixTimeStamp=16155600010, Voltage=1},
                new IO{UnixTimeStamp=16155600014, Voltage=1},
            });
        //Operations.PrintSignals(testData);
        //asserts
        for (int i = 0; i < testData.Count; i++)
        {
            Assert.AreEqual(expectedData[i].UnixTimeStamp, testData[i].UnixTimeStamp);
        }
    }

    [TestMethod]
    public void TestDuplicateRemovalWithNoDuplicate()
    {
        //arrange
        Operations operations = new Operations();
        List<IO> expectedData = new List<IO>
            {
                new IO{UnixTimeStamp=1615560000, Voltage=1},
                new IO{UnixTimeStamp=1615560005, Voltage=0},
                new IO{UnixTimeStamp=1615560007, Voltage=1},
                new IO{UnixTimeStamp=1615560010, Voltage=0},
                new IO{UnixTimeStamp=1615560014, Voltage=1},

            };
        //act
        List<IO> testData = operations.RemoveDuplicates(new List<IO>{
                new IO{UnixTimeStamp=1615560000, Voltage=1},
                new IO{UnixTimeStamp=1615560005, Voltage=0},
                new IO{UnixTimeStamp=1615560007, Voltage=1},
                new IO{UnixTimeStamp=1615560010, Voltage=0},
                new IO{UnixTimeStamp=1615560014, Voltage=1},
            });
       
        //asserts
        for (int i = 0; i < testData.Count; i++)
        {
            Assert.AreEqual(expectedData[i].UnixTimeStamp, testData[i].UnixTimeStamp);
        }
    }
}