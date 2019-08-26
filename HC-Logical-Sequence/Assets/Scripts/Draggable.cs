using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public Transform placeholderParent = null;

    //GameObject cardCopy = null;

    //Esse método é a implementação da interface: IBeginDragHandler
    //Ele será executado quando: o drag for iniciado (será executado apenas 1 vez)
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag --> foi chamado");



        //armazena o parentesco inicial
        parentToReturnTo = this.transform.parent;

        //retira o card do parentesco do container draggable
        this.transform.SetParent(this.transform.parent.parent);

        /*
         * Caso a seleção ocorra no painel drag, eu crio uma nova instância
         * do card no painel drag
        */
        /*
        if (parentToReturnTo.name == "Drag-Panel")
        {
            cardCopy = Instantiate(this.gameObject) as GameObject;
            cardCopy.transform.SetParent(parentToReturnTo);
        }
        */

        //CanvasGroup é um componente adicionado nno card, ele tem a propriedade
        //"blocksRaycasts" que deve ser desabilitada quando o card está sendo arrastado sobre a superficie 
        //"droppable" pois é necessário o reconhecimento da área através do raycast.
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    //Esse método é a implementação da interface: IDragHandler
    //Ele será executado quando: o drag estiver sendo executado (constantemente durante o moviemnto)
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag --> foi chamado");
        //this.transform.position = Input.mousePosition;
        this.transform.position = eventData.position;




    }

    //Esse método é a implementação da interface: IEndDragHandler
    //Ele será executado quando: o drag acabar (soltar o mouse) (será executado apenas 1 vez)
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag --> foi chamado");


        //devolve o card como parente do container
        this.transform.SetParent(parentToReturnTo);

        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
