using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var allChestInfos = Resources.LoadAll<ChestInfo>("");

        foreach (var info in allChestInfos)
        {
            Debug.Log(info.id);
        }
    }
}
