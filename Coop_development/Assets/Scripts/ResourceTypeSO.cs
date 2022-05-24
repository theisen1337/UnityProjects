using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ResourceTypeSO : ScriptableObject
{
    public Transform prefab;
    public string Text;
    public int connectedHarvesters;
    public string resourceType;
}
