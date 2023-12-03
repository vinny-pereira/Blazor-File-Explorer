namespace Blazor_File_Explorer.Data;

public abstract class DataAdaptor : IDataAdaptor
{
    public abstract IQueryable<string> Read(string root, object? options = null);

    public abstract Task<IQueryable<string>> ReadAsync(string root, object? options = null);

    public abstract void Update(object? options = null);

    public abstract Task UpdateAsync(object? options = null);

    public abstract string Create(object? options = null);

    public abstract Task<string> CreateAsync(object? options = null);

    public abstract void Delete(object? options = null);

    public abstract Task DeleteAsync(object? options = null);
}

public interface IDataAdaptor
{
    public IQueryable<string> Read(string root, object? options = null);
    public Task<IQueryable<string>> ReadAsync(string root, object? options = null);
    public void Update(object? options = null);
    public Task UpdateAsync(object? options = null);
    public string Create(object? options = null);
    public Task<string> CreateAsync(object? options = null);
    public void Delete(object? options = null);
    public Task DeleteAsync(object? options = null);
}