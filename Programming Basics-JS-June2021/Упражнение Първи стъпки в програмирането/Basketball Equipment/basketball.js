function basketball(input) {
    let tax = Number(input[0]);

    let kec = tax * 0.60;
    let outfit = kec * 0.80;
    let ball = outfit / 4;
    let accessories = ball / 5;
    let allPrice = tax + kec + outfit + ball + accessories
    console.log(allPrice);
}

basketball(["365 "]);