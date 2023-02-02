using CleanArchitecture.JT.Application.Common.Interfaces;

namespace CleanArchitecture.JT.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
