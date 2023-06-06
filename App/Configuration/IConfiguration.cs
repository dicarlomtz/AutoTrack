namespace AutoTrack.App.Configuration;

public interface IConfiguration<T>
{
    void Configure(T arg);
}
