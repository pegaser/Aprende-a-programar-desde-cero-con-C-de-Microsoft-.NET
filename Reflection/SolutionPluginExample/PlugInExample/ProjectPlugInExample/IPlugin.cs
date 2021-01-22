namespace ProjectPlugInExample
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(Program application);
    }
}
