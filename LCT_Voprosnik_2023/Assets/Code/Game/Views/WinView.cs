using UnityEngine;
using UnityEngine.UI;

public class WinView : MonoBehaviour
{
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _exitButton;

    public Button NextButton => _nextButton;
    public Button ExitButton => _exitButton;
}
