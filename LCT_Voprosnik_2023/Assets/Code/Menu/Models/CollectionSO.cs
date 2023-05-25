using UnityEngine;

[CreateAssetMenu(fileName = "CollectionSO", menuName = "Config/CollectionSO", order = 0)]
public class CollectionSO : ScriptableObject
{
    [SerializeField] private Sprite[] _spritesCart2DCollection;
    [SerializeField] private Sprite[] _spritesCart3DCollection;

    public Sprite[] SpritesCart2DCollection => _spritesCart2DCollection;
    public Sprite[] SpritesCart3DCollection => _spritesCart3DCollection;
}
