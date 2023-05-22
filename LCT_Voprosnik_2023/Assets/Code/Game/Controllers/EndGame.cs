public class EndGame 
{
    private EndGameView _endGameView;
    private ChooseAnswer _chooseAnswer;
    private EndGameSO _endGameSO;
    private int _countCorrectAnswer;

    public EndGame(EndGameView endGameView, ChooseAnswer chooseAnswer, EndGameSO endGameSO)
    {
        _endGameView = endGameView;
        _chooseAnswer = chooseAnswer;
        _endGameSO = endGameSO;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _countCorrectAnswer = 0;

        _chooseAnswer.UnCorrect += UnCorrect;
        _chooseAnswer.Correct += Correct;
        _chooseAnswer.EndGame += EndGameMethod;
    }

    private void UnCorrect()
    {

    }

    private void Correct()
    {
        _countCorrectAnswer++;
    }

    private void EndGameMethod()
    {
        if(_countCorrectAnswer >= _endGameSO.CountTrueAnswerForWin)
        {
            Win();
        }
        else
        {
            Lose();
        }
    }

    private void Win()
    {
        _endGameView.WinPanel.SetActive(true);
    }

    private void Lose()
    {
        _endGameView.LosePanel.SetActive(true);
    }
}
