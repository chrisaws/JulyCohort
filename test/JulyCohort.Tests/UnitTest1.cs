using System;
using System.Reflection;
using Xunit;
using JulyCohort.Controllers;

namespace JulyCohort.Tests;
public class UnitTest1
{
    
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("July Cohort", returnValue.Value);
    }
    
    [Fact]
    public void Test1()
    {

    }
}