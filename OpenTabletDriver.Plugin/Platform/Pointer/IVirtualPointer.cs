﻿namespace OpenTabletDriver.Plugin.Platform.Pointer
{
    public interface IVirtualPointer
    {
        void MouseDown(MouseButton button);
        void MouseUp(MouseButton button);
    }
}