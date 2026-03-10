using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp16.Pages;
using CRMApp16.Financial;
using CRMApp16.CRMAIGeneratedData;

namespace TestCRMApp16
{
  [Collection("CRMApp16")]
  public class TestSupport
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbPieChartModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<ICRMAIGeneratedDataService>(sp => new MockCRMAIGeneratedDataService());
      var componentUnderTest = ctx.RenderComponent<Support>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
