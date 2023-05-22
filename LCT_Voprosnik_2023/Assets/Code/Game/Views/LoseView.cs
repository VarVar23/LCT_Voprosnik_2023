using UnityEngine;
using UnityEngine.UI;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Button _retryButton;
    [SerializeField] private Button _exitButton;

    public Button RetryButton => _retryButton;
    public Button ExitButton => _exitButton;
}
