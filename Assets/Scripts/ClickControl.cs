using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public static string nameofobj;
    public GameObject objnametext;
    public RectTransform objnametextPos;
    public GameObject successclick;

    void OnMouseDown()
    {
        nameofobj = gameObject.name;

        if (objnametext != null)
        {
            Destroy(objnametext);
            Destroy(gameObject);

            FindFirstObjectByType<LevelManager>().ItemFound();
            
            Instantiate(
            successclick,
            objnametextPos.position,
            Quaternion.identity,
            objnametextPos.parent
            );
        }
    }
}
