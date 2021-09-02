namespace Asteroids2D
{
    public class EnemyShipController : IUpdateExecute
    {
        private  EnemyShip _enemyShip;
        private  EnemyShipModel _enemyShipModel;
        private  EnemyShipView _enemyShipView;

        public EnemyShipController(EnemyShip enemyShip, EnemyShipModel enemyShipModel, EnemyShipView enemyShipView)
        {
            _enemyShip = enemyShip;
            _enemyShipModel = enemyShipModel;
            _enemyShipView = enemyShipView;
        }
        
        public void UpdateExecute()
        {
            _enemyShip.Attack();
            _enemyShip.Move();
        }
        
    }
}