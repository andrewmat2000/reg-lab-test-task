namespace RegLabTestTask.Configuration.Domain.Events;

public enum ConfigurationActionType {
  Create,
  Read,
  Update,
  Delete
}

public abstract class ConfigurationActionEvent {
  public abstract DateTime EventTime { get; set; }
  public abstract ConfigurationActionType EventType { get; }
}