using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool CanShoot { get => m_CanShoot; }
    bool m_CanShoot = false;

    [SerializeField] TMP_Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
            return;
        }

        StartCoroutine(GamePhases());
    }

    private void OnDestroy()
    {
        instance = null;
    }

    IEnumerator GamePhases()
    {
        gameText.text = "Ready";
        yield return new WaitForSeconds(1f);
        gameText.text = "Steady";
        float timeToShoot = Random.Range(0.8f, 3f);
        yield return new WaitForSeconds(timeToShoot);
        gameText.text = "Shoot";
        m_CanShoot = true;
    }
}
