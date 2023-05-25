using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private Animator _timerAnimator;

    public Text TimerText => _timerText;
    public Animator TimerAnimator => _timerAnimator;
}
