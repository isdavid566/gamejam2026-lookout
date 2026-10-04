using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int totalItems;
    private int itemsFound;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        totalItems = 0;
        OnClick[] allClickables = FindObjectsByType<OnClick>(FindObjectsSortMode.None);

        foreach (OnClick clickable in allClickables)
        {
            if (clickable.isCollectible) totalItems++;
        }

        Debug.Log("Items to Find: " + totalItems);
    }

    public void ItemFound(string itemName)
    {
        itemsFound++;
        Debug.Log("Found " + itemName + " (" + itemsFound + "/" + totalItems + ")");

        if (itemsFound >= totalItems)
        {
            Debug.Log("Level 1 complete!");
        }
    }

}
