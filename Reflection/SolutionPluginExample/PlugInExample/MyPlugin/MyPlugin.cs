using System;

namespace MyPlugin
{
    public class MyPlugin : ProjectPlugInExample.IPlugin
    {
        public string Name
        {
            get { return "MyPlugin"; }
        }
        public string Description
        {
            get { return "My Sample Plugin"; }
        }
        public bool Load(ProjectPlugInExample.Program application)
        {
            return true;
        }
    }
}
