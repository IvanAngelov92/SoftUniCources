function vacation(input) {
    let index = 0;
    let moneyNeeded = input[index];
    index++;
    let cash = Number(input[index])
    index++

    let daysCounter = 0;
    let spendCounter = 0;
    let sum = 0;

    while (input[index] !== undefined) {
        let command = input[index];
        switch (command) {
            case "spend":
                index++;
                sum -= Number(input[index]);
                spendCounter++;
                break;

            case "save":
                index++;
                sum+=Number(input[index]);
                break;
        }
        daysCounter++;
        index++;
    }

    if(spendCounter >= 5) {
        console.log(`You can't save the money.`);
        console.log(`${daysCounter}`);
    } else {
        console.log(`You saved the money for ${daysCounter} days.`);
    }

}
vacation(["110","60","spend","10","spend","10","spend","10","spend","10","spend","10"]);
