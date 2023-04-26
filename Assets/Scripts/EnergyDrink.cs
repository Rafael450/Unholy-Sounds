using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrink : Item
{
    public enum EnergyDrinkType {
        Type1,
        Type2,
        Type3,
        Type4,
        Type5
    }

    public EnergyDrinkType itemType;

    private double getSpeedBoost() {
        switch (itemType) {
        default:
        case EnergyDrinkType.Type1: return 1;
        case EnergyDrinkType.Type2: return 1;
        case EnergyDrinkType.Type3: return 3;
        case EnergyDrinkType.Type4: return 2;
        case EnergyDrinkType.Type5: return 0.5;
        }
    }

    private double getDuration() {
        switch (itemType) {
        default:
        case EnergyDrinkType.Type1: return 20;
        case EnergyDrinkType.Type2: return 30;
        case EnergyDrinkType.Type3: return 10;
        case EnergyDrinkType.Type4: return 15;
        case EnergyDrinkType.Type5: return 60;
        }
    }
}
