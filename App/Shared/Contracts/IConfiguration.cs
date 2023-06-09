namespace AutoTrack.App.Shared.Contracts;


public interface IConfiguration<T>
{
    void Configure(T arg);
}
