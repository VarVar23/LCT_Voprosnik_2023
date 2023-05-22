using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Timers;
using System;

public class Timer
{
    public Action EndTime;
    public int Time;
    public bool _activeCorutine;
    private TimerView _timerView;
    private QuestionSO _questionSO;
    private int _numberQuestion;

    public Timer(TimerView timerView, QuestionSO questionSO)
    {
        _timerView = timerView;
        _questionSO = questionSO;
    }

    public void Start()
    {
        Time = _questionSO.TimeAnswer + 1;
        _numberQuestion = 0;
        StartCorutine();
    }

    public void ResetCorutine()
    {
        StopCorutine();
        Time = _questionSO.TimeAnswer + 1;
        _numberQuestion++;

        StartCorutine();
    }

    public void StopCorutine()
    {
        _activeCorutine = false;
        _timerView.StartCoroutine(CorutineTimer());
    }

    public void StartCorutine()
    {
        _activeCorutine = true;
        _timerView.StartCoroutine(CorutineTimer());
        _timerView.TimerText.text = Time.ToString();
    }

    private void TimeOver()
    {
        Debug.Log("Время закончилось");
    }

    private IEnumerator CorutineTimer()
    {
        int question = _numberQuestion;

        while (_activeCorutine)
        {
            Time--;

            _timerView.TimerText.text = Time.ToString();

            if (Time <= 0)
            {
                StopCorutine();
                EndTime?.Invoke();
            }

            yield return new WaitForSeconds(1);

            if(question != _numberQuestion)
            {
                break;
            }
        }
    }
}
