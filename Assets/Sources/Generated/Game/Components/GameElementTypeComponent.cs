//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ElementTypeComponent elementType { get { return (ElementTypeComponent)GetComponent(GameComponentsLookup.ElementType); } }
    public bool hasElementType { get { return HasComponent(GameComponentsLookup.ElementType); } }

    public void AddElementType(int newValue) {
        var index = GameComponentsLookup.ElementType;
        var component = CreateComponent<ElementTypeComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceElementType(int newValue) {
        var index = GameComponentsLookup.ElementType;
        var component = CreateComponent<ElementTypeComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveElementType() {
        RemoveComponent(GameComponentsLookup.ElementType);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherElementType;

    public static Entitas.IMatcher<GameEntity> ElementType {
        get {
            if (_matcherElementType == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ElementType);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherElementType = matcher;
            }

            return _matcherElementType;
        }
    }
}