using System.Threading.Tasks;
using CLoudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class UnitTest1
{
    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200()
    {
        // Arrange 
        var sut = new UsersController();
        
        // Act 
        var res = (OkObjectResult) await sut.Get();

        // Assert
        res.StatusCode.Should().Be(200);
    }
}