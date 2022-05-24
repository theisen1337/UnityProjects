using UnityEngine.UI;
using UnityEngine;

public class UIResources : MonoBehaviour
{
    public int resourceCount;
    public Text resourceStock;
    public string resourceLabel;
    public string resourceCountlabel;

    // Update is called once per frame
    void Update()
    {
        resourceCountlabel = resourceCount.ToString();
        resourceStock.text = resourceLabel + resourceCountlabel;
        
    }
}
