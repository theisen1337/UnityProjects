using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{

    [SerializeField] private BuildingtypeSO activeBuildingType;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && activeBuildingType != null)
        {
            Vector3 mousePos = utilities.GetMouseWorldPosition();
            if (CanSpawnBuilding(activeBuildingType, mousePos))
            {
                Instantiate(activeBuildingType.prefab, mousePos, Quaternion.identity);
            }
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

    private bool CanSpawnBuilding(BuildingtypeSO buildingtypeSO, Vector3 position)
    {
        BoxCollider2D buildingBoxCollider2D = buildingtypeSO.prefab.GetComponent<BoxCollider2D>();

        bool areaClear = (Physics2D.OverlapBox(position + (Vector3)buildingBoxCollider2D.offset, buildingBoxCollider2D.size, 0) == null);
        if (!areaClear) return false;

        float maxBuildingRadius = 10f;
        Collider2D[] collider2DArray = Physics2D.OverlapCircleAll(position, maxBuildingRadius);

        foreach (Collider2D collider2D in collider2DArray)
        {
            bool hasBuilding = collider2D.GetComponent<Collision>() != null;
            if (hasBuilding)
            {
                return true;
            }
        }

        return false;
    }
}
