
using RegLabTestTask.Configuration.Domain.AggregatesModel.UserAggregate;

namespace RegLabTestTask.Configuration.Domain.AggregatesModel.ConfigurationAggregate;

public class Configuration {
  public required string Version { get; set; }
  public required User User { get; set; }
  public required ColorScheme ColorScheme { get; set; }
  public required Font Font { get; set; }
  public required HotkeySet Hotkeys { get; set; }
  public required IEnumerable<WindowBounds> WindowBoundSet { get; set; }
}