using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _towerPlace;
    [SerializeField] private SpriteRenderer _towerHead;
    [SerializeField] private int _shootPower;
    [SerializeField] private float _shootDistance;
    [SerializeField] private float _shootDelay;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _bulletSplashRadius;

    public Vector2? PlacePosition { get; private set; }

    public void SetPlacePosition (Vector2? newPosition)
    {
        PlacePosition = newPosition;
    }

    public void LockPlacement ()
    {
        transform.position = (Vector2) PlacePosition;
    }

    public void ToggleOrderInLayer (bool toFront)
    {
        int orderInLayer = toFront ? 2 : 0;
        _towerPlace.sortingOrder = orderInLayer;
        _towerHead.sortingOrder = orderInLayer;
    }

    public Sprite GetTowerHeadIcon ()
    {
        return _towerHead.sprite;
    }
}
