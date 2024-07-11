using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClass : MonoBehaviour
{
    //Each tile contains the coordinate
    //Index of the current tiles
    //Each tile contains a stack of levels
    
    //A level contains two var: interpretation and givenColor
    public class TileLevel
    {
        public TileLevel(int givenColor)
        {
            GivenColor = givenColor;
        }
        public int GivenColor;
        public int Interpretation;
    }

    public List<TileLevel> TileLevelStack = new List<TileLevel>();

    public List<Color> appearance;

    private SpriteRenderer _spriteRenderer;

    // private void Start()
    // {
    //     _spriteRenderer = this.GetComponent<SpriteRenderer>();
    // }

    public void AddLevel(int givenColor)
    {
        TileLevelStack.Add(new TileLevel(givenColor));
        UpdateAppearance();
    }

    public int Poplevel()
    {
        int lastItemIndex = TileLevelStack.Count - 1;
        int givenColor = TileLevelStack[lastItemIndex].GivenColor;
        TileLevelStack.RemoveAt(lastItemIndex);
        return givenColor;
    }
    
    //for now, we give interpretation according to former tile
    //interpretation also depends on the tiles around, therefore it is controlled by GroundManager
    public void UpdateInterpretation(int interpretation)
    {
        //if it is an animal, then we need to create a new tile
        //then attach a relevant class to that animal
        //else 
        //update propterty and appearance
    }
    
    //for now we don't need property
    //inherit according to the interpretation
    private void UpdateProperty()
    {
        
    }
    
    //for now appearance is the base color, then give a text presenting its interpretation
    private void UpdateAppearance()
    {
        _spriteRenderer = this.GetComponent<SpriteRenderer>();
        int lastItemIndex = TileLevelStack.Count - 1;
        if(appearance.Count > TileLevelStack[lastItemIndex].GivenColor)
            _spriteRenderer.color = appearance[TileLevelStack[lastItemIndex].GivenColor];
    }
    
    
}
