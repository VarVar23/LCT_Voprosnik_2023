using UnityEngine.SceneManagement;

public class Win 
{
    private WinView _winView;

    public Win(WinView winView)
    {
        _winView = winView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _winView.NextButton.onClick.AddListener(NextButton);
        _winView.ExitButton.onClick.AddListener(ExitButton);
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