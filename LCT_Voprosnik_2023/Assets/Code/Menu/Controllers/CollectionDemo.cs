public class CollectionDemo 
{
    private CollectionView _collectionView;
    private ButtonsView _buttonsView;

    public CollectionDemo(CollectionView collectionView, ButtonsView buttonsView)
    {
        _collectionView = collectionView;
        _buttonsView = buttonsView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {
        _buttonsView.CollectionButton.onClick.AddListener(StartAnimator);
    }

    private void StartAnimator()
    {
        _collectionView.CollectionAnimator.SetTrigger("start");
    }
}
