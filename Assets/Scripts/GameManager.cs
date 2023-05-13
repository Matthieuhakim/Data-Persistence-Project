using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public string playerName;

    [SerializeField]
    private InputField playerNameField;

    public static GameManager Instance;


    // Start is called before the first frame update
    void Awake()
    {

        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

    }


    public void PlayGame()
    {

        if (playerNameField.text != null)
        {
            playerName = playerNameField.text;
        }

        SceneManager.LoadScene(1);
    }

}
