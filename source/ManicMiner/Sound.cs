/*
Sound.cs - A simple sound player using SdlMixer
Part of Manic Miner Remake
@see Game Hardware Image Sprite Font

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

using System;
using Tao.Sdl;

public class Sound
{

    private IntPtr internalPointer;

    public Sound(string fileName)
    {
        internalPointer = SdlMixer.Mix_LoadMUS(fileName);
    }

    // To play a song at a particular time
    public void PlayOnce()
    {
        SdlMixer.Mix_PlayMusic(internalPointer, 1);
    }

    // To continuously play song (background music)
    public void BackgroundPlay()
    {
        SdlMixer.Mix_PlayMusic(internalPointer, -1);
    }

    // To stop the music
    public void StopMusic()
    {
        SdlMixer.Mix_HaltMusic();
    }

}