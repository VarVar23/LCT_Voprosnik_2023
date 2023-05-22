using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField] private Text _timerText;

    public Text TimerText => _timerText;
}
