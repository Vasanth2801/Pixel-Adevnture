using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("References for the Canvas")]
    [SerializeField] private GameObject startingTransition;
    [SerializeField] private GameObject endingTransition;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneLoad();
        }
    }

    void SceneLoad()
    {
        startingTransition.SetActive(true);
        Invoke("DisableStartingTransition", 1.3f);
        endingTransition.SetActive(true);
        Invoke("LoadScene", 0.3f);
        endingTransition.SetActive(false);
    }

    void DisableStartingTransition()
    {
        startingTransition.SetActive(false);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
