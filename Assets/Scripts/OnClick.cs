using UnityEngine;

public class OnClick : MonoBehaviour
{
// Add more items later on 
    public string itemName = "Teddy Bear";
    public bool isCollectible = true;

    private bool isFound = false;

    private void OnMouseDown()
    {

        if (isFound) return;

        if (isCollectible)
        {
            isFound = true;
            GameManager.Instance.ItemFound(itemName);

            gameObject.SetActive(false);
        }

        else
        {
            Debug.Log("Clicked" + itemName + "(Not Colectable)");
        }
    }
    
}
