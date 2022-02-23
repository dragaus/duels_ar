using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(() => ChangeSceneByIndex(1));    
    }

    void ChangeSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
