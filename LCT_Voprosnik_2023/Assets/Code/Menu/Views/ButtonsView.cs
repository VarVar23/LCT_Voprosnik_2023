using UnityEngine;
using UnityEngine.UI;

public class ButtonsView : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _collectionButton;
    [SerializeField] private Button _tutorialButton;
    [SerializeField] private Button _authorsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button[] _backButtons;

    public Button PlayButton => _playButton;
    public Button CollectionButton => _collectionButton;
    public Button TutorialButton => _tutorialButton;
    public Button AuthorsButton => _authorsButton;
    public Button ExitButton => _exitButton;
    public Button[] BackButtons => _backButtons;
}
