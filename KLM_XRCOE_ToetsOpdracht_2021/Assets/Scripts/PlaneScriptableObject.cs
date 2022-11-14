using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plane", menuName = "Plane")]
public class PlaneScriptableObject : ScriptableObject
{
    public string typeOfPlane;
    public PlaneBrands planeBrand;

    public enum PlaneBrands
    {
        Embraer,
        Boeing,
        Airbus
    }

}


