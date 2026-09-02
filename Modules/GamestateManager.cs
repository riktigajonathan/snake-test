namespace snake_test;

public static partial class GamestateManager
{
    private static readonly List<Gamestate> states = new();
    private static Gamestate? currentState = null;

    public static void InitStates()
    {
        states.Clear();
        currentState = null;
    }

    public static void AddState(Gamestate state)
    {
        states.Add(state);
    }

    public static void Update()
    {
        currentState?.Update();
    }

    public static void ChangeState(string stateName)
    {
        Gamestate? nextState = FindState(stateName);
        if (nextState == null) return;

        currentState?.OnExit();
        currentState = nextState;
        currentState.OnEnter();
    }

    public static Gamestate? FindState(string stateName)
    {
        return states.FirstOrDefault(s => s.StateName == stateName);
    }
}