using Cinemachine;
using UnityEngine;


namespace DefaultNamespace
{
    public sealed class ObjectActivator : MonoBehaviour
    {
        [SerializeField] private TagType _activatorTag;
        [SerializeField] private bool _deactivateOnExit;
        [SerializeField] private GameObject[] _objects;
       // [SerializeField] private CinemachineTargetGroup _targetGroup;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(TagManager.GetTag(_activatorTag)))
            {
                for (var index = 0; index < _objects.Length; index++)
                {
                    var obj = _objects[index];
                    obj.SetActive(true);
                }
            }

            
            //if (_targetGroup)
            //{
            //    foreach (var targetGroupMTarget in _targetGroup.m_Targets)
            //    {
            //        Debug.Log(targetGroupMTarget.target.name);
            //    }
            //}
            
           // _targetGroup.m_Targets.Add(target)
        }
       
        

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (_deactivateOnExit && collision.CompareTag(TagManager.GetTag(_activatorTag)))
            {
                for (var index = 0; index < _objects.Length; index++)
                {
                    var obj = _objects[index];
                    obj.SetActive(false);
                }
            }
        }

        private void OnBecameInvisible()
        {
        }

        private void OnBecameVisible()
        {
        }
    }
}
