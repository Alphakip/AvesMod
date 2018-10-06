using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace AvesMod
{
    class AvesMod : Mod
	{
        public static AvesMod Instance;
        internal bool CalamityLoaded;

        public AvesMod()
		{
            Properties = new ModProperties()  // Not necessary
            {                                   // All of these values default to true include AutoloadBackgrounds which is needs to be true for biome backgrounds
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void PostSetupContent()
        {
            try
            {
                CalamityLoaded = ModLoader.GetMod("CalamityMod") != null;
            }
            catch (Exception e)
            {
                ErrorLogger.Log("AvesMod PostSetupContent Error: " + e.StackTrace + e.Message);
            }

        }


        public override void AddRecipeGroups()
        {
            // Registers the new recipe group with the specified name
            RecipeGroup group0 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Duck", new int[]
            {
                ItemID.Duck,
                ItemID.MallardDuck,
            });
            // Registers the new recipe group with the specified name
            RecipeGroup.RegisterGroup("AvesMod:Duck", group0);
        }

        public override void Load()
        {
            Instance = this;
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CI"), ItemType("CIBox"), TileType("CIBox"));
                ErrorLogger.Log("oopsFoB");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/FoB"), ItemType("FoBBox"), TileType("FoBBox"));
                ErrorLogger.Log("oopsFoB");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GotFS"), ItemType("GotFSBox"), TileType("GotFSBox"));
                ErrorLogger.Log("oopsGS");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HP"), ItemType("HPBox"), TileType("HPBox"));
                ErrorLogger.Log("oopsHP");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/I"), ItemType("IBox"), TileType("IBox"));
                ErrorLogger.Log("oopsI");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OF"), ItemType("OFBox"), TileType("OFBox"));
                ErrorLogger.Log("oopsOF");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RtS"), ItemType("RtSBox"), TileType("RtSBox"));
                ErrorLogger.Log("oopsRtS");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RUC"), ItemType("RUCBox"), TileType("RUCBox"));
                ErrorLogger.Log("oopsRUC");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SotU"), ItemType("SotUBox"), TileType("SotUBox"));
                ErrorLogger.Log("oopsSU");
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UI"), ItemType("UIBox"), TileType("UIBox"));
                ErrorLogger.Log("oopsUI");

            }
        }
    }
}
