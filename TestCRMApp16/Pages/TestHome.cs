using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp16.Pages;
using CRMApp16.Financial;
using CRMApp16.NorthwindSwagger;
using CRMApp16.CRMApp;

namespace TestCRMApp16
{
  [Collection("CRMApp16")]
  public class TestHome
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbButtonModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbListModule),
        typeof(IgbChipModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      ctx.Services.AddScoped<ICRMAppService>(sp => new MockCRMAppService());
      var componentUnderTest = ctx.RenderComponent<Home>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
