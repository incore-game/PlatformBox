using UnityEngine;
using System.Collections;

[ ExecuteInEditMode ]
public class Magnet : MonoBehaviour {

        public float power = 5f;
        public float radius = 5f;

        void Update(){
                gameObject.GetComponent<CapsuleCollider>().radius=radius;
        }

        void OnDrawGizmosSelected() {
                Gizmos.color = Color.white;
                Gizmos.DrawWireSphere(transform.position, radius);
        }

        void OnTriggerStay(Collider collision) {
                if (collision.gameObject.tag=="Enemy"){
                        collision.GetComponent<Rigidbody>().AddForce((transform.position-collision.gameObject.transform.position)*power*collision.GetComponent<Rigidbody>().mass, ForceMode.Force);
                }
        }
        
}