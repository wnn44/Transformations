using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    private Vector3 _scaleChange;

    private void Start()
    {
        _scaleChange = new Vector3(_speedScale, _speedScale, _speedScale);        
    }

    void Update()
    {
        transform.localScale += _scaleChange;        
    }
}
