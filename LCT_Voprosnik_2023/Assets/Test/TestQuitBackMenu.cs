using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestQuitBackMenu : MonoBehaviour
{
    [SerializeField] private Button _back;

    private void Awake()
    {
        _back.onClick.AddListener(Click);
    }

    private void Click()
    {
        SceneManager.LoadScene(0);
    }
}
