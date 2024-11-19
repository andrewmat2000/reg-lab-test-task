namespace RegLabTestTask.Configuration.Domain.SeedWork;

public interface IUnitOfWork {
  public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}