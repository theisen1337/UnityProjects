using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTypeSelectUI : MonoBehaviour
{
    [SerializeField] private List<BuildingtypeSO> buildingTypeSOList;
    [SerializeField] private BuildingManager buildingManager;

    private Dictionary<BuildingtypeSO, Transform> buildingButtonDictionary;

    private void Awake()
    {
        Transform BuildingButtonTemplate = transform.Find("BuildingButtonTemplate");
        BuildingButtonTemplate.gameObject.SetActive(false);

        buildingButtonDictionary = new Dictionary<BuildingtypeSO, Transform>();
        int index = 0;
        foreach (BuildingtypeSO buildingtypeSO in buildingTypeSOList)
        {
            Transform BuildingButtonTransform = Instantiate(BuildingButtonTemplate, transform);
            BuildingButtonTransform.gameObject.SetActive(true);

            BuildingButtonTransform.GetComponent<RectTransform>().anchoredPosition += new Vector2(index * 120, 0);
            BuildingButtonTransform.Find("Text").GetComponent<Text>().text = buildingtypeSO.Text;

            BuildingButtonTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                buildingManager.SetActiveBuildingType(buildingtypeSO);
                UpdateSelectedVisual();
            });

            buildingButtonDictionary[buildingtypeSO] = BuildingButtonTransform;
            index++;

        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            foreach (BuildingtypeSO buildingtypeSO in buildingButtonDictionary.Keys)
            {
                buildingButtonDictionary[buildingtypeSO].Find("background").GetComponent<Image>().color = new Color32(176, 120, 117, 255);
            }

            buildingManager.SetActiveBuildingType(null);
        }
    }

    private void UpdateSelectedVisual()
    {
         foreach (BuildingtypeSO buildingtypeSO in buildingButtonDictionary.Keys)
         {
            buildingButtonDictionary[buildingtypeSO].Find("background").GetComponent<Image>().color = new Color32(176, 120, 117, 255);
         }
        

        BuildingtypeSO activeBuildingType = buildingManager.GetActiveBuildingType();
        buildingButtonDictionary[activeBuildingType].Find("background").GetComponent<Image>().color = new Color32(219, 221, 39, 255);
    }
}
