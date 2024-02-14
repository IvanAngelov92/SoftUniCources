function solve(input) {
    let i = 0
    let country = input[i];
    i++;
    let total = 0;
 
    while (country !== 'End') {
        let budget = Number(input[i]);
        i++;
 
        let money = Number(input[i]);
 
        while (budget > total) {
            money = Number(input[i])
 
            total += money;
            if (total >= budget) {
                total = 0;
                console.log(`Going to ${country}!`);
                break;
            }
            i++;
            money = input[i];
        }
        i++;
        country = input[i];
        i++
        budget = input[i];
 
 
    }
 
 
}