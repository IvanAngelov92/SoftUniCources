function petShop(input) {
    let foodForDogs = Number(input[0]);
    let foodForCats = Number(input[1]);

    let sumForDogs = foodForDogs * 2.50;
    let sumForCats = foodForCats * 4;
    let finalSum = sumForDogs + sumForCats;

    console.log(`${finalSum} lv.`);
}
petShop(["5 ","4 "]);