function sumPrimeNonPrime(input) {
    let index = 0;
    let sumSimleNums = 0;
    let sumComplexNums = 0;
    let currentInput = input[index];
    let isComplex = false;

    while (currentInput !== `stop`) {
        let num = Number(currentInput);
        if (num < 0) {
            console.log(`Number is negative.`);
            index++;
            currentInput = input[index];
            continue;
        } else {
            for (let i = 2; i < num; i++) {
                if (num % i === 0) {
                    isComplex = true;
                    break;
                }
            }
        }
        if (isComplex) {
            sumComplexNums += num;
            isComplex = false;
        } else {
            sumSimleNums += num;
        }
        index++;
        currentInput = input[index];
    }

    console.log(`Sum of all prime numbers is: ${sumSimleNums}`);
    console.log(`Sum of all non prime numbers is: ${sumComplexNums}`);
}
sumPrimeNonPrime(["3", "9", "0", "7", "19", "4", "stop"]);
