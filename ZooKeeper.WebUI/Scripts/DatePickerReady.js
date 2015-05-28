$(function () {
    $('#DateOfBirth').datetimepicker({
        format: 'DD/MM/YYYY',
        minDate: '01.01.1900'
    });

    $.validator.addMethod(
         "date",
         function (value, element) {
             var bits = value.match(/([0-9]+)/gi), str;
             if (!bits)
                 return this.optional(element) || false;
             str = bits[1] + '/' + bits[0] + '/' + bits[2];
             return this.optional(element) || !/Invalid|NaN/.test(new Date(str));
         },
         "Please enter a date in the format dd/mm/yyyy"
     );
});