using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public static string nameofobj;
    public GameObject objnametext;
    public RectTransform objnametextPos;
    public GameObject successclick;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        nameofobj = gameObject.name;
        // Debug.Log(nameofobj);
        if (objnametext != null)
        {
            Destroy(objnametext);
            Destroy(gameObject);
            Instantiate(
            successclick,
            objnametextPos.position,
            Quaternion.identity,
            objnametextPos.parent
            );
        }
    }
}
