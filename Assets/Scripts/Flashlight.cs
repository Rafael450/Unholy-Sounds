using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FlashlightType {
        Type1,
        Type2,
        Type3,
        Type4,
        Type5
}

public class Flashlight : Item
{


    public FlashlightType flashlightType;

    public static float getOuterAngle(FlashlightType flashlightType) {
        switch (flashlightType) {
        default:
        case FlashlightType.Type1: return 90;
        case FlashlightType.Type2: return 50;
        case FlashlightType.Type3: return 150;
        case FlashlightType.Type4: return 120;
        case FlashlightType.Type5: return 360;
        }
    }

    public static float getOuterRadius(FlashlightType flashlightType) {
        switch (flashlightType) {
        default:
        case FlashlightType.Type1: return 20;
        case FlashlightType.Type2: return 25;
        case FlashlightType.Type3: return 10;
        case FlashlightType.Type4: return 17;
        case FlashlightType.Type5: return 20;
        }
    }

}