public class EndGame 
{
    private EndGameView _endGameView;
    private ChooseAnswer _chooseAnswer;
    private EndGameSO _endGameSO;
    private CollectionSO _collectionSO;
    private WinView[] _winViews;
    private int _countCorrectAnswer;

    public EndGame(EndGameView endGameView, ChooseAnswer chooseAnswer, EndGameSO endGameSO, CollectionSO collectionSO, WinView[] winViews)
    {
        _endGameView = endGameView;
        _chooseAnswer = chooseAnswer;
        _endGameSO = endGameSO;
        _collectionSO = collectionSO;
        _winViews = winViews;
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
        if(_countCorrectAnswer >= _endGameSO.CountTrueAnswerForWin && _countCorrectAnswer != _endGameSO.MaxCountTrueAnswer)
        {
            Win();
        }
        else if(_countCorrectAnswer == _endGameSO.MaxCountTrueAnswer)
        {
            BestWin();
        }
        else
        {
            Lose();
        }
    }

    private void Win()
    {
        _endGameView.WinPanel.SetActive(true);

        if (CheckLastLevel()) return;

        if (CurrentLevel.Level >= Save.Level)
        {
            Save.SaveLevel(CurrentLevel.Level + 1);
        }
    }

    private void BestWin()
    {
        _endGameView.BestWinPanel.SetActive(true);
        _endGameView.CollectionImage.sprite = _collectionSO.SpritesCart2DCollection[CurrentLevel.Level];

        Save.SaveCollection(CurrentLevel.Level);

        if (CheckLastLevel()) return;

        if (CurrentLevel.Level >= Save.Level)
        {
            Save.SaveLevel(CurrentLevel.Level + 1);
        }
    }

    private void Lose()
    {
        _endGameView.LosePanel.SetActive(true);
    }

    private bool CheckLastLevel()
    {
        if(CurrentLevel.Level == _endGameSO.MaxCountLevel)
        {
            foreach(var winView in _winViews)
            {
                winView.NextButton.gameObject.SetActive(false);
            }

            Save.SaveFinish(true);

            return true;
        }

        return false;
    }
}
