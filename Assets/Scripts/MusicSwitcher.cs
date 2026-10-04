using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicSwitcher : MonoBehaviour
{
    public AudioClip startAndWinAudio;
    public AudioClip gameplayMusic;

    public string[] gameplayScenes =
    {
        "BedroomScene1",
        "GameroomScene",
        "KitchenScene"
    };


    public string startSceneName = "Start";
    public string winSceneName = "EndScene";

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeMusic(SceneManager.GetActiveScene().name);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ChangeMusic(scene.name);
    }

    void ChangeMusic(string sceneName)
    {

        if (sceneName == startSceneName || sceneName == winSceneName)
        {
            PlayMusic(startAndWinAudio);
        }
        else if (System.Array.Exists(gameplayScenes, scene => scene == sceneName))
        {
            PlayMusic(gameplayMusic);
        }
    }

    void PlayMusic(AudioClip newClip)
    {
        if (audioSource.clip == newClip)
        {
            return;
        }

        audioSource.clip = newClip;
        audioSource.Play();
    }
}
