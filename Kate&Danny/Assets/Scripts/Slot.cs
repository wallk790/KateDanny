using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

	public Sprite A;
	public Sprite B;
	public Sprite C;
	public Sprite D;


	public GameObject item{
		get{
			if(transform.childCount>0){
				return transform.GetChild(0).gameObject;
		}
			return null;
	}
}

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		if(!item){
			if(DragHandler.itemBeingDragged.tag == transform.gameObject.tag){
				if(DragHandler.itemBeingDragged.tag == "A"){
					DragHandler.itemBeingDragged.GetComponent<Image>().sprite = A;
				}
				if(DragHandler.itemBeingDragged.tag == "B"){
					DragHandler.itemBeingDragged.GetComponent<Image>().sprite = B;
				}
				if(DragHandler.itemBeingDragged.tag == "C"){
					DragHandler.itemBeingDragged.GetComponent<Image>().sprite = C;
				}
				if(DragHandler.itemBeingDragged.tag == "D"){
					DragHandler.itemBeingDragged.GetComponent<Image>().sprite = D;
				}

			DragHandler.itemBeingDragged.transform.SetParent(transform);
			}
		}
	}
	#endregion
}
