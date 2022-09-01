using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : Monobehaviour
{
   public UnityEvent triggerEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
        triggerEnterEvent.Invoke();
   }
}
