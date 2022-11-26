/*
DTO_New_request

    model.List_DTO_List_warrants_type

*/

$(function () {
    //var panel_tv = $(".panel_tv");
    //if (panel_tv !== null && panel_tv !== undefined) {
    //    panel_tv.show();
    //}
});

function ddl_warrant_type_onChange() {
    var ddl_warrant_type = $("#Warrant_type_ID :selected").text();
    var panel = $(".panel");

    // hide all panels
    if (ddl_warrant_type !== null && ddl_warrant_type !== undefined &&
        panel !== null && panel !== undefined) {
        panel.hide();

        // TV
        ddl_warrant_type = $.trim(ddl_warrant_type);
        if (ddl_warrant_type == "Televisor") {
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

function ddl_warrant_brand_onChange() {
    var ddl_brand = $("#Brand_ID :selected").val();
    if (ddl_brand !== null && ddl_brand !== undefined) {

        // s: https://www.c-sharpcorner.com/article/different-ways-bind-the-value-to-razor-dropdownlist-in-aspnet-mvc5/

        $("#Model_ID option").remove();
        ddl_brand = $.trim(ddl_brand);

        console.log("Ajax call: /Pledge_request/GetModelsByBrandID. Params:");
        console.log("ddl_brand, type: " + type(ddl_brand) + ", value: " + ddl_brand);

        $.ajax({
            type: "POST",
            url: "/Pledge_request/GetModelsByBrandID",
            data: {
                ddl_brand: ddl_brand
            },
            success: function (response) {
                if (response !== null && response !== undefined) {
                    $(response).each(function () {
                        $("#Model_ID").append($("<option></option>").val(this.list_TV_brand_models_ID).html(this.name));
                    });
                } else {
                }
            },
            failure: function (response) {
                show_alert_error("Ups. Ocurrió un error interno.");
            }
        }); // Ajax
    }
}
