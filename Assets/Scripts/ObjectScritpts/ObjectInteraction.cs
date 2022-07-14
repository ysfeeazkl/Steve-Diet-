using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ObjectScritpts
{
    public class ObjectInteraction: MonoBehaviour
    {
        Rigidbody2D rigidbody;
        private void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            #region RastgeleKorinatOluşturma
            float xPosizyon = UnityEngine.Random.Range(-2.40f, 2.50f); //rastgele kordinat oluşturuyorum
            float yPosizyon = UnityEngine.Random.Range(7, 15);
            #endregion

            if (collider.gameObject.tag == "Kontrol")
            {
                

                transform.position = new Vector2(xPosizyon, yPosizyon); 
                rigidbody.velocity = new Vector2(0, 0);
                rigidbody.gravityScale = UnityEngine.Random.Range(0.4f, 0.6f);

               

                Debug.Log(collider.name + " çarptı");

              
            }
        }

    }
}
