using UnityEngine;
using UnityEngine.UI;

public class PlayWindowView : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private Transform _content;

    public Button PlusButton => _plusButton;
    public Button MinusButton => _minusButton;
    public Transform Content => _content;
}
