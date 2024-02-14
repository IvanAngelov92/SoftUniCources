function toyShop(input) {
    let price = Number(input[0]);
    let puzzleCount = Number(input[1]);
    let dollCount = Number(input[2]);
    let bearCount = Number(input[3]);
    let minionsCount = Number(input[4]);
    let truckCount = Number(input[5]);

    let money = puzzleCount * 2.60 + dollCount * 3 + bearCount * 4.1 + minionsCount * 8.20 + truckCount * 2;
    let toyCount = puzzleCount + dollCount + bearCount + minionsCount + truckCount;

    if(toyCount >= 50) {
        money = money * 0.75;
    }
    rent = money * 0.10;

    money = money - rent;
    
    if(money >= price) {
        money = money - price;
        console.log(`Yes! ${money.toFixed(2)} lv left.`);
    } else {
        money = Math.abs(money - price);
        console.log(`Not enough money! ${money.toFixed(2)} lv needed.`);
    }
}
toyShop(["320","8","2","5","5","1"]);