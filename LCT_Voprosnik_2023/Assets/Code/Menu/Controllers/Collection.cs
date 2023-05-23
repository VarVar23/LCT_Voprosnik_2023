public class Collection 
{
    private CollectionView _collectionView;
    private ButtonsView _buttonsView;

    public Collection(CollectionView collectionView, ButtonsView buttonsView)
    {
        _collectionView = collectionView;
        _buttonsView = buttonsView;
    }

    public void Awake() => Initialize();

    private void Initialize()
    {

    }

}
