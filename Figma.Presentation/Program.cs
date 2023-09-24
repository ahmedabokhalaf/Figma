using Figma.Core.Interfaces;
using Figma.Ef.Data;
using Figma.Ef.Repositories;
using Figma.Presentation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
});
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IApplicationFormServices, ApplicationFormServices>();
builder.Services.AddScoped<IEducationServices, EducationServices>();
builder.Services.AddScoped<IFigmaProgramServices, FigmaProgramServices>();
builder.Services.AddScoped<IPersonalInfoServices, PersonalInfoServices>();
builder.Services.AddScoped<IProfileServices, ProfileServices>();
builder.Services.AddScoped<IQuestionsServices, QuestionsServices>();
builder.Services.AddScoped<IStageServices, StageServices>();
builder.Services.AddScoped<IWorkExperienceServices, WorkExperienceServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
