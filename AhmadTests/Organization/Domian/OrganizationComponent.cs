using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Organization.Domian;

//    یک property به نام Name
//یک متد abstract به نام GetSalary()
//یک متد به نام Display() که اطلاعات را نمایش می‌دهد
public abstract class OrganizationComponent
{
    public string Name { get; set; }
    public long Salery { get; set; }

    public abstract long GetSalery();
    public abstract string Display();
}


public class Employee : OrganizationComponent
{
    public override string Display() => $"{Name} salary is {Salery}"; 
    public override long GetSalery() => Salery;
}

public class Department : OrganizationComponent
{
    private List<OrganizationComponent> _items = new List<OrganizationComponent>();

    public Department(string name)
    {
        Name = name;
        Salery = 0; // Menu's price is the sum of its items
    }

    public override string Display()
    {
        string res = "";
        foreach (var item in _items)
        {
            res += item.Display();
        }
        return res;
    }

    public override long GetSalery()
    {
        long res = 0;
        foreach (var item in _items)
        {
            res += item.GetSalery();
        }
        return res;
    }
}
