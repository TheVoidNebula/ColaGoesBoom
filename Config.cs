using Synapse.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaGoesBoom
{
    public class Config : AbstractConfigSection
    {
        public bool IsEnabled = true;

        [Description("How many SCP-207 will be needed to explode?")]
        public int Scp207ExplosionAmount = 5;

        [Description("How many grenades will be spawned for the explosion?")]
        public int Scp207NadeAmount = 3;

        [Description("After how many seconds do the grenades explode after drinking the last SCP-207?")]
        public float Scp207FuseTime = 0.75f;

    }
}
