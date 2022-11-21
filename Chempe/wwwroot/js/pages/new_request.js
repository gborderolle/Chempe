/*
DTO_New_request

    model.List_DTO_List_warrants_type

*/

function ddl_warrant_type_onChange() {
    var ddl_warrant_type = $("#ddl_warrant_type :selected").text();
    if (ddl_warrant_type !== null && ddl_warrant_type !== undefined) {

        ddl_warrant_type = $.trim(ddl_warrant_type);
        if (ddl_warrant_type =="Televisor") {
            var panel_tv = $(".panel_tv");
            if (panel_tv !== null && panel_tv !== undefined) {
                panel_tv.show();
            }
        }

        /*
        var List_DTO_List_warrants_type = model.List_DTO_List_warrants_type;
        if (List_DTO_List_warrants_type !== null && List_DTO_List_warrants_type !== undefined) {
        }
        */
    }
}

function btn_submit() {

    var upload_file = $("#file_document1").get(0);
    var files = upload_file.files;
    var file_data = new FormData();

    //image 1:
    file_data.append('file_data', files[0]);

    //image 2:
    upload_file = $("#file_document2").get(0);
    files = upload_file.files;
    file_data.append('file_data', files[0]);

    //person identification:
    file_data.append('file_data', model.DTO_Person.Identification);

    // s: https://javascript.info/formdata

    console.log("Ajax call: /UploadFile. Params:");
    console.log("model.Person, type: " + type(model.Person) + ", value: " + model.Person);
    console.log("file_data, type: " + type(file_data) + ", value: " + file_data);

    $.ajax({
        type: "POST",
        url: "/User_client/UploadFile",
        data: file_data,
        //data: {
        //    dto_person: model.Person,
        //    file_data: file_data
        //},
        processData: false, // new
        contentType: false, // new

        success: function (response) {
            if (response !== null && response !== undefined) {
                if (response) {
                    console.log("UploadFile: Success");
                    $("#divInformation").show();
                    show_alert_success("Confirmado", "Los archivos se subieron correctamente.");
                } else {
                    show_alert_error("Ups. Ocurrió un error interno.");
                }
            } else {
                show_alert_error("Ups. Ocurrió un error interno.");
            }
        },
        failure: function (response) {
            console.log("UploadFile: Error");
            show_alert_error("Ups. Ocurrió un error interno.");
        }
    }); // Ajax


}