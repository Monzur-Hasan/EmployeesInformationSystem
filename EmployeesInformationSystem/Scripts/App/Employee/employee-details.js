$('#Department').change(function () {
    var departmentDD = $('#Department');
    var deptId = departmentDD.val();

    var jsonRequestData = { departmentId: deptId };


    // ajax request to student/getbydistrict

    $.ajax(
        {
            url: "/employee/GetByDepartment",
            type: "POST",
            data: jsonRequestData,
            success: function (employees) {

                var employeeDD = $('#Employee');

                $('#Employee').empty();

                $('#Employee').append('<option>..Select..</option>');

                $.each(employees,
                    (key, employee) => {
                        var option = "<option value='" + employee.Id + "'>" + employee.Name + "</option>";
                        employeeDD.append(option);
                    }
                );

            },

            error: function (response) {
                alert(response);
            }

        }
    );
});


$('#Employee').change(function () {

    var employeeId = $('#Employee').val();

    var jsonRequestData = { employeeId: employeeId };


    $.ajax({

        url: "/employee/ GetEmployeeDetailsPartial",
        type: "GET",
        data: jsonRequestData,

        success: (employeeDetailsPartial) => {
            $('#divEmployeeInfo').empty();
            $('#divEmployeeInfo').append(employeeDetailsPartial);
        }

    });

});
