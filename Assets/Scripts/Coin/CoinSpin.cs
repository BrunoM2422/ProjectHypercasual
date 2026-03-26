using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotaciona a moeda em torno do eixo Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
