using UnityEngine;
using UnityEngine.UI;

public class TowerUI : MonoBehaviour
{
    [SerializeField] private Image _towerIcon;

    public void ChangeTowerIcon (Sprite icon)
    {
        _towerIcon.sprite = icon;
    }
}
