using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RESETTEST : MonoBehaviour
{
    [SerializeField] private Button RESETBUTTON;

    private void Awake()
    {
        RESETBUTTON.onClick.AddListener(Reset);
    }

    private void Reset()
    {
        Save.ResetData();
        SceneManager.LoadScene(0);
    }
}
