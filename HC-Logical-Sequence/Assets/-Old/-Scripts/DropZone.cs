using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    //Esse método é a implementação da interface: IDropHandler
    //Ele será executado quando: o drag acabar (soltar o mouse) (será executado apenas 1 vez)
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + "Was dropped on " + gameObject.name);

        Draggable myCard = eventData.pointerDrag.GetComponent<Draggable>();
        if (myCard != null) {
            //"parentToReturnTo" é a variável de Draggalble.cs que já recebeu o valor do parentesco inicial
            myCard.parentToReturnTo = this.transform;
        }

    }

    //Esse método é a implementação da interface: IPointerEnterHandler
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter --> foi chamado");
    }

    //Esse método é a implementação da interface: IPointerExitHandler
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("IPointerExitHandler --> foi chamado");
    }
}
