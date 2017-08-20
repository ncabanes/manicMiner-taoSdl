/*
Font.cs - To hide SDL TTF font handling
Part of Manic Miner Remake
@see Game Hardware Image Sprite

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

using System;
using Tao.Sdl;

class Font
{
    private IntPtr internalPointer;

    public Font(string fileName, short sizePoints)
    {
        Load(fileName, sizePoints);
    }

    public void Load(string fileName, short sizePoints)
    {
        internalPointer = SdlTtf.TTF_OpenFont(fileName, sizePoints);
        if (internalPointer == IntPtr.Zero)
            SdlHardware.FatalError("Font not found: " + fileName);
    }

    public IntPtr GetPointer()
    {
        return internalPointer;
    }
}
