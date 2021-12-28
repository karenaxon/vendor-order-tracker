using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorsList = new List<Vendor>{};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Items { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorsList.Add(this);
      Id = _vendorsList.Count;
      Items = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendorsList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorsList;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorsList[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Items.Add(order);
    }
  }
}