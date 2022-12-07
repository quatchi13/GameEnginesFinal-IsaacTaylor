using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Icommand
{
    KeyCode ChangeControl();
}


public class ShiftInvert : Icommand
{

    public KeyCode ChangeControl()
    {
        
            return KeyCode.RightShift;
    }
}

