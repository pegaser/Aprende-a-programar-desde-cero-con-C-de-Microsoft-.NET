namespace PlugInExampleApp
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(PlugInExampleApp.Program application);
    }
}
