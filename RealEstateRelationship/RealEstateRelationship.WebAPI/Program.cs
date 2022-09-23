using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Features.Events;
using RealEstateRelationship.Application.Persistence;
using RealEstateRelationship.Application.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(AnnouncementVm));
builder.Services.AddSingleton<IMapper, MappingProfile>();
builder.Services.AddSingleton<IAsyncAnnoucementRepository, AnnouncementRepository>();

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
