using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public static string nameofobj;
    public GameObject objnametext;

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
        Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
    }
}
