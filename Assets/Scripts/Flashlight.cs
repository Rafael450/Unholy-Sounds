using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : Item
{
    public enum FlashlightType {
        Type1,
        Type2,
        Type3,
        Type4
    }

    public FlashlightType itemType;

    private float getOuterAngle() {
        switch (itemType) {
        default:
        case FlashlightType.Type1: return 90;
        case FlashlightType.Type2: return 50;
        case FlashlightType.Type3: return 150;
        case FlashlightType.Type4: return 120;
        }
    }

    private float getOuterRadius() {
        switch (itemType) {
        default:
        case FlashlightType.Type1: return 20;
        case FlashlightType.Type2: return 25;
        case FlashlightType.Type3: return 10;
        case FlashlightType.Type4: return 17;
        }
    }

}