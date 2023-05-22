using UnityEngine;
using UnityEngine.UI;

public class PauseView : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private GameObject _pausePanel;

    public Button PauseButton => _pauseButton;
    public Button ResumeButton => _resumeButton;
    public Button ExitButton => _exitButton;
    public GameObject PausePanel => _pausePanel;
}
