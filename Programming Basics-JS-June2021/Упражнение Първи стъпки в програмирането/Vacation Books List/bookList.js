function bookList(input) {
    let pages = Number(input[0]);
    let pagesForOneHour = Number(input[1]);
    let days = Number(input[2]);

    let allTime = pages / pagesForOneHour;
    let hoursForDay = allTime / days;
    console.log(hoursForDay);
}

bookList(["212 ","20 ","2 "]);