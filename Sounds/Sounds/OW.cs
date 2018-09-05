using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace AvesMod.Sounds.Sounds
{
    public class OW : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            if (soundInstance.State == SoundState.Playing)
                return null;
            soundInstance.Volume = volume * 1f;
            soundInstance.Pan = pan;
            return soundInstance;
        }
    }
}