using ColaGoesBoom.Handlers;
using Synapse.Api.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaGoesBoom
{
    [PluginInformation(
        Author = "TheVoidNebula",
        Description = "Haha Cola goes boom.",
        LoadPriority = 0,
        Name = "ColaGoesBoom",
        SynapseMajor = 2,
        SynapseMinor = 4,
        SynapsePatch = 2,
        Version = "b1.0"
        )]
    public class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "Sizes")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("Sizes loaded!");

            new EventHandlers();
        }

        public override void ReloadConfigs()
        {

        }
    }
}