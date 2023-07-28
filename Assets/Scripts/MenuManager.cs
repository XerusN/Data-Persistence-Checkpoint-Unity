using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI bestScoreText;
    public TMP_InputField nameInputField;

    // Start is called before the first frame update
    void Start()
    {
        PersistenceManager.Instance.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        PersistenceManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene("main");
    }

    public void exitGame()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }


}
