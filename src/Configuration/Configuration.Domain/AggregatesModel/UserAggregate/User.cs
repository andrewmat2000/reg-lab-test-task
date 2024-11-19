using RegLabTestTask.Configuration.Domain.SeedWork;

namespace RegLabTestTask.Configuration.Domain.AggregatesModel.UserAggregate;

/// <summary>
/// Возможно я понял неправильно. Но судя по контексту настройки относяться к пользователям. Поэтому объектом конфигурирования будет пользователь.
/// </summary>
public class User : IAggregate {
  public string Identificator {
    get => string.Format("{0}_{1}_{2}", string.Join('_', FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries)),
                                        BirthDay.ToString("dd_MM_yyyy"),
                                        UniqueNumber);
  }

  public required string FullName { get; init; }
  public required DateOnly BirthDay { get; init; }
  public required Position Position { get; init; }
  public ulong UniqueNumber { get; set; }
}