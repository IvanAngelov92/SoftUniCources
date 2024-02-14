function figures(input) {
    let type = input[0];

    if(type === "square") {
        let number = Number(input[1]);
        let sum = number * number;
        console.log(sum.toFixed(3));
    } else if(type === "rectangle") {
        let number = Number(input[1]);
        let numberTwo = Number(input[2]);
        let sum = number * numberTwo;
        console.log(sum.toFixed(3));
    } else if(type === "circle") {
        let number = Number(input[1]);
        let sum = Math.PI * number * number;
        console.log(sum.toFixed(3));
    } else if(type === "triangle") {
        let number = Number(input[1]);
        let numberTwo = Number(input[2]);
        let sum = number * numberTwo / 2;
        console.log(sum.toFixed(3));
    }
}
figures(["circle","6"]);
