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
            Server.Get.Events.Player.PlayerItemUseEvent += OnItemUse;
        }

        public void OnItemUse(Synapse.Api.Events.SynapseEventArguments.PlayerItemInteractEventArgs ev)
        {
            if(ev.State == Synapse.Api.Events.SynapseEventArguments.ItemInteractState.Finalizing && ev.CurrentItem.ItemType == ItemType.SCP207)
            {
                if(ev.Player.PlayerEffectsController.GetEffect<Scp207>().Intensity == Plugin.Config.Scp207ExplosionAmount-1)
                {
                    for(int i = 0; i < Plugin.Config.Scp207NadeAmount; i++)
                    {
                        Map.Get.SpawnGrenade(ev.Player.Position, Vector3.zero, Plugin.Config.Scp207FuseTime, Synapse.Api.Enum.GrenadeType.Grenade, ev.Player);
                    }
                }
            }
        }
    }
}
