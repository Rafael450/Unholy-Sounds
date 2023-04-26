using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnergyDrinkType {
    Type1,
    Type2,
    Type3,
    Type4,
    Type5
}
public class EnergyDrink : Item
{
    

    public EnergyDrinkType itemType;

    public static float getSpeedBoost(EnergyDrinkType itemType) {
        switch (itemType) {
        default:
        case EnergyDrinkType.Type1: return 1f;
        case EnergyDrinkType.Type2: return 1f;
        case EnergyDrinkType.Type3: return 3f;
        case EnergyDrinkType.Type4: return 2f;
        case EnergyDrinkType.Type5: return 0.25f;
        }
    }

    public static float getDuration(EnergyDrinkType itemType) {
        switch (itemType) {
        default:
        case EnergyDrinkType.Type1: return 10f;
        case EnergyDrinkType.Type2: return 13f;
        case EnergyDrinkType.Type3: return 5f;
        case EnergyDrinkType.Type4: return 8f;
        case EnergyDrinkType.Type5: return 25f;
        }
    }
}
