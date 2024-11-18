using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MOOCPediaApp;
using Blazorise.Icons.FontAwesome;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOidcAuthentication(options =>
{
	//builder.Configuration.Bind("Auth0", options.ProviderOptions);
	options.ProviderOptions.Authority = "https://dev-gh7hfiov68zh1phc.us.auth0.com";
	options.ProviderOptions.ClientId = "lMXkjd6tnOn4T51wFk7giyf4qQDHA5U7";
	options.ProviderOptions.ResponseType = "code";
});


builder.Services.AddRadzenComponents();
builder.Services.AddFontAwesomeIcons();

await builder.Build().RunAsync();
