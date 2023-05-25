using UnityEngine;

public class ButterflyActive 
{
    private ButterflyView _butterflyView;
    private EndGameSO _endGameSO;

    public ButterflyActive(ButterflyView butterflyView, EndGameSO endGameSO)
    {
        _butterflyView = butterflyView;
        _endGameSO = endGameSO;
    }

    public void Awake()
    {
        int countElement = Save.Level - 1;

        for(int i = 0; i <= countElement; i++)
        {
            _butterflyView.ElemetsPicture[i].SetActive(true);
        }

        if(Save.Finish)
        {
            _butterflyView.ElemetsPicture[Save.Level].SetActive(true);
        }
    }
}
