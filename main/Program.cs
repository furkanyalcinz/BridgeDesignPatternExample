
using main;

var merchant = new Merchant(new TradeBehavior());
var warrior = new Warrior(new AttackBehavior());

merchant.Move();
merchant.Interract();

warrior.Move();
warrior.Interract();


