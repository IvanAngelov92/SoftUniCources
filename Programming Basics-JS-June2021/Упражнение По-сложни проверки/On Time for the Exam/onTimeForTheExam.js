function onTime(input) {
 
    let examHour = Number(input[0]);
    let examMinute = Number(input[1]);
    let studentHour = Number(input[2]);
    let studenMinute = Number(input[3]);
 
    let totalMinutesExam = (examHour * 60) + examMinute;
    let totalMinutesStudent = (studentHour * 60) + studenMinute;
    let difference = 0;
    let hours = 0;
    let minute = 0;
 
    if (totalMinutesExam > totalMinutesStudent) {
        difference = totalMinutesExam - totalMinutesStudent;
        if (difference >= 1 && difference <= 30) {
            console.log('On time');
            console.log(`${difference} minutes before the start`);
        } else if (difference > 30 && difference <= 59) {
            console.log('Early');
            console.log(`${difference} minutes before the start`);
        } else if (difference >= 60) {
            hours = Math.floor(difference / 60);
            minute = (difference % 60);
            if (minute < 10) {
                console.log('Early');
                console.log(`${hours}:0${minute} hours before the start`);
            }
                else {
                    console.log('Early');
                    console.log(`${hours}:${minute} hours before the start`);
                }
            }
        }
     else if (totalMinutesExam < totalMinutesStudent) {
        difference = totalMinutesStudent - totalMinutesExam;
        if (difference >= 1 && difference <= 59) {
            console.log('Late');
            console.log(`${difference} minutes after the start`);
        } else if (difference >= 60) {
            hours = Math.floor(difference / 60);
            minute = (difference % 60);
            if (minute < 10) {
                console.log('Late');
                console.log(`${hours}:0${minute} hours after the start`);
            } else {
                console.log('Late');
                console.log(`${hours}:${minute} hours after the start`);
            }
        }
    } else if (totalMinutesExam === totalMinutesStudent) {
        console.log('On time');
    }
}
onTimeForTHeExam(["9","30","9","50"]);