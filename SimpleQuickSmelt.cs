using Oxide.Core;
using Oxide.Plugins;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("SimpleQuickSmelt", "jlee2834", "1.0.0")]
    [Description("Smelts items twice as fast globally.")]
    public class QuickSmeltSimple : RustPlugin
    {
        private const float SmeltInterval = 1.0f; // Default is 2.0f, so 1.0f means twice as fast

        private void OnServerInitialized()
        {
            foreach (var oven in UnityEngine.Object.FindObjectsOfType<BaseOven>())
            {
                ApplySmeltSpeed(oven);
            }
        }

        private void OnEntitySpawned(BaseNetworkable entity)
        {
            if (entity is BaseOven oven)
            {
                timer.Once(0.1f, () => ApplySmeltSpeed(oven));
            }
        }

        private void ApplySmeltSpeed(BaseOven oven)
        {
            if (oven == null || oven.IsDestroyed)
                return;

            oven.CancelInvoke("Cook");
            oven.InvokeRepeating("Cook", SmeltInterval, SmeltInterval);
        }
    }
}
