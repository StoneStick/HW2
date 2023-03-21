using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : MonoBehaviour
{
    [SerializeField] private float minotaurSpeed;
    private Vector3 _minotaurLocalScale;
    private Rigidbody2D _rb;
    private Player _player;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = FindObjectOfType<Player>();
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if(_player.transform.position.x < transform.position.x && transform.localScale.x > 0)
            {

                transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1, 1, 1));
            }
            if(_player.transform.position.x > transform.position.x && transform.localScale.x < 0)
            {

                transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1, 1, 1));
            }
        }
        
    }
}
