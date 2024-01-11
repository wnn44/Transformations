using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    private Vector3 _scaleChange;

    private void Start()
    {
        _scaleChange = new Vector3(_speedScale, 0, _speedScale);        
    }

    void Update()
    {
        transform.localScale += _scaleChange;        
    }
}
