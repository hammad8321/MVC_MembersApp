using MemberApp_MVC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//  // Add services to the container.
//builder.Services.AddOpenApi();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataMyAppContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));



var app = builder.Build();  //

// Configure the HTTP request pipeline.


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}






    //if (app.Environment.IsDevelopment())
    //{
    //    app.MapOpenApi();
    //    app.MapScalarApiReference(options =>
    //    {
    //        options
    //        .WithTitle("Demo Email")
    //        .WithTheme(ScalarTheme.Mars)
    //        .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);

    //    });
    //    app.UseExceptionHandler("/Home/Error");
    //    app.UseHsts();

    //    //app.UseSwagger();
    //    //app.UseSwaggerUI(c =>
    //    //{
    //    //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo API V1");
    //    //    c.RoutePrefix = "swagger"; // Default route, can be omitted
    //    //});


    //}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



/*
 *      git remote set-url origin https://github.com/hammad8321/MVC_MembersApp.git
 * 
 * 
 *  git remote remove origin
     remote add origin https://github.com/hammad8321/MVC_MembersApp.git


git push -f origin main



Data Source=WS054-1\SQLExpress;Integrated Security=True;Trust Server Certificate=True



WS054-1\SQLExpress


dotnet ef database update
 * 
 * 
 */

