function calculator(input) {
    let depositSum = Number(input[0]);
    let termDeposit = Number(input[1])
    let percentForYear = Number(input[2]);

    let interest = (depositSum * percentForYear) / 100;
    let interestForMonth = interest / 12;
    let allSum = depositSum + (termDeposit * interestForMonth);
    console.log(allSum.toFixed(2))
}

calculator(["200 ","3 ","5.7 "])