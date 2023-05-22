using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionSO", menuName = "Config/QuestionSO", order = 0)]
public class QuestionSO : ScriptableObject
{
    [SerializeField] private int _timeAnswer;
    [SerializeField] private int _countQuestionsInLevel;
    [SerializeField] private Color _correctlyAnswerTextColor;
    [SerializeField] private Color _unCorrectlyAnswerTextColor;
    [SerializeField] private Color _correctlyAnswerButtonColor;
    [SerializeField] private Color _unCorrectlyAnswerButtonColor;
    [SerializeField] private Color _defaultAnswerButtonColor;
    [SerializeField] private Color _defaultAnswerTextColor;


    [SerializeField] private List<Question> _questions;


    public int TimeAnswer => _timeAnswer;
    public int CountQuestionsInLevel => _countQuestionsInLevel;
    public List<Question> Questions => _questions;

    public Color CorrectlyAnswerTextColor => _correctlyAnswerTextColor;
    public Color UnCorrectlyAnswerTextColor => _unCorrectlyAnswerTextColor;
    public Color CorrectlyAnswerButtonColor => _correctlyAnswerButtonColor;
    public Color UnCorrectlyAnswerButtonColor => _unCorrectlyAnswerButtonColor;
    public Color DefaultAnswerButtonColor => _defaultAnswerButtonColor;
    public Color DefaultAnswerTextColor => _defaultAnswerTextColor;

}
