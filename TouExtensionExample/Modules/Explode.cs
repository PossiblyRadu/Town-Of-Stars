using MiraAPI.GameOptions;
using TouExtensionExample.Options.Roles.Neutral;
using TownOfUs.Assets;
using TownOfUs.Utilities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TouExtensionExample.Modules;

public sealed class Explode
{
    public Transform Transform { get; set; }

    public void Clear()
    {
        Object.Destroy(Transform.gameObject);
    }

    public static Explode CreateExplode(Vector3 location)
    {
        var igniteRadius = OptionGroupSingleton<SentinelOptions>.Instance.ExplosionRadius.Value;

        var gameObject = MiscUtils.CreateSpherePrimitive(location, igniteRadius);
        gameObject.GetComponent<MeshRenderer>().material = AuAvengersAnims.IgniteMaterial.LoadAsset();

        var ignite = new Explode
        {
            Transform = gameObject.transform
        };

        return ignite;
    }
}