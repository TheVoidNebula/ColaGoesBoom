using CustomPlayerEffects;
using Synapse;
using Synapse.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ColaGoesBoom.Handlers
{
    public class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Player.PlayerItemUseEvent += onItemUse;
        }

        public void onItemUse(Synapse.Api.Events.SynapseEventArguments.PlayerItemInteractEventArgs ev)
        {
            if(ev.State == Synapse.Api.Events.SynapseEventArguments.ItemInteractState.Finalizing && ev.CurrentItem.ItemType == ItemType.SCP207)
            {
                if(ev.Player.PlayerEffectsController.GetEffect<Scp207>().Intensity == 5)
                {
                    for(int i = 0; i < Plugin.Config.scp207NadeAmount; i++)
                    {
                        Map.Get.SpawnGrenade(ev.Player.Position, Vector3.zero, 1, Synapse.Api.Enum.GrenadeType.Grenade);
                    }
                }
            }
        }
    }
}
