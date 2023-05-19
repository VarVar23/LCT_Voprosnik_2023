using UnityEngine;

public class CollectionView : MonoBehaviour
{
    [SerializeField] private Animator _collectionAnimator;

    public Animator CollectionAnimator => _collectionAnimator;
}
