using Playground.Api.Controllers;
using Playground.Api.Models.PayloadModels;

namespace Playground.Api.Tests;

public class Test_DefaultValuesController
{

    public static List<object[]> TestData = new List<object[]>
    {
        new object[] { new DefaultModelsPayload{ Integer = 1, Float = 1.1f, Double = 1.1, Decimal = 1.1m, Boolean = true, String = "1" }, "Integer: 1, Float: 1.1, Double: 1.1, Decimal: 1.1, Boolean: True, String: 1" },
        new object[] { new DefaultModelsPayload{ String = "2" }, "Integer: 0, Float: 0, Double: 0, Decimal: 0, Boolean: False, String: 2"},
        new object[] { new DefaultModelsPayload{ }, "Integer: 0, Float: 0, Double: 0, Decimal: 0, Boolean: False, String: "},
    };

    [Theory, MemberData(nameof(TestData))]
    public void Post_ReturnsCorrectDefaultValues(DefaultModelsPayload payload, string expected)
    {
        // Arrange
        var controller = new DefaultValuesController();
        // Act
        var result = controller.Post(payload);
        // Assert
        Assert.Equal(expected, result);

    }
}

