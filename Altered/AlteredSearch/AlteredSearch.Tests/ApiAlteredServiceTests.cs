using AlteredSearch.Interface;
using AlteredSearch.Models;
using AlteredSearch.Services;
using Moq;
using Xunit;

namespace AlteredSearch.Tests.Services;

public class ApiAlteredServiceTests
{
    [Fact]
    public async Task GetFactionsAsync_ShouldReturnFactions_WhenApiReturnsData()
    {
        // Arrange
        var mockApi = new Mock<IAlteredApi>();
        mockApi.Setup(api => api.GetFactionsAsync())
               .ReturnsAsync(new List<Faction>
               {
                   new() { Name = "Faction A" },
                   new() { Name = "Faction B" }
               });

        var service = new ApiAlteredService(mockApi.Object);

        // Act
        var result = await service.ListAllFactions();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Contains(result, f => f == "Faction A");
        Assert.Contains(result, f => f == "Faction B");
    }
}
