function food(input) {
    let chickenMenu = Number(input[0]);
    let fishMenu = Number(input[1]);
    let vegetarianMenu = Number(input[2]);

    let priceForChickenMenu = chickenMenu * 10.35;
    let priceFishMenu = fishMenu * 12.40;
    let priceVegetarianMenu = vegetarianMenu * 8.15;
    let allPrice = priceForChickenMenu + priceFishMenu + priceVegetarianMenu;
    let priceDesert = allPrice * 0.20;
    let finalSum = allPrice + priceDesert + 2.50;
    console.log(finalSum);
}

food(["2 ","4 ","3 "]);
