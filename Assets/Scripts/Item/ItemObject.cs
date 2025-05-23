using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;


public interface IInteractable
{
    public string GetInteractivePrompt();
    public void OnInteract();
}
public class ItemObject : MonoBehaviour, IInteractable
{
   public ItemData data;
   public string GetInteractivePrompt()
   {
       string str = $"{data.displayname}\n{data.description}";
       return str;
   }

   public void OnInteract()
   {
       CharterManager.Instance.Player.ItemData = data;
       //CharterManager.Instance.Player.addItem?.();
       Destroy(gameObject);
   }
   
}
