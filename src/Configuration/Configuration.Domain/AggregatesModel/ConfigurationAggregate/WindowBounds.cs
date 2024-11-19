namespace RegLabTestTask.Configuration.Domain.AggregatesModel.ConfigurationAggregate;

public class WindowBounds {
  public required string WindowName { get; set; }
  public required double Width { get; set; }
  public required double Height { get; set; }
  public required double X { get; set; }
  public required double Y { get; set; }
}