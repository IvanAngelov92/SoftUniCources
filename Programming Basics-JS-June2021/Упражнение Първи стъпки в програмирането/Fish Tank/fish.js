function fish(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let heigth = Number(input[2]);
    let percent = Number(input[3]);

    let capacity = length * width * heigth;
    let capacityInLeters = capacity / 1000;
    let resultPercent = percent / 100;
    let neededLeters = capacityInLeters * (1 - resultPercent);
    console.log(neededLeters);
}

fish(["85 ","75 ","47 ","17 "]);