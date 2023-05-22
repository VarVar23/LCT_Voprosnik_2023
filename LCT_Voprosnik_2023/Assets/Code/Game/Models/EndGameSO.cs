using UnityEngine;

[CreateAssetMenu(fileName = "EndGameSO", menuName = "Config/EndGameSO", order = 0)]
public class EndGameSO : ScriptableObject
{
    [SerializeField] private int _countTrueAnswerForWin;
    [SerializeField] private int _maxCountTrueAnswer;

    public int CountTrueAnswerForWin => _countTrueAnswerForWin;
    public int MaxCountTrueAnswer => _maxCountTrueAnswer;
}
