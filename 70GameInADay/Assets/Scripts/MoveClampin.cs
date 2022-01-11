using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveClampin : MonoBehaviour
{
    public float Speed;
    public float MovSpeed;
    bool HasMov = false;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(Speed, 0f);
        StartCoroutine(Movin());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0f, MovSpeed, 0f);
            HasMov = true;
        }

        if(HasMov) { return; }
        rb.velocity = new Vector2(Speed, 0f);
    }

    IEnumerator Movin()
    {
        while (!HasMov)
        {
            yield return new WaitForSeconds(1);
            if(rb.velocity.x < 0)
            {
               Speed = 4f;
            }

            else
            {
               Speed = -4f ;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
