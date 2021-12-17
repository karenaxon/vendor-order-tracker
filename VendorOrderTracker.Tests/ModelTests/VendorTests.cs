using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sweet Pastries", "Shop on Main Street");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Sweet Pastries";
      Vendor newVendor = new Vendor(name, "Shop on Main Street");
      string instanceName = newVendor.Name;
      Assert.AreEqual(name, instanceName);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      Vendor newVendor1 = new Vendor("Sweet Pastries", "Shop on Main Street");
      Vendor newVendor2 = new Vendor("Yummy Goods", "A place to eat good");
      int result = newVendor2.Id;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorsList()
    {
      Vendor newVendor1 = new Vendor("Sweet Pastries", "Shop on Main Street");
      Vendor newVendor2 = new Vendor("Yummy Goods", "A place to eat good");
      List<Vendor> testList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> vendorsList = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorsList, testList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Sweet Pastries", "Shop on Main Street");
      Vendor newVendor2 = new Vendor("Yummy Goods", "A place to eat good");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(result, newVendor2);
    }

  }
}