using Terraria.ModLoader;

namespace TouhouMusic;

public class TouhouMusic : Mod
{
    internal static TouhouMusic Instance;

    public TouhouMusic() => Instance = this;

    public override void Unload() => Instance = null;
}
