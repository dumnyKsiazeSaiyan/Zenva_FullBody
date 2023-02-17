using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody rig;

    public float moveSpeed = 3;
    public float jumpForce;

    public bool isGrounded;

    public Vector3 vel;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        scoreText.text = score.ToString();
    }

    void Update()
    {
        // Get the keyboard inputs.
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float z = Input.GetAxisRaw("Vertical") * moveSpeed;
        rig.velocity = new Vector3(x, rig.velocity.y, z);

        vel = rig.velocity;
        vel.y = 0.0f;

        if(vel.x != 0 || vel.z != 0)
        {
            transform.forward = vel;
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Multiply here!
        }

        if (transform.position.y <= -5)
        {
            GameOver();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.GetContact(0).normal == Vector3.up)
        {
            isGrounded = true;
        }
        
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore (int amount)
    {
        score += amount;

        scoreText.text = score.ToString();
    }
}
