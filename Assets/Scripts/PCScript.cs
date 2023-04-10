using UnityEngine;

public class PCScript : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    public float vel;
    private bool direita = true;
    public float jump;
    private bool _onGround = false;
    private int qtdJump = 0;

    private bool CanJump { 
        get { 
            return (_onGround || qtdJump < 2) &&
                (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)); 
        } }
    // Start is called before the first frame update
    void Start()
    {
        vel = 10;
        jump = 20000;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        anim.SetBool("movimento", !(x == 0));

        if (direita && x < 0 || !direita && x > 0)
        {
            transform.Rotate(new Vector2(0, 180));
            direita = !direita;
        }
        Jump();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _onGround = true;
        qtdJump = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _onGround = false;
    }

    private void Jump()
    {
        if (CanJump)
            rbd.AddForce(new Vector2(0, jump * ++qtdJump));

    }
}
