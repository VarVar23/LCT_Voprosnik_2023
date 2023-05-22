using UnityEngine;

public class MainGame : MonoBehaviour
{
    #region Views

    [Header("Views")]
    [SerializeField] private LevelView _levelView;
    [SerializeField] private TimerView _timerView;
    [SerializeField] private EndGameView _endGameView;
    [SerializeField] private PauseView _pauseView;
    [SerializeField] private WinView _winView;
    [SerializeField] private LoseView _loseView;


    #endregion

    #region Model

    [Header("Scriptable Objects")]
    [SerializeField] private QuestionSO _questionSO;
    [SerializeField] private EndGameSO _endGameSO;


    #endregion

    #region Controllers

    private Level _level;
    private Timer _timer;
    private ChooseAnswer _chooseAnswer;
    private EndGame _endGame;
    private Pause _pause;
    private Win _win;
    private Lose _lose;

    #endregion

    private void Awake()
    {
        InitializeControllers();

        _chooseAnswer.Awake();
        _endGame.Awake();
        _pause.Awake();
        _win.Awake();
        _lose.Awake();
    }

    private void Start()
    {
        _level.Start();
        _timer.Start();
    }

    private void InitializeControllers()
    {
        _level = new Level(_questionSO, _levelView);
        _timer = new Timer(_timerView, _questionSO);
        _chooseAnswer = new ChooseAnswer(_questionSO, _levelView, _level, _timer);
        _endGame = new EndGame(_endGameView, _chooseAnswer, _endGameSO);
        _pause = new Pause(_pauseView, _timer);
        _win = new Win(_winView);
        _lose = new Lose(_loseView); 
    }
}
