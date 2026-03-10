using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp16.Shared;

namespace TestCRMApp16
{
  [Collection("CRMApp16")]
  public class TestMainLayout
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbAvatarModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownHeaderModule),
        typeof(IgbDropdownItemModule));
      var componentUnderTest = ctx.RenderComponent<MainLayout>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
