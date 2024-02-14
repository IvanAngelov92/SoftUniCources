function school(input) {
    let packedHimikals = Number(input[0]);
    let packedMarkers = Number(input[1]);
    let leters = Number(input[2]);
    let percent = Number(input[3]);

    let priceForHimikals = packedHimikals * 5.80;
    let priceForMarkers = packedMarkers * 7.20;
    let priceForLeters = leters * 1.20;
    let priceForAllMaterials = priceForHimikals + priceForMarkers + priceForLeters;
    let resultPercent = percent / 100;
    let priceWithDiscount = priceForAllMaterials - (priceForAllMaterials * resultPercent);
    console.log(priceWithDiscount);
}

school(["4 ","2 ","5 ","13 "]);