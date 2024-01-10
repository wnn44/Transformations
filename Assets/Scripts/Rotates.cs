using System.IO;
using UnityEngine;

public class Rotates : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime * Vector3.up);
    }

}
