using UnityEngine;

/* significa que para todo componente que seja adicionado esse script,
 * caso tal componente não possua um rigidBody , sera criado um rigidBody para esse componente 
 */

[RequireComponent(typeof(Rigidbody2D))]

public class playerMov : MonoBehaviour
{


    public float minhaVelocidade = 10;
    Rigidbody2D m_R2D;




    // Use this for initialization
    void Start()
    {
        m_R2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //pega o input das teclas do teclado para movimento
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //move o player
        //m_R2D.velocity = new Vector2(h, v).normalized * minhaVelocidade * Time.deltaTime;

        Vector2 movePosition = new Vector2(h, v).normalized * minhaVelocidade;

        m_R2D.MovePosition(m_R2D.position + movePosition * Time.deltaTime);







    }
}
