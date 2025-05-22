using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TouhouMusic.Common.Scenes;

public class MoonLord : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/FinalDream");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.MoonLordCore) && Main.npc[NPC.FindFirstNPC(NPCID.MoonLordCore)].Distance(player.Center) <= 8400;
}

public class LunaticCultist : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/NightFalls");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.CultistBoss) && Main.npc[NPC.FindFirstNPC(NPCID.CultistBoss)].Distance(player.Center) <= 8400;
}

public class EmpressofLight : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/FaintDream");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.HallowBoss) && Main.npc[NPC.FindFirstNPC(NPCID.HallowBoss)].Distance(player.Center) <= 8400;
}

public class Plantera : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/FlowerLand");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.Plantera) && Main.npc[NPC.FindFirstNPC(NPCID.Plantera)].Distance(player.Center) <= 8400;
}

public class Skeletron : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/PlasticMind");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.SkeletronHead) && Main.npc[NPC.FindFirstNPC(NPCID.SkeletronHead)].Distance(player.Center) <= 8400;
}

public class EyeofCthulhu : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/DemystifyFeast");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.EyeofCthulhu) && Main.npc[NPC.FindFirstNPC(NPCID.EyeofCthulhu)].Distance(player.Center) <= 8400;
}

public class KingSlime : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/KAGE");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player) =>
        NPC.AnyNPCs(NPCID.KingSlime) && Main.npc[NPC.FindFirstNPC(NPCID.KingSlime)].Distance(player.Center) <= 8400;
}
