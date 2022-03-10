public interface IState
{
    void Enter();
    void Exit();
    void LogicUpdate();
    void PhysicUpdate();
}