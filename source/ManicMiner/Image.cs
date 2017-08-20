/*
Image.cs - To hide SDL image handling
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

public class Image
{
    private IntPtr internalPointer;

    public Image(string fileName)
    {
        Load(fileName);
    }

    public void Load(string fileName)
    {
        internalPointer = SdlImage.IMG_Load(fileName);
        if (internalPointer == IntPtr.Zero)
            SdlHardware.FatalError("Image not found: " + fileName);
    }

    public IntPtr GetPointer()
    {
        return internalPointer;
    }
}
