using UnityEngine.SceneManagement;

public class Pause
{
    private PauseView _pauseView;
    private Timer _timer;

    public Pause(PauseView pauseView, Timer timer)
    {
        _pauseView = pauseView;
        _timer = timer;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _pauseView.PauseButton.onClick.AddListener(PauseButton);
        _pauseView.ResumeButton.onClick.AddListener(ResumeButton);
        _pauseView.ExitButton.onClick.AddListener(ExitButton);
    }

    private void PauseButton()
    {
        _timer.StopCorutine();
        _pauseView.PausePanel.SetActive(true);
    }

    private void ResumeButton()
    {
        _timer.StartCorutine();
        _pauseView.PausePanel.SetActive(false);
    }

    private void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
}
