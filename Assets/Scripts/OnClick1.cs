using UnityEngine;

public class OnClick1 : MonoBehaviour
{
    public string itemName = "Teddy Bear";

    private bool isFound = false;

    private void OnMouseDown()
    {

        if (isFound) return;

        isFound = true;
        Debug.Log("Found: " + itemName);

        gameObject.SetActive(false);
    }
    
}
