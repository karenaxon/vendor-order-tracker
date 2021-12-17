using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Monday", "Every Monday morning", "435.78", "04/25/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string date = "06/25/2021";
      Order newOrder = new Order("Monday", "Every Monday morning", "435.78", date);
      string instanceDate = newOrder.Date;
      Assert.AreEqual(date, instanceDate);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrdersList()
    {
      List<Order> newList = new List<Order>{ };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(result, newList);
    }

  }
    
}