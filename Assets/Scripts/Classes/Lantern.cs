using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    public float radius;
    public float angle;
    public UnityEngine.Rendering.Universal.Light2D _light;

    void Start() {
        _light.pointLightOuterAngle = angle;
        _light.pointLightOuterRadius = radius;
    }

}