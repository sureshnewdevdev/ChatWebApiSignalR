using ChatWebApiSignalR.Hubs;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container, including SignalR services.
builder.Services.AddSignalR();

// Http request and Response there is 
// XMLHTTPREquest is secondary call
var app = builder.Build();


// Enable serving static files (such as index.html)
app.UseStaticFiles();
// Configure HTTP request pipeline (middleware).
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// Map SignalR hubs to a specific route.
app.MapHub<ChatHub>("/chathub");

app.Run();
