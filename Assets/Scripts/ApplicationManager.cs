
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Application Manager", menuName = "Managers/Application Manager")]
public class ApplicationManager : SingletonScriptableObject<ApplicationManager>
{
    [Header("Loading Transition Settings")]
    public bool enableTransition = true;

    [ShowIf("enableTransition")] public GameObject LoadingScreen;
    int _sceneToLoad;
    public void QuitApplication()
    {
        Application.Quit();

    }
    public void Initalize()
    {
        if (enableTransition)
        {
            /*            currentLoadingScreen = Instantiate(LoadingScreen).GetComponent<LoadingScreenManager>();
                        DontDestroyOnLoad(currentLoadingScreen.gameObject);*/
            //currentLoadingScreen.gameObject.SetActive(false);
        }
    }
    public void LoadScene(string _scene)
    {
        if (!enableTransition)
            SceneManager.LoadScene(_scene);
        else
        {
            //currentLoadingScreen.gameObject.SetActive(true);
            _sceneToLoad = SceneManager.GetSceneByName(_scene).buildIndex;

        }
    }

    public void LoadScene(int _scene)
    {
        if (!enableTransition)
            SceneManager.LoadScene(_scene);
        else
        {
            _sceneToLoad = _scene;
            //currentLoadingScreen.RevealLoadingScreen();
        }
    }
    public void OnLoadingScreenRevealed()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }

    public void OnLoadingScreenHided()
    {
        //currentLoadingScreen.HideLoadingScreen();
        //currentLoadingScreen.gameObject.SetActive(false);
    }

    public void GoToLink(string link)
    {
        Application.OpenURL(link);
    }
    public void RestartScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RestartSceneWithDelay(float delay)
    {
        Timer.Register(delay, () => { LoadScene(SceneManager.GetActiveScene().buildIndex); }, useRealTime: true);
    }
}
