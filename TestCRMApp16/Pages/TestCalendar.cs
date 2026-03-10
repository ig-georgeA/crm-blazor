using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp16.Pages;

namespace TestCRMApp16
{
  [Collection("CRMApp16")]
  public class TestCalendar
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Calendar>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
