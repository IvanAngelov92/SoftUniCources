int basketballTrainingFee = int.Parse(Console.ReadLine());

double priceOfBasketballSneakers = basketballTrainingFee * 0.60;
double pricePerBasketballTeam = priceOfBasketballSneakers * 0.80;
double priceOfBasketball = pricePerBasketballTeam / 4;
double priceOfBasketballAccessories = priceOfBasketball / 5;
double totalPrice = basketballTrainingFee + priceOfBasketballSneakers + pricePerBasketballTeam + priceOfBasketball + priceOfBasketballAccessories;

Console.WriteLine($"{totalPrice}");
