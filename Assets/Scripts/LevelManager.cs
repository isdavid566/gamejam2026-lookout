using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int requiredItems = 3;

    private int foundItems = 0;

    public GameObject nextLevelButton;

    void Start()
    {
        nextLevelButton.SetActive(false);
    }

    public void ItemFound()
    {
        foundItems++;

        Debug.Log("Items found: " + foundItems + "/" + requiredItems);

        if (foundItems >= requiredItems)
        {
            nextLevelButton.SetActive(true);
        }
    }

    public void LoadNextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}