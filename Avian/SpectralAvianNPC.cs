using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvesMod.Avian
{
    public class SpectralAvianNPC : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Avian");
            Main.npcFrameCount[npc.type] = 15;
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Duck2);
            npc.width = 52;
            npc.height = 40;
            npc.aiStyle = 68;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 50;
            Main.npcCatchable[npc.type] = true;
            animationType = NPCID.Duck2;
            npc.HitSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Sounds/QUAK");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Sounds/OW");
            npc.catchItem = (short)mod.ItemType("SpectralAvian");
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Overworld.Chance * 0.1f;
        }
    }
}