using UnityEngine;
using UnityEngine.UI;

public class LevelView : MonoBehaviour
{
    [SerializeField] private Text _levelText;
    [SerializeField] private Image _photoImage;
    [SerializeField] private Button[] _answerButtons;
    [SerializeField] private Button _nextStageButton;

    public Text LevelText => _levelText;
    public Image PhotoImage => _photoImage;
    public Button[] AnswerButtons => _answerButtons;
    public Button NextStageButton => _nextStageButton;
}
