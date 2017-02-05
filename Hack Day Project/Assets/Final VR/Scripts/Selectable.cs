using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selectable : MonoBehaviour, ISelectable, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    protected FinalGameController GameController;

    private Renderer _renderer;
    private Shader _regularShader;
    private Shader _highlightShader;

    public void Awake()
    {
        GameController = GameObject.FindGameObjectWithTag(Tags.GameController).GetComponent<FinalGameController>();

        _renderer = GetComponent<Renderer>();
        _regularShader = _renderer.material.shader;
        _highlightShader = Shader.Find("Unlit/Color");
    }

    public virtual void Select()
    {
        GameController.CurrentSelected = this;
    }

    public virtual void Unselect()
    {
        GameController.CurrentSelected = null;
    }

    public void Highlight()
    {
        _renderer.material.shader = _highlightShader;
    }

    public void Unhighlight()
    {
        _renderer.material.shader = _regularShader;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Select();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Highlight();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Unhighlight();
    }
}
