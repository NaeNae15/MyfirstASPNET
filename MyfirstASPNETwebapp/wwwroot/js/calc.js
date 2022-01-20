$("#btnSend").submit(function () {
    var int1 = parseInt($("#assignments").val(),10)
    var int2 = parseInt($("#quiz").val(),10);
    var int3 = parseInt($("#intex").val(), 10);
    var total = int1 + int2 + int3;
    var avg = total / 3;

    var grade = String;

    if (avg > 90) {
        grade = "A";
    }
    else if(avg > 80) {
        grade = "B";
    } else if(avg > 70) {
        grade = "C";
    } else if(avg > 50) {
        grade = "D";
    } else 
        grade = "F";
    

    (#)
    alert("Your final percentage is : " + avg.toFixed(2) + "%." + "\n"
        + "Your final grade would be: " + grade);
})