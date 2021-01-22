namespace PlugInExample
{
    public class MyPlugin : PlugInExampleApp.IPlugin
    {
        public string Name
        {
            get { return "MyPlugin"; }
        }
        public string Description
        {
            get { return "My Sample Plugin"; }
        }
        public bool Load(PlugInExampleApp.Program application)
        {
            return true;
        }
    }
}
