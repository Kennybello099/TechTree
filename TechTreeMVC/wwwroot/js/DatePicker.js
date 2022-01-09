$(function () {

    function WireUpDatePicker() {

        const addMonths = 2;
        var currDate = new Date();
        $('.datepicker').datepicker(
            {
                dateFormat: 'yy-mm-dd',
                minDate: currDate,
                manDate: AddSubtractMonths(currDate, addMonths),
            }
        );
    }


    WireUpDatePicker() 

});



