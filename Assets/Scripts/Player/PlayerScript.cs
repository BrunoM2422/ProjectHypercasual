using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float velocity = 1f;
    public float lerpSpeed = 10f;

    public Vector2 pastPosition;

    private Vector3 targetPosition;

    private bool _canRun;

    public GameObject gameOverPanel;

    public GameObject winPanel;

    void Start()
    {
        _canRun = true;
        targetPosition = transform.position;
    }

    void Update()
    {
        if (!_canRun) return;
        // Movimento automático pra frente
        targetPosition += transform.forward * forwardSpeed * Time.deltaTime;

        // Input de toque
        if (Input.GetMouseButton(0))
        {
            float deltaX = Input.mousePosition.x - pastPosition.x;
            targetPosition += Vector3.right * deltaX * velocity * Time.deltaTime;
        }

        pastPosition = Input.mousePosition;

        // Aplica o movimento suave
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * lerpSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("FinishLine"))
        {
            winPanel.SetActive(true);
            _canRun = false;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverPanel.SetActive(true);
            _canRun = false;

        }
    }
}

