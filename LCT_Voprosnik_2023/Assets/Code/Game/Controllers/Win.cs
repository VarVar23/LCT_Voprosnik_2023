using UnityEngine.SceneManagement;

public class Win 
{
    private WinView[] _winViews;

    public Win(WinView[] winViews)
    {
        _winViews = winViews;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        foreach(var winView in _winViews)
        {
            winView.NextButton.onClick.AddListener(NextButton);
            winView.ExitButton.onClick.AddListener(ExitButton);
        }
    }

    private void ExitButton()
    {
        SceneManager.LoadScene(0);
    }

    private void NextButton()
    {
        CurrentLevel.Level++;
        SceneManager.LoadScene(1);
    }
}