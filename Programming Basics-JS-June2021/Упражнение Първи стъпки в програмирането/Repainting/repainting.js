function repainting(input) {
    let amounthOfNylon = Number(input[0]);
    let amounthPaint = Number(input[1]);
    let thinner = Number(input[2]);
    let hours = Number(input[3]);

    let sumForNylon = (amounthOfNylon + 2) * 1.50;
    let priceForPainting = (amounthPaint * 1.10) * 14.50;
    let sumForThinner = thinner * 5;
    let sumForAllMaterials = sumForNylon + priceForPainting + sumForThinner + 0.40;
    let sumForWorkers = (sumForAllMaterials * 0.30) * hours;
    let finalSum = sumForAllMaterials + sumForWorkers;
    console.log(finalSum);
}
repainting(["10 ","11 ","4 ","8 "]);

repainting(["5 ","10 ","10 ","1 "]);