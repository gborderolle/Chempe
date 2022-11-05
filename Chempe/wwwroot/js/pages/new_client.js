$(function () {
    $(".datepicker").datepicker({ dateFormat: 'dd/mm/yy' });
});

function btn_submit() {
    var input_name = $("#input_name").val();
    var input_phone = $("#input_phone").val();
    var input_borndate = $("#input_borndate").val();
    var input_email = $("#input_email").val();
    var input_password1 = $("#input_password1").val();
    var input_password2 = $("#input_password2").val();
    var input_radioGender1 = $("#input_radioGender1").val();
    var input_identity = $("#input_identity").val();
    var input_checkTerms = $("#input_checkTerms").val();

    if (input_name !== null && input_name !== undefined &&
        input_phone !== null && input_phone !== undefined &&
        input_borndate !== null && input_borndate !== undefined &&
        input_email !== null && input_email !== undefined &&
        input_password1 !== null && input_password1 !== undefined &&
        input_password2 !== null && input_password2 !== undefined &&
        input_identity !== null && input_identity !== undefined &&
        input_checkTerms !== null && input_checkTerms !== undefined) {

        console.log("Ajax call: /Add_user_client. Params:");
        console.log("input_name, type: " + type(input_name) + ", value: " + input_name);
        console.log("input_phone, type: " + type(input_phone) + ", value: " + input_phone);
        console.log("input_borndate, type: " + type(input_borndate) + ", value: " + input_borndate);
        console.log("input_email, type: " + type(input_email) + ", value: " + input_email);
        console.log("input_password1, type: " + type(input_password1) + ", value: " + input_password1);
        console.log("input_identity, type: " + type(input_identity) + ", value: " + input_identity);

        $.ajax({
            type: "POST",
            url: "/User_client/Add_user_client",
            data: {
                input_name: input_name,
                input_phone: input_phone,
                input_borndate: input_borndate,
                input_email: input_email,
                input_password1: input_password1,
                input_identity: input_identity
            },
            success: function (response) {
                if (response !== null && response !== undefined) {
                    if (response) {
                        console.log("Add_user_client: Success");
                        show_alert_success("Confirmado", "El usuario fue creado correctamente.");
                    } else {
                        show_alert_error("Ups. Ocurrió un error interno.");
                    }
                } else {
                    show_alert_error("Ups. Ocurrió un error interno.");
                }
            },
            failure: function (response) {
                console.log("Add_user_client: Error");
                show_alert_error("Ups. Ocurrió un error interno.");
            }
        }); // Ajax

    }

}