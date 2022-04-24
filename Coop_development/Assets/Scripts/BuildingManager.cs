using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

    [SerializeField] private BuildingtypeSO activeBuildingType;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = utilities.GetMouseWorldPosition();
            Instantiate(activeBuildingType.prefab, mousePos, Quaternion.identity);
        }
    }

    public void SetActiveBuildingType(BuildingtypeSO buildingtypeSO)
    {
        activeBuildingType = buildingtypeSO;
    }

    public BuildingtypeSO GetActiveBuildingType()
    {
        return activeBuildingType;
    }
}
