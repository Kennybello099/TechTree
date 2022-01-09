function AddSubtractMonths(date, numMonths) {
    var month = date.getMonth();

    var miliseconds = new Date(date).setDate(month + numMonths);

    return new Date(miliseconds);
}
