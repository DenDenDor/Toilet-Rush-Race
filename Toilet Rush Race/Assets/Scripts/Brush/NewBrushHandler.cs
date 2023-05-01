using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewBrushHandler
{
    private List<IPossibleRequest> _possibleRequests = new List<IPossibleRequest>();
    public NewBrushHandler(ChooserCurrentCharacter chooserCurrentCharacter)
    {
        _possibleRequests.Add(new ClickedCharacterRequest(chooserCurrentCharacter));
    }
    public bool CanCreate() => _possibleRequests.All(e => e.CanCreateBrush());
}
