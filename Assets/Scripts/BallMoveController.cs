using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMoveController : MonoBehaviour
{
    [Header("Script Options")]   
    [SerializeField] public GroundSpawner _groundSpawnerScripts;
    Vector3 _direction;
    public static bool _onGround; 
    [Header("Game Options")]
    [SerializeField] float destroyTimeGround =2f;
    [SerializeField] float _speed = 0;
    [SerializeField] public static float speed = 0;
    [SerializeField] float addSpeed;
    [SerializeField] GameObject finishPanel;
    void Start()
    {
        StartCall();
    }
    void Update()
    {
        BallOnGroun();
        if (_onGround == false)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            PlayerDirection();
        }
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

    //-------------------------------------------------------------------------------

    void StartCall()
    {
        _direction = Vector3.forward;
        _onGround = true;
     
    }
    void PlayerDirection()
    {
        
        if (_direction.x == 0)
        {
            _direction = Vector3.left;
        }
        else
        {
            _direction = Vector3.forward;
        }
        speed += addSpeed * Time.deltaTime;
        _speed = speed;
    }
    void PlayerMovement()
    {
        Vector3 movement = _direction * Time.deltaTime * speed;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Score.score++; 
            collision.gameObject.AddComponent<Rigidbody>();
            _groundSpawnerScripts.GroundSpawn();
            StartCoroutine(DellGround(collision.gameObject));// temas ettiðim onjeyi kaldýrýlacak obje olarak gönderiyotruz
            if (Score.score % 10 == 0)
            {
                Debug.Log("ball " + GroundColor._colorCount);
                GroundColor._colorCount++;
            }
        }
    }

    IEnumerator DellGround(GameObject _destroyGround)
    {
        yield return new WaitForSeconds(destroyTimeGround);
        Destroy(_destroyGround);

    }
    void BallOnGroun()
    {
        if (transform.position.y <= 0.5f)
        {
            _onGround = false;
            finishPanel.SetActive(true);
        }
    }
    
}
