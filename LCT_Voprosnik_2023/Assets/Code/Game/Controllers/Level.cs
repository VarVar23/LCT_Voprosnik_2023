using UnityEngine;
using UnityEngine.UI;

public class Level
{
    private QuestionSO _questionSO;
    private LevelView _levelView;

    public Level(QuestionSO questionSO, LevelView levelView)
    {
        _questionSO = questionSO;
        _levelView = levelView;
    }

    public void Start()
    {
        LoadLevel();
    }


    private void LoadLevel()
    {
        int level = CurrentLevel.Level;
        int questionID = _questionSO.CountQuestionsInLevel * level;

        _levelView.LevelText.text = "Уровень " + (level + 1).ToString();

        LoadQuestion(questionID);
    }

    public void LoadQuestion(int questionID)
    {
        _levelView.PhotoImage.sprite = _questionSO.Questions[questionID].PhotoPlace;
        
        var buttons = _levelView.AnswerButtons;

        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = _questionSO.Questions[questionID].Answers[i];
        }
    }
}
