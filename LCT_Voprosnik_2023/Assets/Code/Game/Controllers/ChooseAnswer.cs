using System;
using UnityEngine.UI;
using UnityEngine;

public class ChooseAnswer
{
    public Action Correct;
    public Action UnCorrect;
    public Action EndGame;
    private QuestionSO _questionSO;
    private LevelView _levelView;
    private Level _level;
    private Timer _timer;
    private Image[] _answerImages;
    private Text[] _answerTexts;
    private int _stage = 0;
    private int _questionID;


    public ChooseAnswer(QuestionSO questionSO, LevelView levelView, Level level, Timer timer)
    {
        _questionSO = questionSO;
        _levelView = levelView;
        _level = level;
        _timer = timer;
    }

    public void Awake()
    {
        Initialize();
        _levelView.NextStageButton.gameObject.SetActive(false);
        _questionID = (CurrentLevel.Level * _questionSO.CountQuestionsInLevel) + _stage;
        ResetLevel();
    }

    private void Initialize()
    {
        int length = _levelView.AnswerButtons.Length;
        int i = 1;

        _answerImages = new Image[length];
        _answerTexts= new Text[length];

        _timer.EndTime += EndTime;

        foreach (var answerButton in _levelView.AnswerButtons)
        {
            int j = i;
            answerButton.onClick.AddListener(() => ChooseAnswerMethod(j));

            _answerImages[j - 1] = answerButton.GetComponent<Image>();
            _answerTexts[j - 1] = answerButton.GetComponentInChildren<Text>();
            i++;
        }

        _levelView.NextStageButton.onClick.AddListener(NextStage);
    }

    private void ChooseAnswerMethod(int chooseAnswer)
    {
        _questionID = (CurrentLevel.Level * _questionSO.CountQuestionsInLevel) + _stage;
        _levelView.NextStageButton.gameObject.SetActive(true);
        _timer.StopCorutine();

        int trueAnswer = _questionSO.Questions[_questionID].TrueAnswer;

        if (chooseAnswer == trueAnswer)
        {
            Correctly(chooseAnswer);
        }
        else
        {
            UnCorrectly(chooseAnswer, trueAnswer);
        }
    }

    private void Correctly(int chooseAnswer)
    {
        Correct?.Invoke();

        int index = chooseAnswer - 1;
        _answerImages[index].color = _questionSO.CorrectlyAnswerButtonColor;
        _answerTexts[index].color = _questionSO.CorrectlyAnswerTextColor;
    }

    private void UnCorrectly(int chooseAnswer, int trueAnswer)
    {
        UnCorrect?.Invoke();

        int indexChoose = chooseAnswer - 1;
        int indexTrue = trueAnswer - 1;

        _answerImages[indexChoose].color = _questionSO.UnCorrectlyAnswerButtonColor;
        _answerTexts[indexChoose].color = _questionSO.UnCorrectlyAnswerTextColor;

        _answerImages[indexTrue].color = _questionSO.CorrectlyAnswerButtonColor;
        _answerTexts[indexTrue].color = _questionSO.CorrectlyAnswerTextColor;
    }

    private void EndTime()
    {
        _levelView.NextStageButton.gameObject.SetActive(true);

        int indexTrue = _questionSO.Questions[_questionID].TrueAnswer - 1;

        for (int i = 0; i < _answerImages.Length; i++)
        {
            if(i == indexTrue)
            {
                _answerImages[i].color = _questionSO.CorrectlyAnswerButtonColor;
                _answerTexts[i].color = _questionSO.CorrectlyAnswerTextColor;
            }
            else
            {
                _answerImages[i].color = _questionSO.UnCorrectlyAnswerButtonColor;
                _answerTexts[i].color = _questionSO.UnCorrectlyAnswerTextColor;
            }
        }
    }

    private void ResetLevel()
    {
        _timer.ResetCorutine();

        for (int i = 0; i < _answerImages.Length; i++)
        {
            _answerImages[i].color = _questionSO.DefaultAnswerButtonColor;
            _answerTexts[i].color = _questionSO.DefaultAnswerTextColor;
        }
    }


    private void NextStage()
    {
        _stage++;

        if(_stage == _questionSO.CountQuestionsInLevel)
        {
            EndGame?.Invoke();
            return;
        }

        ResetLevel();

        _questionID = (CurrentLevel.Level * _questionSO.CountQuestionsInLevel) + _stage;
        _level.LoadQuestion(_questionID);

        _levelView.NextStageButton.gameObject.SetActive(false);
    }
}
