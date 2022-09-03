using UnityEngine;

namespace Props.Domains.PropObject
{
    public class FlexibleBall : MonoBehaviour
    {
        private GameObject _obj;

        private void Awake()
        {
            _obj = gameObject;
        }
        
        /// <summary>
        /// オブジェクトのサイズをセットする
        /// </summary>
        /// <param name="scale"></param>
        public void SetScale(float scale)
        {
            _obj.transform.localScale = new Vector3(scale, scale, scale);
        }

        /// <summary>
        /// Materialを指定して見た目をセットする
        /// </summary>
        /// <param name="materials"></param>
        public void SetMaterials(Material[] materials)
        {
            _obj.GetComponent<MeshRenderer>().materials = materials;
        }

        /// <summary>
        /// Rigidbodyの質量をセットする
        /// </summary>
        /// <param name="mass"></param>
        public void SetMass(float mass)
        {
            _obj.GetComponent<Rigidbody>().mass = mass;
        }
    }
}