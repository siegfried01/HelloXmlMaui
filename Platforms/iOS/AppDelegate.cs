using Foundation;

namespace HelloXamlMaui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiXamlMainProgram.CreateMauiApp();
}
