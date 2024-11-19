namespace RegLabTestTask.Configuration.Domain.SeedWork;

public interface IRepository<T> where T : IAggregate {
  public IUnitOfWork UnitOfWork { get; set; }

  public T Add(T item);
  public void Update(T item);
  public T Remove(T item);
}