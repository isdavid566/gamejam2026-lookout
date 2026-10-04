using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    public AudioClip menuMusic;
    public AudioClip levelMusic;

    private AudioSource audioSource;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start()
    {
        PlayMusicForScene(SceneManager.GetActiveScene().name);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayMusicForScene(scene.name);
    }

    void PlayMusicForScene(string sceneName)
    {
        AudioClip musicToPlay;

        if (sceneName == "StartScene" || sceneName == "EndScene" || sceneName == "InstructionsScene")
        {
            musicToPlay = menuMusic;
        }
        else
        {
            musicToPlay = levelMusic;
        }

        if (audioSource.clip != musicToPlay)
        {
            audioSource.clip = musicToPlay;
            audioSource.Play();
        }
    }
}