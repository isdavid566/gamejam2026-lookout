using UnityEngine;
using UnityEngine.InputSystem;

public class CursorFollow : MonoBehaviour
{
    private RectTransform rectTransform;

    public float extraWidth = 50f;
    public float extraHeight = 50f;

    public bool cursorActive = true;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (!cursorActive)
            return;

        Vector2 mousePosition = Mouse.current.position.ReadValue();

        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;

        mousePosition.x = Mathf.Clamp(
            mousePosition.x,
            width / 2 - extraWidth,
            Screen.width - width / 2 + extraWidth
        );

        mousePosition.y = Mathf.Clamp(
            mousePosition.y,
            height / 2 - extraHeight,
            Screen.height - height / 2 + extraHeight
        );

        rectTransform.position = mousePosition;
    }
}