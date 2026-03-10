using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp16.Pages;

namespace TestCRMApp16
{
  [Collection("CRMApp16")]
  public class TestDeals
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
        typeof(IgbInputModule),
        typeof(IgbSelectModule),
        typeof(IgbButtonGroupModule),
        typeof(IgbToggleButtonModule));
      var componentUnderTest = ctx.RenderComponent<Deals>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
